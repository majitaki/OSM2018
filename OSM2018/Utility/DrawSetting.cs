using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSM2018.Utility
{
    class DrawSetting
    {
        //色
        public float Hue;
        public float Voffset;

        public Color OpCorrectColor;
        public Color OpIncorrectColor;
        public Color OpUndeterColor;
        public Color OrangeColor;
        public Color GreenColor;
        public Color PriorColor;

        //ペン
        public Pen BlackPen;
        public Pen BlackThinPen;
        public Pen GrayPen;
        public Pen PriorBeliefPen;
        public Pen LinkPen;
        public Pen SelectedLinkPen;
        public Pen SelectedPen;
        public Pen SensorPen;
        public Pen SensorNetworkPen;
        public Pen RedPen;
        public Pen MeterPen;

        //ブラシ
        public SolidBrush RedBrush;
        public SolidBrush GrayBrush;
        public SolidBrush LightGrayBrush;
        public SolidBrush BeliefBrush;
        public SolidBrush OpinionBrush;

        public DrawSetting()
        {
            this.Hue = 200;
            this.Voffset = 0.3f;
            //this.OpCorrectColor = StaticColor.ConvertHSBtoARGB(this.Hue, 1f - 1f, 1f);
            //this.OpIncorrectColor = StaticColor.ConvertHSBtoARGB(this.Hue, 1f - 0f, this.Voffset);
            //this.OpUndeterColor = StaticColor.ConvertHSBtoARGB(this.Hue, 1f - 0.5f, (1f - this.Voffset) * 0.5f + this.Voffset);
            this.OpCorrectColor = Color.LightGreen;
            this.OpIncorrectColor = Color.PaleVioletRed;
            this.OpUndeterColor = Color.Silver;
            this.OrangeColor = StaticColor.ConvertHSBtoARGB(40F, 0.9F, 0.9F);
            //this.GreenColor = StaticColor.ConvertHSBtoARGB(91F, 0.62F, 0.80F);
            this.GreenColor = Color.GreenYellow;
            this.PriorColor = StaticColor.ConvertHSBtoARGB(this.Hue, 0.5f, 0f);
            this.BlackPen = new Pen(Color.Black);
            this.BlackThinPen = new Pen(Color.Black);
            this.BlackThinPen.Width = (float)0.5;
            this.GrayPen = new Pen(Color.Gray);
            this.GrayPen.Width = 2;
            this.GrayPen.StartCap = this.GrayPen.EndCap = LineCap.Round;
            this.PriorBeliefPen = new Pen(PriorColor);
            this.PriorBeliefPen.StartCap = this.PriorBeliefPen.EndCap = LineCap.Round;
            this.PriorBeliefPen.Width = 0.5f;
            this.LinkPen = new Pen(GreenColor);
            this.LinkPen.Width = 1.5f;
            this.SelectedLinkPen = new Pen(new SolidBrush(Color.Red));
            this.SelectedLinkPen.Width = 3f;
            this.SelectedPen = new Pen(Color.DarkRed);
            this.SelectedPen.Width = 3f;
            this.SensorPen = new Pen(Color.Gold);
            //this.SensorPen = new Pen(Color.MediumBlue);
            this.SensorPen.Width = 5f;
            this.SensorNetworkPen = new Pen(OrangeColor);
            this.SensorNetworkPen.Width = 10;
            this.RedPen = new Pen(Color.Red);
            this.RedPen.Width = 3f;
            this.MeterPen = new Pen(StaticColor.ConvertHSBtoARGB(this.Hue, 1f - 0f, this.Voffset));
            this.MeterPen.Width = 4; //2
            this.MeterPen.StartCap = this.MeterPen.EndCap = LineCap.Round;
            this.RedBrush = new SolidBrush(Color.Red);
            this.GrayBrush = new SolidBrush(Color.Gray);
            this.LightGrayBrush = new SolidBrush(Color.LightGray);
            this.BeliefBrush = new SolidBrush(StaticColor.ConvertHSBtoARGB(100F, 0.9F, 0.8F));
            this.OpinionBrush = new SolidBrush(StaticColor.ConvertHSBtoARGB(0F, 0F, 1F));

        }
    }
}
