﻿namespace OSM2018
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonGraphShow = new System.Windows.Forms.Button();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownAnimationSeed = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelStep = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonNullSetting = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLogSetting = new System.Windows.Forms.RadioButton();
            this.radioButtonNetworkGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonAgentGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonLearningGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimationGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonExperimentGUI = new System.Windows.Forms.RadioButton();
            this.checkBoxMenu = new System.Windows.Forms.CheckBox();
            this.radioButtonPlayStop = new System.Windows.Forms.RadioButton();
            this.radioButtonSeedPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonPlay = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayStep = new System.Windows.Forms.RadioButton();
            this.radioButtonMultiplePlay = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationSeed)).BeginInit();
            this.panel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel2.Controls.Add(this.checkBoxMenu);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.Controls.Add(this.panel4);
            this.flowLayoutPanel2.Controls.Add(this.panel2);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(729, 116);
            this.flowLayoutPanel2.TabIndex = 7;
            this.flowLayoutPanel2.WrapContents = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Location = new System.Drawing.Point(51, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(308, 112);
            this.panel3.TabIndex = 7;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.radioButtonPlayStop);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonSeedPlus);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonPlay);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonPlayStep);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonMultiplePlay);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(302, 66);
            this.flowLayoutPanel4.TabIndex = 13;
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(3, 79);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(302, 45);
            this.trackBar1.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonGraphShow);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.numericUpDownAnimationSeed);
            this.panel4.Location = new System.Drawing.Point(365, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 112);
            this.panel4.TabIndex = 9;
            // 
            // buttonGraphShow
            // 
            this.buttonGraphShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphShow.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGraphShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGraphShow.Location = new System.Drawing.Point(17, 7);
            this.buttonGraphShow.Name = "buttonGraphShow";
            this.buttonGraphShow.Size = new System.Drawing.Size(101, 27);
            this.buttonGraphShow.TabIndex = 22;
            this.buttonGraphShow.Text = "Graph Show";
            this.buttonGraphShow.UseVisualStyleBackColor = false;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(3, 75);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 24);
            this.label17.TabIndex = 21;
            this.label17.Text = "Seed";
            // 
            // numericUpDownAnimationSeed
            // 
            this.numericUpDownAnimationSeed.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownAnimationSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAnimationSeed.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownAnimationSeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownAnimationSeed.Location = new System.Drawing.Point(62, 74);
            this.numericUpDownAnimationSeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownAnimationSeed.Name = "numericUpDownAnimationSeed";
            this.numericUpDownAnimationSeed.Size = new System.Drawing.Size(70, 25);
            this.numericUpDownAnimationSeed.TabIndex = 20;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelStep);
            this.panel2.Controls.Add(this.labelRound);
            this.panel2.Location = new System.Drawing.Point(510, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(215, 112);
            this.panel2.TabIndex = 0;
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStep.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStep.Location = new System.Drawing.Point(30, 60);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(120, 41);
            this.labelStep.TabIndex = 1;
            this.labelStep.Text = "Step: 0";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRound.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelRound.Location = new System.Drawing.Point(3, 12);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(147, 41);
            this.labelRound.TabIndex = 0;
            this.labelRound.Text = "Round: 0";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNetworkGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonAgentGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonLearningGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNullSetting);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonAnimationGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonExperimentGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonLogSetting);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(61, 551);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // radioButtonNullSetting
            // 
            this.radioButtonNullSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonNullSetting.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNullSetting.Enabled = false;
            this.radioButtonNullSetting.FlatAppearance.BorderSize = 0;
            this.radioButtonNullSetting.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonNullSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonNullSetting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonNullSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonNullSetting.Location = new System.Drawing.Point(3, 165);
            this.radioButtonNullSetting.Name = "radioButtonNullSetting";
            this.radioButtonNullSetting.Size = new System.Drawing.Size(48, 48);
            this.radioButtonNullSetting.TabIndex = 5;
            this.radioButtonNullSetting.TabStop = true;
            this.radioButtonNullSetting.UseVisualStyleBackColor = false;
            // 
            // radioButton3
            // 
            this.radioButton3.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButton3.BackColor = System.Drawing.Color.Transparent;
            this.radioButton3.Enabled = false;
            this.radioButton3.FlatAppearance.BorderSize = 0;
            this.radioButton3.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButton3.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButton3.Location = new System.Drawing.Point(3, 327);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(48, 48);
            this.radioButton3.TabIndex = 10;
            this.radioButton3.TabStop = true;
            this.radioButton3.UseVisualStyleBackColor = false;
            // 
            // radioButtonLogSetting
            // 
            this.radioButtonLogSetting.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLogSetting.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLogSetting.FlatAppearance.BorderSize = 0;
            this.radioButtonLogSetting.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonLogSetting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonLogSetting.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonLogSetting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonLogSetting.Location = new System.Drawing.Point(3, 381);
            this.radioButtonLogSetting.Name = "radioButtonLogSetting";
            this.radioButtonLogSetting.Size = new System.Drawing.Size(48, 48);
            this.radioButtonLogSetting.TabIndex = 9;
            this.radioButtonLogSetting.TabStop = true;
            this.radioButtonLogSetting.UseVisualStyleBackColor = false;
            // 
            // radioButtonNetworkGUI
            // 
            this.radioButtonNetworkGUI.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonNetworkGUI.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonNetworkGUI.BackgroundImage = global::OSM2018.Properties.Resources.icon_graph;
            this.radioButtonNetworkGUI.FlatAppearance.BorderSize = 0;
            this.radioButtonNetworkGUI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonNetworkGUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonNetworkGUI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonNetworkGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonNetworkGUI.Location = new System.Drawing.Point(3, 3);
            this.radioButtonNetworkGUI.Name = "radioButtonNetworkGUI";
            this.radioButtonNetworkGUI.Size = new System.Drawing.Size(48, 48);
            this.radioButtonNetworkGUI.TabIndex = 2;
            this.radioButtonNetworkGUI.TabStop = true;
            this.radioButtonNetworkGUI.UseVisualStyleBackColor = false;
            this.radioButtonNetworkGUI.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
            // 
            // radioButtonAgentGUI
            // 
            this.radioButtonAgentGUI.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAgentGUI.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAgentGUI.BackgroundImage = global::OSM2018.Properties.Resources.icon_agent;
            this.radioButtonAgentGUI.FlatAppearance.BorderSize = 0;
            this.radioButtonAgentGUI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAgentGUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonAgentGUI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAgentGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAgentGUI.Location = new System.Drawing.Point(3, 57);
            this.radioButtonAgentGUI.Name = "radioButtonAgentGUI";
            this.radioButtonAgentGUI.Size = new System.Drawing.Size(48, 48);
            this.radioButtonAgentGUI.TabIndex = 3;
            this.radioButtonAgentGUI.TabStop = true;
            this.radioButtonAgentGUI.UseVisualStyleBackColor = false;
            this.radioButtonAgentGUI.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
            // 
            // radioButtonLearningGUI
            // 
            this.radioButtonLearningGUI.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonLearningGUI.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonLearningGUI.BackgroundImage = global::OSM2018.Properties.Resources.icon_learning;
            this.radioButtonLearningGUI.FlatAppearance.BorderSize = 0;
            this.radioButtonLearningGUI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonLearningGUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonLearningGUI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonLearningGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonLearningGUI.Location = new System.Drawing.Point(3, 111);
            this.radioButtonLearningGUI.Name = "radioButtonLearningGUI";
            this.radioButtonLearningGUI.Size = new System.Drawing.Size(48, 48);
            this.radioButtonLearningGUI.TabIndex = 4;
            this.radioButtonLearningGUI.TabStop = true;
            this.radioButtonLearningGUI.UseVisualStyleBackColor = false;
            this.radioButtonLearningGUI.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
            // 
            // radioButtonAnimationGUI
            // 
            this.radioButtonAnimationGUI.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonAnimationGUI.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonAnimationGUI.BackgroundImage = global::OSM2018.Properties.Resources.icon_animation;
            this.radioButtonAnimationGUI.FlatAppearance.BorderSize = 0;
            this.radioButtonAnimationGUI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAnimationGUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonAnimationGUI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonAnimationGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonAnimationGUI.Location = new System.Drawing.Point(3, 219);
            this.radioButtonAnimationGUI.Name = "radioButtonAnimationGUI";
            this.radioButtonAnimationGUI.Size = new System.Drawing.Size(48, 48);
            this.radioButtonAnimationGUI.TabIndex = 6;
            this.radioButtonAnimationGUI.TabStop = true;
            this.radioButtonAnimationGUI.UseVisualStyleBackColor = false;
            this.radioButtonAnimationGUI.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
            // 
            // radioButtonExperimentGUI
            // 
            this.radioButtonExperimentGUI.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonExperimentGUI.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonExperimentGUI.BackgroundImage = global::OSM2018.Properties.Resources.icon_experiment;
            this.radioButtonExperimentGUI.FlatAppearance.BorderSize = 0;
            this.radioButtonExperimentGUI.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonExperimentGUI.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.radioButtonExperimentGUI.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonExperimentGUI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonExperimentGUI.Location = new System.Drawing.Point(3, 273);
            this.radioButtonExperimentGUI.Name = "radioButtonExperimentGUI";
            this.radioButtonExperimentGUI.Size = new System.Drawing.Size(48, 48);
            this.radioButtonExperimentGUI.TabIndex = 7;
            this.radioButtonExperimentGUI.TabStop = true;
            this.radioButtonExperimentGUI.UseVisualStyleBackColor = false;
            this.radioButtonExperimentGUI.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
            // 
            // checkBoxMenu
            // 
            this.checkBoxMenu.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxMenu.FlatAppearance.BorderSize = 0;
            this.checkBoxMenu.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxMenu.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxMenu.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.checkBoxMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxMenu.Image = global::OSM2018.Properties.Resources.icon_menu;
            this.checkBoxMenu.Location = new System.Drawing.Point(3, 3);
            this.checkBoxMenu.Name = "checkBoxMenu";
            this.checkBoxMenu.Size = new System.Drawing.Size(42, 110);
            this.checkBoxMenu.TabIndex = 8;
            this.checkBoxMenu.UseVisualStyleBackColor = true;
            // 
            // radioButtonPlayStop
            // 
            this.radioButtonPlayStop.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPlayStop.AutoSize = true;
            this.radioButtonPlayStop.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPlayStop.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlayStop.FlatAppearance.BorderSize = 0;
            this.radioButtonPlayStop.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlayStop.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonPlayStop.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlayStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPlayStop.Image = global::OSM2018.Properties.Resources.icon_stop;
            this.radioButtonPlayStop.Location = new System.Drawing.Point(3, 3);
            this.radioButtonPlayStop.Name = "radioButtonPlayStop";
            this.radioButtonPlayStop.Size = new System.Drawing.Size(54, 54);
            this.radioButtonPlayStop.TabIndex = 10;
            this.radioButtonPlayStop.TabStop = true;
            this.radioButtonPlayStop.UseVisualStyleBackColor = false;
            // 
            // radioButtonSeedPlus
            // 
            this.radioButtonSeedPlus.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonSeedPlus.AutoSize = true;
            this.radioButtonSeedPlus.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonSeedPlus.FlatAppearance.BorderSize = 0;
            this.radioButtonSeedPlus.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonSeedPlus.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonSeedPlus.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonSeedPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonSeedPlus.Image = global::OSM2018.Properties.Resources.icon_seedplus;
            this.radioButtonSeedPlus.Location = new System.Drawing.Point(63, 3);
            this.radioButtonSeedPlus.Name = "radioButtonSeedPlus";
            this.radioButtonSeedPlus.Size = new System.Drawing.Size(54, 54);
            this.radioButtonSeedPlus.TabIndex = 11;
            this.radioButtonSeedPlus.TabStop = true;
            this.radioButtonSeedPlus.UseVisualStyleBackColor = false;
            // 
            // radioButtonPlay
            // 
            this.radioButtonPlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPlay.AutoSize = true;
            this.radioButtonPlay.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPlay.FlatAppearance.BorderSize = 0;
            this.radioButtonPlay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonPlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPlay.Image = global::OSM2018.Properties.Resources.icon_play;
            this.radioButtonPlay.Location = new System.Drawing.Point(123, 3);
            this.radioButtonPlay.Name = "radioButtonPlay";
            this.radioButtonPlay.Size = new System.Drawing.Size(54, 54);
            this.radioButtonPlay.TabIndex = 8;
            this.radioButtonPlay.TabStop = true;
            this.radioButtonPlay.UseVisualStyleBackColor = false;
            // 
            // radioButtonPlayStep
            // 
            this.radioButtonPlayStep.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonPlayStep.AutoSize = true;
            this.radioButtonPlayStep.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonPlayStep.FlatAppearance.BorderSize = 0;
            this.radioButtonPlayStep.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlayStep.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonPlayStep.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonPlayStep.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonPlayStep.Image = global::OSM2018.Properties.Resources.icon_playstep;
            this.radioButtonPlayStep.Location = new System.Drawing.Point(183, 3);
            this.radioButtonPlayStep.Name = "radioButtonPlayStep";
            this.radioButtonPlayStep.Size = new System.Drawing.Size(54, 54);
            this.radioButtonPlayStep.TabIndex = 7;
            this.radioButtonPlayStep.TabStop = true;
            this.radioButtonPlayStep.UseVisualStyleBackColor = false;
            // 
            // radioButtonMultiplePlay
            // 
            this.radioButtonMultiplePlay.Appearance = System.Windows.Forms.Appearance.Button;
            this.radioButtonMultiplePlay.AutoSize = true;
            this.radioButtonMultiplePlay.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonMultiplePlay.FlatAppearance.BorderSize = 0;
            this.radioButtonMultiplePlay.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonMultiplePlay.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.radioButtonMultiplePlay.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDark;
            this.radioButtonMultiplePlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radioButtonMultiplePlay.Image = global::OSM2018.Properties.Resources.icon_fastforward;
            this.radioButtonMultiplePlay.Location = new System.Drawing.Point(243, 3);
            this.radioButtonMultiplePlay.Name = "radioButtonMultiplePlay";
            this.radioButtonMultiplePlay.Size = new System.Drawing.Size(54, 54);
            this.radioButtonMultiplePlay.TabIndex = 9;
            this.radioButtonMultiplePlay.TabStop = true;
            this.radioButtonMultiplePlay.UseVisualStyleBackColor = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(729, 667);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAnimationSeed)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.CheckBox checkBoxMenu;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.RadioButton radioButtonPlayStop;
        private System.Windows.Forms.RadioButton radioButtonSeedPlus;
        private System.Windows.Forms.RadioButton radioButtonPlay;
        private System.Windows.Forms.RadioButton radioButtonPlayStep;
        private System.Windows.Forms.RadioButton radioButtonMultiplePlay;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGraphShow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownAnimationSeed;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelStep;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.RadioButton radioButtonNetworkGUI;
        private System.Windows.Forms.RadioButton radioButtonAgentGUI;
        private System.Windows.Forms.RadioButton radioButtonLearningGUI;
        private System.Windows.Forms.RadioButton radioButtonNullSetting;
        private System.Windows.Forms.RadioButton radioButtonAnimationGUI;
        private System.Windows.Forms.RadioButton radioButtonExperimentGUI;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButtonLogSetting;
    }
}
