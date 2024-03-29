﻿using OSM2018.Algorithm.AAT;
using OSM2018.Interfaces;
using OSM2018.Interfaces.Algo;
using OSM2018.Networks.LayoutGenerator;
using OSM2018.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSM2018.GUIs
{
    public partial class AnimationForm : Form
    {
        struct AgentView
        {
            public float X { get; private set; }
            public float Y { get; private set; }
            public float R { get; private set; }
            public int ID { get; private set; }
            public float PenWidth { get; private set; }
            public int Degree { get; private set; }
            bool _IsView;

            public AgentView(float x, float y, float r, float width, int id, int d, int radius_scale = 1)
            {
                this.X = x;
                this.Y = y;
                this.R = (float)(r * Math.Log(d));
                if (this.R == 0 || d == 0) this.R = 1;
                this.R *= radius_scale;
                this.ID = id;
                this.PenWidth = width;
                this.Degree = d;
                this._IsView = true;
            }

            public bool IsInclude(int x, int y)
            {
                var tmp = (this.X - x) * (this.X - x) + (this.Y - y) * (this.Y - y);
                float R2 = this.R * 3 / 2;
                if (tmp <= R2 * R2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            public bool IsView()
            {
                return this._IsView;
            }

            public bool SetView(bool is_view)
            {
                this._IsView = is_view;
                return _IsView;
            }
        }

        struct EdgeView
        {
            public Point SourcePoint { get; private set; }
            public int SourceID { get; private set; }
            public Point TargetPoint { get; private set; }
            public int TargetID { get; private set; }
            public int ID { get; private set; }
            public Dictionary<int, double> SourceWeightDic { get; private set; }
            public Dictionary<int, double> TargetWeightDic { get; private set; }

            public EdgeView(Point s, int s_id, Point t, int t_id, int id, Dictionary<int, double> source_weight_dic, Dictionary<int, double> target_weight_dic)
            {
                this.SourcePoint = s;
                this.SourceID = s_id;
                this.TargetPoint = t;
                this.TargetID = t_id;
                this.ID = id;
                this.SourceWeightDic = source_weight_dic;
                this.TargetWeightDic = target_weight_dic;
            }

            public bool IsNeighbor(int agent_id)
            {
                if (this.SourceID == agent_id || this.TargetID == agent_id)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        MainForm MyMF;
        internal I_OSM MyOSM;


        DrawSetting MyDrawSetting;
        Pen MyPen;
        List<int> SelectedAgentList;
        List<int> SelectedEdgeList;
        List<int> NeighborAgentList;
        int NodeSizeScale;
        delegate void MyDelegate();

        List<AgentView> AgentViewList;
        List<EdgeView> EdgeViewList;
        float ViewScale;
        float ViewX;
        float ViewY;
        float ViewOriginX;
        float ViewOriginY;
        //mouse
        bool isDragging;
        float DraggingOldX;
        float DraggingOldY;

        public AnimationForm(MainForm mf)
        {
            this.MyMF = mf;
            InitializeComponent();
            this.UserInitialize();
            this.InitializeNetwork();
        }

        internal void SetOSM(I_OSM osm)
        {
            this.MyOSM = osm;
        }

        void UserInitialize()
        {
            foreach (LayoutEnum layout in Enum.GetValues(typeof(LayoutEnum)))
            {
                this.comboBoxLayout.Items.Add(layout.ToString());
            }
            this.comboBoxLayout.SelectedIndex = 0;

            this.MyDrawSetting = new DrawSetting();

            this.ViewScale = 1;
            this.ViewX = 0;
            this.ViewY = 0;
            this.ViewOriginX = 0;
            this.ViewOriginY = 0;
            this.NodeSizeScale = this.trackBarRadius.Value;

            this.MouseWheel += new MouseEventHandler(this.pictureboxAnimation_MouseWheel);

            this.comboBoxLayout.SelectedIndex = 0;
        }

        void InitializeNetwork()
        {
            this.SelectedAgentList = new List<int>();
            this.SelectedEdgeList = new List<int>();
            this.NeighborAgentList = new List<int>();
        }

        string GetLayoutText()
        {
            string layout_str = null;

            if (this.comboBoxLayout.IsDisposed) return null;
            if (this.comboBoxLayout.InvokeRequired)
            {
                this.Invoke((MethodInvoker)delegate { layout_str = GetLayoutText(); });
            }
            else
            {
                layout_str = this.comboBoxLayout.Text;
            }

            return layout_str;
        }

        public void UpdateLayout()
        {
            if (this.MyOSM.MyNetwork == null) { return; }
            var layout_str = this.GetLayoutText();
            I_Layout layout = null;

            switch ((LayoutEnum)Enum.Parse(typeof(LayoutEnum), layout_str, true))
            {
                case LayoutEnum.Circular:
                    layout = new Circular_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.FruchtermanReingold:
                    layout = new FR_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.KamadaKawai:
                    layout = new KK_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.Random:
                    layout = new Random_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.Shell:
                    layout = new Shell_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.Spectral:
                    layout = new Spectral_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.Spring:
                    layout = new Spring_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                case LayoutEnum.Square:
                    layout = new Square_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
                default:
                    layout = new Circular_LayoutGenerator(this.MyOSM.MyNetwork).Generate();
                    break;
            }
            this.MyOSM.MyNetwork.SetLayout(layout);
        }

        public void UpdatePictureBox()
        {
            this.pictureBoxAnimation.Invalidate();
            this.UpdateInfo();
        }

        void UpdateInfo()
        {
            if (this.NullCheck() || this.SelectedAgentList.Count == 0) return;

            Console.WriteLine("-----");
            this.MyOSM.PrintNodeInfo(this.SelectedAgentList.Last());
            if (this.MyOSM.MyAgentSet == null) return;
            this.MyOSM.PrintAgentInfo(this.SelectedAgentList.Last());
            if (this.MyOSM.MyAlgo == null) return;
            this.MyOSM.PrintAlgoAgentInfo(this.SelectedAgentList.Last());
        }

        Matrix GetBaseMatrix(I_Network network, I_AgentSet agent_set)
        {
            this.SetAgentViewList(network);
            this.SetEdgeViewList(network, agent_set);

            var CentralX = this.pictureBoxAnimation.ClientSize.Width / 2;
            var CentralY = this.pictureBoxAnimation.ClientSize.Height / 2;
            this.ViewX += CentralX;
            this.ViewY += CentralY;

            var base_matrix = new Matrix();
            base_matrix.Scale(this.ViewScale, this.ViewScale);
            base_matrix.Translate(this.ViewX, this.ViewY);
            return base_matrix;

        }

        internal void SetAgentViewList(I_Network network)
        {
            this.AgentViewList = new List<AgentView>();

            var layout = network.MyLayout;
            var ori_min_x = layout.PosList.Select(pos => pos.X).Min();
            var ori_max_x = layout.PosList.Select(pos => pos.X).Max();
            var ori_min_y = layout.PosList.Select(pos => pos.Y).Min();
            var ori_max_y = layout.PosList.Select(pos => pos.Y).Max();

            var ori_width = Math.Abs(ori_max_x - ori_min_x);
            var ori_height = Math.Abs(ori_max_y - ori_min_y);

            var width_div = this.FixClientWidth() / ori_width;
            var height_div = this.FixClientHeight() / ori_height;
            width_div /= 1.1;
            height_div /= 1.1;

            var pos_scale = (int)Math.Min(width_div, height_div);

            foreach (var node in network.NodeList)
            {
                int x = (int)(layout.PosList[node.NodeID].X * pos_scale);
                int y = (int)(layout.PosList[node.NodeID].Y * pos_scale);
                int r = (int)(this.FixClientWidth() / Math.Pow(layout.PosList.Count, 2));
                if (r == 0) r = 1;
                int w = r / 2;
                int d = node.NeighborNodeIDList.Count;

                this.AgentViewList.Add(new AgentView(x, y, r, w, node.NodeID, d, this.NodeSizeScale));
            }

            var ave_central_x = layout.PosList.Select(pos => pos.X).Average();
            var ave_central_y = layout.PosList.Select(pos => pos.Y).Average();

            this.ViewX = -1 * (int)(ave_central_x * pos_scale) + this.ViewOriginX;
            this.ViewY = -1 * (int)(ave_central_y * pos_scale) + this.ViewOriginY;
        }

        internal void SetEdgeViewList(I_Network network, I_AgentSet agent_set)
        {
            this.EdgeViewList = new List<EdgeView>();

            foreach (var edge in network.EdgeList)
            {
                Point s_point = new Point((int)this.AgentViewList[edge.SourceNodeID].X, (int)this.AgentViewList[edge.SourceNodeID].Y);
                Point t_point = new Point((int)this.AgentViewList[edge.TargetNodeID].X, (int)this.AgentViewList[edge.TargetNodeID].Y);
                Dictionary<int, double> s_wei_dic = null;
                Dictionary<int, double> t_wei_dic = null;
                if (agent_set != null)
                {
                    s_wei_dic = agent_set.AgentList.First(agent => agent.NodeID == edge.SourceNodeID).WeightDic;
                    t_wei_dic = agent_set.AgentList.First(agent => agent.NodeID == edge.TargetNodeID).WeightDic;
                }
                this.EdgeViewList.Add(new EdgeView(s_point, edge.SourceNodeID, t_point, edge.TargetNodeID, edge.EdgeID, s_wei_dic, t_wei_dic));
            }
        }

        int FixClientWidth()
        {
            var fix_scale = 1.1;
            return (int)(this.pictureBoxAnimation.ClientSize.Width / fix_scale);
        }

        int FixClientHeight()
        {
            var fix_scale = 1.1;
            return (int)(this.pictureBoxAnimation.ClientSize.Height / fix_scale);
        }



        #region view

        void UpdateEdge(PaintEventArgs e)
        {
            this.MyPen = (Pen)this.MyDrawSetting.LinkPen.Clone();
            var base_edge_width = this.MyPen.Width / this.ViewScale;

            this.MyPen.Width = base_edge_width;
            foreach (var edge_view in EdgeViewList)
            {
                e.Graphics.DrawLine(this.MyPen, edge_view.SourcePoint, edge_view.TargetPoint);

            }
        }


        void UpdateAgent(PaintEventArgs e, Matrix base_matrix)
        {
            //エージェント表示簡易版
            if (this.MyOSM.MyAgentSet == null)
            {
                foreach (var node in this.MyOSM.MyNetwork.NodeList)
                {
                    int node_id = node.NodeID;
                    float r = this.AgentViewList[node_id].R;
                    float r2 = r * 2;
                    float r3 = r * 3;
                    float r4 = r * 4;
                    float r5 = r * 5;
                    float r_outer = r3;
                    Matrix agentMatrix = base_matrix.Clone();

                    //エージェントの位置に移動
                    agentMatrix.Translate(this.AgentViewList[node_id].X, this.AgentViewList[node_id].Y);
                    e.Graphics.Transform = agentMatrix.Clone();

                    this.DrawNullNode(e, r_outer);
                }
                return;
            }

            foreach (var agent in this.MyOSM.MyAgentSet.AgentList)
            {
                int node_id = agent.NodeID;
                float r = this.AgentViewList[node_id].R;
                float r2 = r * 2;
                float r3 = r * 3;
                float r4 = r * 4;
                float r5 = r * 5;
                float r_outer = r3;
                Matrix agentMatrix = base_matrix.Clone();


                //エージェントの位置に移動
                agentMatrix.Translate(this.AgentViewList[node_id].X, this.AgentViewList[node_id].Y);
                e.Graphics.Transform = agentMatrix.Clone();


                if (this.MyOSM.MyAlgo == null)
                {
                    this.DrawNullAgent(e, agent, r_outer);
                    continue;
                }


                switch (this.MyOSM.MyAlgo.MyAlgoEnum)
                {
                    case AlgoEnum.OriginalAAT:
                    case AlgoEnum.AATD:
                    case AlgoEnum.HCII_AATD:
                    case AlgoEnum.AATD_NoTargetH:
                        this.DrawAATAgent(e, agent, r);
                        //this.DrawNullAgent(e, agent, r);
                        break;
                    case AlgoEnum.IWT:
                        this.DrawNullAgent(e, agent, r);
                        break;
                }

            }
        }

        void DrawNullNode(PaintEventArgs e, float r_outer)
        {
            e.Graphics.FillEllipse(this.MyDrawSetting.GrayBrush, -r_outer / 2, -r_outer / 2, r_outer, r_outer);
        }

        void DrawNullAgent(PaintEventArgs e, I_Agent agent, float r)
        {
            float r2 = r * 2;
            float r3 = r * 3;
            float r4 = r * 4;
            float r5 = r * 5;
            float r_outer = r3;

            var my_opinion = agent.Opinion;
            var my_belief = (float)agent.Belief;
            var my_init_belief = (float)agent.InitBelief;
            var g_sigma = (float)agent.GreenSigma;
            var r_sigma = (float)agent.RedSigma;

            if (my_opinion == InfoEnum.Green)
            {
                this.MyDrawSetting.OpinionBrush.Color = this.MyDrawSetting.OpCorrectColor;
            }
            else if (my_opinion == InfoEnum.Red)
            {
                this.MyDrawSetting.OpinionBrush.Color = this.MyDrawSetting.OpIncorrectColor;
            }
            else if (my_opinion == InfoEnum.Undeter)
            {
                this.MyDrawSetting.OpinionBrush.Color = this.MyDrawSetting.OpUndeterColor;
            }

            //意見の円
            e.Graphics.FillEllipse(this.MyDrawSetting.OpinionBrush, -r_outer / 2, -r_outer / 2, r_outer, r_outer);

            //扇型を表示
            {
                float zeroDeg = 180f;
                float sigmaLeftDeg = (r_sigma * 180f + zeroDeg);
                float sigmaRightDeg = (g_sigma * 180f + zeroDeg);
                float sigmaSweepDeg = (g_sigma - r_sigma) * 180f;


                //e.Graphics.FillPie(this.MyDrawSetting.LightGrayBrush, -r_outer / 2, -r_outer / 2, r_outer, r_outer, zeroDeg, 180);
                //e.Graphics.FillPie(this.MyDrawSetting.GrayBrush, -r_outer / 2, -r_outer / 2, r_outer, r_outer, sigmaLeftDeg, sigmaSweepDeg);
                e.Graphics.FillPie(this.MyDrawSetting.OpinionBrush, -r_outer / 2, -r_outer / 2, r_outer, r_outer, sigmaLeftDeg, sigmaSweepDeg);
                e.Graphics.FillPie(this.MyDrawSetting.RedSigmaBlush, -r_outer / 2, -r_outer / 2, r_outer, r_outer, zeroDeg, r_sigma * 180f);
                e.Graphics.FillPie(this.MyDrawSetting.GreenSigmaBlush, -r_outer / 2, -r_outer / 2, r_outer, r_outer, sigmaRightDeg, r_sigma * 180f);
            }

            //外枠の円
            if (agent.IsSensor)
            {
                this.MyPen = (Pen)MyDrawSetting.SensorPen.Clone();
                this.MyPen.Width /= this.ViewScale;
                //e.Graphics.DrawEllipse(this.MyPen, -r4 / 2, -r4 / 2, r4, r4);
                e.Graphics.DrawEllipse(this.MyPen, -r_outer / 2, -r_outer / 2, r_outer, r_outer);
            }
            else
            {
                this.MyPen = (Pen)this.MyDrawSetting.PriorBeliefPen.Clone();
                this.MyPen.Width /= this.ViewScale;
            }

            e.Graphics.DrawEllipse(this.MyPen, -r_outer / 2, -r_outer / 2, r_outer, r_outer);

            //信念のmeter
            this.MyPen = (Pen)this.MyDrawSetting.MeterPen.Clone();
            this.MyPen.Width /= this.ViewScale;
            e.Graphics.DrawLine(this.MyPen,
                0,
                0,
                (float)0.5 * r3 * (float)Math.Cos(Math.PI * my_belief + Math.PI),
                (float)0.5 * r3 * (float)Math.Sin(Math.PI * my_belief + Math.PI));


            //init belief
            this.MyPen = (Pen)this.MyDrawSetting.InitMeterPen.Clone();
            this.MyPen.Width /= this.ViewScale;
            e.Graphics.DrawLine(this.MyPen,
                (float)0.5 * r3 * (float)Math.Cos(Math.PI * my_init_belief + Math.PI),
                (float)0.5 * r3 * (float)Math.Sin(Math.PI * my_init_belief + Math.PI),
                (float)0.55 * r3 * (float)Math.Cos(Math.PI * my_init_belief + Math.PI),
                (float)0.55 * r3 * (float)Math.Sin(Math.PI * my_init_belief + Math.PI)
                );

        }

        void DrawAATAgent(PaintEventArgs e, I_Agent agent, float r)
        {
            this.DrawNullAgent(e, agent, r);
            float r2 = r * 2;
            float r3 = r * 3;
            float r4 = r * 4;
            float r5 = r * 5;
            float r_outer = r3;
            var algo = this.MyOSM.MyAlgo as AAT_Algo;

            //目盛り作成
            if (algo.CandidateSetList != null)
            {
                var scale_list = algo.CandidateSetList[agent.NodeID].GetSelectCandidate().BeliefScaleList;

                this.MyPen = (Pen)this.MyDrawSetting.BlackThinPen.Clone();
                this.MyPen.Width /= this.ViewScale;
                foreach (var scale in scale_list)
                {
                    e.Graphics.DrawLine(this.MyPen,
                              r_outer / 3 * (float)Math.Cos(Math.PI * scale + Math.PI),
                              r_outer / 3 * (float)Math.Sin(Math.PI * scale + Math.PI),
                              r_outer / 2 * (float)Math.Cos(Math.PI * scale + Math.PI),
                              r_outer / 2 * (float)Math.Sin(Math.PI * scale + Math.PI)
                              );
                }
            }
        }

        void UpdateNeighborAgent(PaintEventArgs e, Matrix base_matrix)
        {
            this.MyPen = (Pen)this.MyDrawSetting.RedPen.Clone();
            this.MyPen.Width /= this.ViewScale;

            foreach (var agent in this.AgentViewList)
            {
                if (!this.NeighborAgentList.Contains(agent.ID)) continue;
                float r = agent.R;
                float r2 = r * 2;
                float r3 = r * 3;
                float r4 = r * 4;
                float r5 = r * 5;
                float r_outer = r3;
                Matrix agentMatrix = base_matrix.Clone();

                try
                {
                    agentMatrix.Translate(this.AgentViewList[agent.ID].X, this.AgentViewList[agent.ID].Y);
                    e.Graphics.Transform = agentMatrix.Clone(); ;
                    e.Graphics.DrawEllipse(this.MyPen, -r_outer / 2, -r_outer / 2, r_outer, r_outer);
                }
                catch { }
            }
        }

        void UpdateSelectAgent(PaintEventArgs e, Matrix base_matrix)
        {
            this.MyPen = (Pen)this.MyDrawSetting.SelectedPen.Clone();
            this.MyPen.Width /= this.ViewScale;

            foreach (var agent in this.AgentViewList)
            {
                if (!this.SelectedAgentList.Contains(agent.ID)) continue;
                float r = agent.R;
                float r2 = r * 2;
                float r3 = r * 3;
                float r4 = r * 4;
                float r5 = r * 5;
                float r_outer = r3;
                Matrix agentMatrix = base_matrix.Clone();

                try
                {
                    agentMatrix.Translate(this.AgentViewList[agent.ID].X, this.AgentViewList[agent.ID].Y);
                    e.Graphics.Transform = agentMatrix.Clone(); ;
                    e.Graphics.DrawEllipse(this.MyPen, -r_outer / 2, -r_outer / 2, r_outer, r_outer);
                }
                catch { }
            }
        }

        void UpdateSelectEdge(PaintEventArgs e)
        {
            this.MyPen = (Pen)this.MyDrawSetting.SelectedLinkPen.Clone();
            this.MyPen.Width /= this.ViewScale;

            foreach (var edge in this.EdgeViewList)
            {
                if (!this.SelectedEdgeList.Contains(edge.ID)) continue;
                e.Graphics.DrawLine(this.MyPen, edge.SourcePoint, edge.TargetPoint);
            }
        }

        bool NullCheck()
        {
            return (this.MyOSM.MyNetwork == null) ? true : false;
        }

        void ResetView()
        {
            this.ViewOriginX = 0;
            this.ViewOriginY = 0;
            this.ViewScale = 1;
            this.Invoke(new Action(this.UpdatePictureBox));
        }

        public void ClearSelectAgent()
        {
            this.SelectedAgentList.Clear();
            this.SelectedEdgeList.Clear();
            this.NeighborAgentList.Clear();
        }
        #endregion

        #region event

        private void pictureboxAnimation_MouseWheel(object sender, MouseEventArgs e)
        {
            float prev_scale = this.ViewScale;
            float allow_zoom_size = (float)0.5;

            if (this.ViewScale >= allow_zoom_size)
            {
                this.ViewScale += e.Delta * 0.001f * this.ViewScale;
                if (this.ViewScale < allow_zoom_size)
                {
                    this.ViewScale = allow_zoom_size;
                }
            }

            this.ViewOriginX -= (e.X / this.ViewScale) * (this.ViewScale - prev_scale) / this.ViewScale;
            this.ViewOriginY -= (e.Y / this.ViewScale) * (this.ViewScale - prev_scale) / this.ViewScale;


            if (prev_scale != this.ViewScale)
            {
                this.Invoke(new Action(this.UpdatePictureBox));
            }
        }

        #endregion

        private void pictureBoxAnimation_Paint(object sender, PaintEventArgs e)
        {
            if (this.MyOSM == null || this.MyOSM.MyNetwork == null) { return; }
            if (this.MyOSM.MyNetwork.MyLayout == null) this.UpdateLayout();

            var base_matrix = this.GetBaseMatrix(this.MyOSM.MyNetwork, this.MyOSM.MyAgentSet);
            e.Graphics.Transform = base_matrix;
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            //edge
            this.UpdateEdge(e);
            e.Graphics.Transform = base_matrix;

            //agent
            this.UpdateAgent(e, base_matrix);
            e.Graphics.Transform = base_matrix;

            //select neighbor
            this.UpdateNeighborAgent(e, base_matrix);
            e.Graphics.Transform = base_matrix;

            //select agent
            this.UpdateSelectAgent(e, base_matrix);
            e.Graphics.Transform = base_matrix;

            //select edge
            this.UpdateSelectEdge(e);
            e.Graphics.Transform = base_matrix;

        }

        private void pictureBoxAnimation_DoubleClick(object sender, EventArgs e)
        {
            if (this.NullCheck()) return;
            this.ResetView();
        }

        private void pictureBoxAnimation_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.NullCheck()) return;

            Matrix baseMatrix = this.GetBaseMatrix(this.MyOSM.MyNetwork, this.MyOSM.MyAgentSet);
            //縮尺を変更
            Matrix agentMatrix = new Matrix();
            float modifyScale = 1 / this.ViewScale;
            agentMatrix.Scale(modifyScale, modifyScale);
            //移動の変更
            float modifyX = -1 * this.ViewX * (1 / modifyScale);
            float modifyY = -1 * this.ViewY * (1 / modifyScale);

            agentMatrix.Translate(modifyX, modifyY);

            Point p = this.pictureBoxAnimation.PointToClient(Control.MousePosition);
            Point[] pArray = {
        p
      };
            agentMatrix.TransformPoints(pArray);


            //agent select
            if ((e as MouseEventArgs).Button == MouseButtons.Left)
            {
                foreach (var agent in this.AgentViewList)
                {
                    if (agent.IsInclude(pArray[0].X, pArray[0].Y))
                    {
                        if (this.SelectedAgentList.Contains(agent.ID))
                        {
                            this.SelectedAgentList.Remove(agent.ID);
                        }
                        else
                        {
                            this.SelectedAgentList.Add(agent.ID);
                        }
                    }
                }
            }

            //edge
            this.SelectedEdgeList.Clear();
            foreach (var edge in this.EdgeViewList)
            {
                foreach (var agent_id in this.SelectedAgentList)
                {
                    if (edge.IsNeighbor(agent_id))
                    {
                        this.SelectedEdgeList.Add(edge.ID);
                    }
                }
            }

            this.NeighborAgentList.Clear();
            foreach (var node in this.MyOSM.MyNetwork.NodeList)
            {
                if (this.SelectedAgentList.Contains(node.NodeID))
                {
                    this.NeighborAgentList.AddRange(node.NeighborNodeIDList);
                }
            }

            //clear
            if ((e as MouseEventArgs).Button == MouseButtons.Right)
            {
                this.ClearSelectAgent();
                //this.SelectedAgentList.Clear();
                //this.SelectedEdgeList.Clear();
                //this.NeighborAgentList.Clear();
            }

            this.SelectedAgentList = this.SelectedAgentList.Distinct().ToList();
            this.SelectedEdgeList = this.SelectedEdgeList.Distinct().ToList();

            this.Invoke(new Action(this.UpdatePictureBox));

        }

        private void pictureBoxAnimation_SizeChanged(object sender, EventArgs e)
        {
            if (this.NullCheck()) return;
            this.Invoke(new Action(this.UpdatePictureBox));
        }

        private void pictureBoxAnimation_MouseDown(object sender, MouseEventArgs e)
        {
            if (this.NullCheck()) return;

            this.DraggingOldX = e.X;
            this.DraggingOldY = e.Y;

            switch (e.Button)
            {
                case MouseButtons.Middle:
                    this.isDragging = true;
                    this.Cursor = Cursors.SizeAll;
                    break;
            }
        }

        private void pictureBoxAnimation_MouseMove(object sender, MouseEventArgs e)
        {
            if (this.NullCheck()) return;

            if (this.isDragging == true)
            {
                this.ViewOriginX += (e.X - this.DraggingOldX) / this.ViewScale;
                this.ViewOriginY += (e.Y - this.DraggingOldY) / this.ViewScale;

                this.DraggingOldX = e.X;
                this.DraggingOldY = e.Y;
            }
            else
            {
                return;
            }
            this.Invoke(new Action(this.UpdatePictureBox));
        }

        private void pictureBoxAnimation_MouseUp(object sender, MouseEventArgs e)
        {
            if (this.NullCheck()) return;

            switch (e.Button)
            {
                case MouseButtons.Middle:
                    this.isDragging = false;
                    this.Cursor = Cursors.Default;
                    this.Invoke(new Action(this.UpdatePictureBox));
                    break;
            }
        }

        private void trackBarRadius_Scroll(object sender, EventArgs e)
        {
            this.NodeSizeScale = this.trackBarRadius.Value;
            this.Invoke(new Action(this.UpdatePictureBox));
        }

        private void buttonUpdateLayout_Click(object sender, EventArgs e)
        {
            this.UpdateLayout();
            this.ResetView();
        }
    }
}
