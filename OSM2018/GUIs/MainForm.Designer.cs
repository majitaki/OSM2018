namespace OSM2018
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
            this.components = new System.ComponentModel.Container();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxMenu = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.radioButtonStepCheck = new System.Windows.Forms.RadioButton();
            this.radioButtonRoundCheck = new System.Windows.Forms.RadioButton();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonPlayStop = new System.Windows.Forms.RadioButton();
            this.radioButtonSeedPlus = new System.Windows.Forms.RadioButton();
            this.radioButtonPlay = new System.Windows.Forms.RadioButton();
            this.radioButtonPlayStep = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownSpeedControl = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.numericUpDownControlSeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownStepsControl = new System.Windows.Forms.NumericUpDown();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelRoundNum = new System.Windows.Forms.Label();
            this.labelStepNum = new System.Windows.Forms.Label();
            this.buttonGraphShow = new System.Windows.Forms.Button();
            this.labelStep = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.radioButtonNetworkGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonAgentGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonLearningGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonNullSetting = new System.Windows.Forms.RadioButton();
            this.radioButtonAnimationGUI = new System.Windows.Forms.RadioButton();
            this.radioButtonExperimentGUI = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButtonLogSetting = new System.Windows.Forms.RadioButton();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.flowLayoutPanel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControlSeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepsControl)).BeginInit();
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
            this.flowLayoutPanel2.Size = new System.Drawing.Size(695, 116);
            this.flowLayoutPanel2.TabIndex = 7;
            this.flowLayoutPanel2.WrapContents = false;
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
            this.checkBoxMenu.CheckedChanged += new System.EventHandler(this.checkBoxMenu_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.radioButtonStepCheck);
            this.panel3.Controls.Add(this.radioButtonRoundCheck);
            this.panel3.Controls.Add(this.flowLayoutPanel4);
            this.panel3.Location = new System.Drawing.Point(51, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(256, 112);
            this.panel3.TabIndex = 7;
            // 
            // radioButtonStepCheck
            // 
            this.radioButtonStepCheck.AutoSize = true;
            this.radioButtonStepCheck.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButtonStepCheck.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonStepCheck.Location = new System.Drawing.Point(6, 87);
            this.radioButtonStepCheck.Name = "radioButtonStepCheck";
            this.radioButtonStepCheck.Size = new System.Drawing.Size(54, 22);
            this.radioButtonStepCheck.TabIndex = 30;
            this.radioButtonStepCheck.TabStop = true;
            this.radioButtonStepCheck.Text = "Step";
            this.radioButtonStepCheck.UseVisualStyleBackColor = true;
            // 
            // radioButtonRoundCheck
            // 
            this.radioButtonRoundCheck.AutoSize = true;
            this.radioButtonRoundCheck.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.radioButtonRoundCheck.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.radioButtonRoundCheck.Location = new System.Drawing.Point(6, 70);
            this.radioButtonRoundCheck.Name = "radioButtonRoundCheck";
            this.radioButtonRoundCheck.Size = new System.Drawing.Size(67, 22);
            this.radioButtonRoundCheck.TabIndex = 28;
            this.radioButtonRoundCheck.TabStop = true;
            this.radioButtonRoundCheck.Text = "Round";
            this.radioButtonRoundCheck.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.radioButtonPlayStop);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonSeedPlus);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonPlay);
            this.flowLayoutPanel4.Controls.Add(this.radioButtonPlayStep);
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 7);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(248, 66);
            this.flowLayoutPanel4.TabIndex = 13;
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
            this.radioButtonPlayStop.Click += new System.EventHandler(this.radioButtonPlayStop_Click);
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
            this.radioButtonSeedPlus.Click += new System.EventHandler(this.radioButtonSeedPlus_Click);
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
            this.radioButtonPlay.Click += new System.EventHandler(this.radioButtonPlay_Click);
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
            this.radioButtonPlayStep.Click += new System.EventHandler(this.radioButtonPlayStep_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.numericUpDownSpeedControl);
            this.panel4.Controls.Add(this.label17);
            this.panel4.Controls.Add(this.numericUpDownControlSeed);
            this.panel4.Controls.Add(this.numericUpDownStepsControl);
            this.panel4.Location = new System.Drawing.Point(313, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(139, 112);
            this.panel4.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label1.Location = new System.Drawing.Point(4, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 24);
            this.label1.TabIndex = 32;
            this.label1.Text = "Speed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label2.Location = new System.Drawing.Point(9, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 24;
            this.label2.Text = "Steps";
            // 
            // numericUpDownSpeedControl
            // 
            this.numericUpDownSpeedControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownSpeedControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSpeedControl.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownSpeedControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownSpeedControl.Location = new System.Drawing.Point(78, 9);
            this.numericUpDownSpeedControl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSpeedControl.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeedControl.Name = "numericUpDownSpeedControl";
            this.numericUpDownSpeedControl.Size = new System.Drawing.Size(58, 25);
            this.numericUpDownSpeedControl.TabIndex = 31;
            this.numericUpDownSpeedControl.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("メイリオ", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label17.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label17.Location = new System.Drawing.Point(15, 80);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(52, 24);
            this.label17.TabIndex = 21;
            this.label17.Text = "Seed";
            // 
            // numericUpDownControlSeed
            // 
            this.numericUpDownControlSeed.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownControlSeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownControlSeed.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownControlSeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownControlSeed.Location = new System.Drawing.Point(78, 79);
            this.numericUpDownControlSeed.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericUpDownControlSeed.Name = "numericUpDownControlSeed";
            this.numericUpDownControlSeed.Size = new System.Drawing.Size(58, 25);
            this.numericUpDownControlSeed.TabIndex = 20;
            // 
            // numericUpDownStepsControl
            // 
            this.numericUpDownStepsControl.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownStepsControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownStepsControl.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.numericUpDownStepsControl.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownStepsControl.Location = new System.Drawing.Point(78, 44);
            this.numericUpDownStepsControl.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownStepsControl.Name = "numericUpDownStepsControl";
            this.numericUpDownStepsControl.Size = new System.Drawing.Size(58, 25);
            this.numericUpDownStepsControl.TabIndex = 23;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.labelRoundNum);
            this.panel2.Controls.Add(this.labelStepNum);
            this.panel2.Controls.Add(this.buttonGraphShow);
            this.panel2.Controls.Add(this.labelStep);
            this.panel2.Controls.Add(this.labelRound);
            this.panel2.Location = new System.Drawing.Point(458, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(232, 112);
            this.panel2.TabIndex = 0;
            // 
            // labelRoundNum
            // 
            this.labelRoundNum.AutoSize = true;
            this.labelRoundNum.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRoundNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelRoundNum.Location = new System.Drawing.Point(129, 35);
            this.labelRoundNum.Name = "labelRoundNum";
            this.labelRoundNum.Size = new System.Drawing.Size(36, 41);
            this.labelRoundNum.TabIndex = 3;
            this.labelRoundNum.Text = "1";
            // 
            // labelStepNum
            // 
            this.labelStepNum.AutoSize = true;
            this.labelStepNum.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStepNum.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStepNum.Location = new System.Drawing.Point(129, 68);
            this.labelStepNum.Name = "labelStepNum";
            this.labelStepNum.Size = new System.Drawing.Size(36, 41);
            this.labelStepNum.TabIndex = 2;
            this.labelStepNum.Text = "0";
            // 
            // buttonGraphShow
            // 
            this.buttonGraphShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGraphShow.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonGraphShow.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonGraphShow.Location = new System.Drawing.Point(10, 7);
            this.buttonGraphShow.Name = "buttonGraphShow";
            this.buttonGraphShow.Size = new System.Drawing.Size(101, 27);
            this.buttonGraphShow.TabIndex = 22;
            this.buttonGraphShow.Text = "Graph Show";
            this.buttonGraphShow.UseVisualStyleBackColor = false;
            this.buttonGraphShow.Click += new System.EventHandler(this.buttonGraphShow_Click);
            // 
            // labelStep
            // 
            this.labelStep.AutoSize = true;
            this.labelStep.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelStep.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelStep.Location = new System.Drawing.Point(3, 68);
            this.labelStep.Name = "labelStep";
            this.labelStep.Size = new System.Drawing.Size(93, 41);
            this.labelStep.TabIndex = 1;
            this.labelStep.Text = "Step:";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.Font = new System.Drawing.Font("メイリオ", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelRound.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.labelRound.Location = new System.Drawing.Point(3, 33);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(120, 41);
            this.labelRound.TabIndex = 0;
            this.labelRound.Text = "Round:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNetworkGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonAgentGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonLearningGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonNullSetting);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonExperimentGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonAnimationGUI);
            this.flowLayoutPanel1.Controls.Add(this.radioButton3);
            this.flowLayoutPanel1.Controls.Add(this.radioButtonLogSetting);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 116);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(61, 551);
            this.flowLayoutPanel1.TabIndex = 8;
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
            this.radioButtonAnimationGUI.Location = new System.Drawing.Point(3, 273);
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
            this.radioButtonExperimentGUI.Location = new System.Drawing.Point(3, 219);
            this.radioButtonExperimentGUI.Name = "radioButtonExperimentGUI";
            this.radioButtonExperimentGUI.Size = new System.Drawing.Size(48, 48);
            this.radioButtonExperimentGUI.TabIndex = 7;
            this.radioButtonExperimentGUI.TabStop = true;
            this.radioButtonExperimentGUI.UseVisualStyleBackColor = false;
            this.radioButtonExperimentGUI.CheckedChanged += new System.EventHandler(this.radioButtonSetting_CheckedChanged);
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
            // timerAnimation
            // 
            this.timerAnimation.Interval = 1;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(695, 667);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeedControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownControlSeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownStepsControl)).EndInit();
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
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonGraphShow;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.NumericUpDown numericUpDownControlSeed;
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
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Label labelRoundNum;
        private System.Windows.Forms.Label labelStepNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownSpeedControl;
        private System.Windows.Forms.RadioButton radioButtonStepCheck;
        private System.Windows.Forms.RadioButton radioButtonRoundCheck;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownStepsControl;
    }
}

