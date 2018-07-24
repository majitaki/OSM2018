namespace OSM2018.GUIs
{
    partial class AgentGUI
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

        #region コンポーネント デザイナーで生成されたコード

        /// <summary> 
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を 
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelAgentNetworkGeneProgress = new System.Windows.Forms.Label();
            this.comboBoxInitOpinion = new System.Windows.Forms.ComboBox();
            this.numericUpDownAgentSeed = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerateAgentNetwork = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBoxAgent = new System.Windows.Forms.GroupBox();
            this.checkBoxAATSensorRateEnabled = new System.Windows.Forms.CheckBox();
            this.numericUpDownAATSensorRate = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSensorAccuracy = new System.Windows.Forms.NumericUpDown();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownAATObaserverSelect = new System.Windows.Forms.NumericUpDown();
            this.labelAATObserverSelect = new System.Windows.Forms.Label();
            this.numericUpDownAATSigma = new System.Windows.Forms.NumericUpDown();
            this.labelAATSigma = new System.Windows.Forms.Label();
            this.labelAATSensorNum = new System.Windows.Forms.Label();
            this.numericUpDownAATSensorNum = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAAT = new System.Windows.Forms.ComboBox();
            this.comboBoxOtherAlgo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxGA = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.numericUpDown4 = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgentSeed)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBoxAgent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATSensorRate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSensorAccuracy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATObaserverSelect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATSigma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATSensorNum)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.groupBoxAgent);
            this.flowLayoutPanel1.Controls.Add(this.groupBox3);
            this.flowLayoutPanel1.Controls.Add(this.groupBox2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(531, 666);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelAgentNetworkGeneProgress);
            this.groupBox1.Controls.Add(this.comboBoxInitOpinion);
            this.groupBox1.Controls.Add(this.numericUpDownAgentSeed);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.buttonGenerateAgentNetwork);
            this.groupBox1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 116);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agent Generation";
            // 
            // labelAgentNetworkGeneProgress
            // 
            this.labelAgentNetworkGeneProgress.AutoSize = true;
            this.labelAgentNetworkGeneProgress.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAgentNetworkGeneProgress.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelAgentNetworkGeneProgress.Location = new System.Drawing.Point(111, 32);
            this.labelAgentNetworkGeneProgress.Name = "labelAgentNetworkGeneProgress";
            this.labelAgentNetworkGeneProgress.Size = new System.Drawing.Size(81, 19);
            this.labelAgentNetworkGeneProgress.TabIndex = 16;
            this.labelAgentNetworkGeneProgress.Text = "Can Work";
            // 
            // comboBoxInitOpinion
            // 
            this.comboBoxInitOpinion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxInitOpinion.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxInitOpinion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxInitOpinion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxInitOpinion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxInitOpinion.FormattingEnabled = true;
            this.comboBoxInitOpinion.Items.AddRange(new object[] {
            "Undeter",
            "Correct",
            "Incorrect"});
            this.comboBoxInitOpinion.Location = new System.Drawing.Point(149, 57);
            this.comboBoxInitOpinion.Name = "comboBoxInitOpinion";
            this.comboBoxInitOpinion.Size = new System.Drawing.Size(107, 27);
            this.comboBoxInitOpinion.TabIndex = 15;
            // 
            // numericUpDownAgentSeed
            // 
            this.numericUpDownAgentSeed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownAgentSeed.BackColor = System.Drawing.SystemColors.ControlDark;
            this.numericUpDownAgentSeed.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.numericUpDownAgentSeed.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownAgentSeed.Location = new System.Drawing.Point(187, 87);
            this.numericUpDownAgentSeed.Name = "numericUpDownAgentSeed";
            this.numericUpDownAgentSeed.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownAgentSeed.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(126, 19);
            this.label2.TabIndex = 5;
            this.label2.Text = "Init Opinion:";
            // 
            // buttonGenerateAgentNetwork
            // 
            this.buttonGenerateAgentNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGenerateAgentNetwork.Location = new System.Drawing.Point(6, 25);
            this.buttonGenerateAgentNetwork.Name = "buttonGenerateAgentNetwork";
            this.buttonGenerateAgentNetwork.Size = new System.Drawing.Size(99, 32);
            this.buttonGenerateAgentNetwork.TabIndex = 0;
            this.buttonGenerateAgentNetwork.Text = "Generate";
            this.buttonGenerateAgentNetwork.UseVisualStyleBackColor = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButton3);
            this.groupBox3.Controls.Add(this.radioButton2);
            this.groupBox3.Controls.Add(this.radioButton1);
            this.groupBox3.Controls.Add(this.comboBoxGA);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.comboBoxOtherAlgo);
            this.groupBox3.Controls.Add(this.comboBoxAAT);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Location = new System.Drawing.Point(3, 312);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(375, 149);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Algo List";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 19);
            this.label3.TabIndex = 36;
            this.label3.Text = "Other";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(27, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(36, 19);
            this.label11.TabIndex = 3;
            this.label11.Text = "AAT";
            // 
            // groupBoxAgent
            // 
            this.groupBoxAgent.AutoSize = true;
            this.groupBoxAgent.BackColor = System.Drawing.Color.Transparent;
            this.groupBoxAgent.Controls.Add(this.checkBoxAATSensorRateEnabled);
            this.groupBoxAgent.Controls.Add(this.numericUpDownAATSensorRate);
            this.groupBoxAgent.Controls.Add(this.numericUpDownSensorAccuracy);
            this.groupBoxAgent.Controls.Add(this.label15);
            this.groupBoxAgent.Controls.Add(this.numericUpDownAATObaserverSelect);
            this.groupBoxAgent.Controls.Add(this.labelAATObserverSelect);
            this.groupBoxAgent.Controls.Add(this.numericUpDownAATSigma);
            this.groupBoxAgent.Controls.Add(this.labelAATSigma);
            this.groupBoxAgent.Controls.Add(this.labelAATSensorNum);
            this.groupBoxAgent.Controls.Add(this.numericUpDownAATSensorNum);
            this.groupBoxAgent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAgent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBoxAgent.Location = new System.Drawing.Point(3, 125);
            this.groupBoxAgent.Name = "groupBoxAgent";
            this.groupBoxAgent.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBoxAgent.Size = new System.Drawing.Size(427, 181);
            this.groupBoxAgent.TabIndex = 18;
            this.groupBoxAgent.TabStop = false;
            this.groupBoxAgent.Text = "Agent Property";
            // 
            // checkBoxAATSensorRateEnabled
            // 
            this.checkBoxAATSensorRateEnabled.AutoSize = true;
            this.checkBoxAATSensorRateEnabled.Location = new System.Drawing.Point(291, 31);
            this.checkBoxAATSensorRateEnabled.Name = "checkBoxAATSensorRateEnabled";
            this.checkBoxAATSensorRateEnabled.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAATSensorRateEnabled.TabIndex = 18;
            this.checkBoxAATSensorRateEnabled.UseVisualStyleBackColor = true;
            // 
            // numericUpDownAATSensorRate
            // 
            this.numericUpDownAATSensorRate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownAATSensorRate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAATSensorRate.DecimalPlaces = 2;
            this.numericUpDownAATSensorRate.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownAATSensorRate.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownAATSensorRate.Location = new System.Drawing.Point(312, 23);
            this.numericUpDownAATSensorRate.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAATSensorRate.Name = "numericUpDownAATSensorRate";
            this.numericUpDownAATSensorRate.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownAATSensorRate.TabIndex = 17;
            // 
            // numericUpDownSensorAccuracy
            // 
            this.numericUpDownSensorAccuracy.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownSensorAccuracy.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownSensorAccuracy.DecimalPlaces = 2;
            this.numericUpDownSensorAccuracy.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownSensorAccuracy.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownSensorAccuracy.Location = new System.Drawing.Point(170, 61);
            this.numericUpDownSensorAccuracy.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSensorAccuracy.Name = "numericUpDownSensorAccuracy";
            this.numericUpDownSensorAccuracy.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownSensorAccuracy.TabIndex = 13;
            this.numericUpDownSensorAccuracy.Value = new decimal(new int[] {
            55,
            0,
            0,
            131072});
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(9, 64);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(144, 19);
            this.label15.TabIndex = 12;
            this.label15.Text = "Sensor Accuracy";
            // 
            // numericUpDownAATObaserverSelect
            // 
            this.numericUpDownAATObaserverSelect.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownAATObaserverSelect.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAATObaserverSelect.DecimalPlaces = 2;
            this.numericUpDownAATObaserverSelect.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownAATObaserverSelect.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownAATObaserverSelect.Location = new System.Drawing.Point(170, 133);
            this.numericUpDownAATObaserverSelect.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAATObaserverSelect.Name = "numericUpDownAATObaserverSelect";
            this.numericUpDownAATObaserverSelect.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownAATObaserverSelect.TabIndex = 11;
            this.numericUpDownAATObaserverSelect.Value = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            // 
            // labelAATObserverSelect
            // 
            this.labelAATObserverSelect.AutoSize = true;
            this.labelAATObserverSelect.Location = new System.Drawing.Point(9, 136);
            this.labelAATObserverSelect.Name = "labelAATObserverSelect";
            this.labelAATObserverSelect.Size = new System.Drawing.Size(144, 19);
            this.labelAATObserverSelect.TabIndex = 10;
            this.labelAATObserverSelect.Text = "Observer Select";
            // 
            // numericUpDownAATSigma
            // 
            this.numericUpDownAATSigma.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownAATSigma.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAATSigma.DecimalPlaces = 2;
            this.numericUpDownAATSigma.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownAATSigma.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDownAATSigma.Location = new System.Drawing.Point(170, 99);
            this.numericUpDownAATSigma.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownAATSigma.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDownAATSigma.Name = "numericUpDownAATSigma";
            this.numericUpDownAATSigma.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownAATSigma.TabIndex = 3;
            this.numericUpDownAATSigma.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // labelAATSigma
            // 
            this.labelAATSigma.AutoSize = true;
            this.labelAATSigma.Location = new System.Drawing.Point(9, 102);
            this.labelAATSigma.Name = "labelAATSigma";
            this.labelAATSigma.Size = new System.Drawing.Size(54, 19);
            this.labelAATSigma.TabIndex = 2;
            this.labelAATSigma.Text = "Sigma";
            // 
            // labelAATSensorNum
            // 
            this.labelAATSensorNum.AutoSize = true;
            this.labelAATSensorNum.Location = new System.Drawing.Point(9, 26);
            this.labelAATSensorNum.Name = "labelAATSensorNum";
            this.labelAATSensorNum.Size = new System.Drawing.Size(99, 19);
            this.labelAATSensorNum.TabIndex = 7;
            this.labelAATSensorNum.Text = "Sensor Num";
            // 
            // numericUpDownAATSensorNum
            // 
            this.numericUpDownAATSensorNum.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDownAATSensorNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDownAATSensorNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDownAATSensorNum.Location = new System.Drawing.Point(170, 23);
            this.numericUpDownAATSensorNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownAATSensorNum.Name = "numericUpDownAATSensorNum";
            this.numericUpDownAATSensorNum.Size = new System.Drawing.Size(107, 26);
            this.numericUpDownAATSensorNum.TabIndex = 6;
            this.numericUpDownAATSensorNum.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // comboBoxAAT
            // 
            this.comboBoxAAT.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxAAT.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxAAT.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxAAT.FormattingEnabled = true;
            this.comboBoxAAT.Items.AddRange(new object[] {
            "Original AAT",
            "AATD"});
            this.comboBoxAAT.Location = new System.Drawing.Point(31, 44);
            this.comboBoxAAT.Name = "comboBoxAAT";
            this.comboBoxAAT.Size = new System.Drawing.Size(147, 27);
            this.comboBoxAAT.TabIndex = 38;
            // 
            // comboBoxOtherAlgo
            // 
            this.comboBoxOtherAlgo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxOtherAlgo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxOtherAlgo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxOtherAlgo.FormattingEnabled = true;
            this.comboBoxOtherAlgo.Items.AddRange(new object[] {
            "Fool"});
            this.comboBoxOtherAlgo.Location = new System.Drawing.Point(218, 44);
            this.comboBoxOtherAlgo.Name = "comboBoxOtherAlgo";
            this.comboBoxOtherAlgo.Size = new System.Drawing.Size(147, 27);
            this.comboBoxOtherAlgo.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 19);
            this.label4.TabIndex = 40;
            this.label4.Text = "GA";
            // 
            // comboBoxGA
            // 
            this.comboBoxGA.BackColor = System.Drawing.SystemColors.ControlDark;
            this.comboBoxGA.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGA.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxGA.FormattingEnabled = true;
            this.comboBoxGA.Items.AddRange(new object[] {
            "GA"});
            this.comboBoxGA.Location = new System.Drawing.Point(31, 102);
            this.comboBoxGA.Name = "comboBoxGA";
            this.comboBoxGA.Size = new System.Drawing.Size(147, 27);
            this.comboBoxGA.TabIndex = 41;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(13, 50);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(14, 13);
            this.radioButton1.TabIndex = 42;
            this.radioButton1.TabStop = true;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(198, 50);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(14, 13);
            this.radioButton2.TabIndex = 43;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(13, 108);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(14, 13);
            this.radioButton3.TabIndex = 44;
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.BackColor = System.Drawing.Color.Transparent;
            this.groupBox2.Controls.Add(this.numericUpDown4);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Location = new System.Drawing.Point(3, 467);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.groupBox2.Size = new System.Drawing.Size(285, 75);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AAT Property";
            // 
            // numericUpDown4
            // 
            this.numericUpDown4.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.numericUpDown4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown4.DecimalPlaces = 2;
            this.numericUpDown4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.numericUpDown4.Increment = new decimal(new int[] {
            5,
            0,
            0,
            131072});
            this.numericUpDown4.Location = new System.Drawing.Point(170, 27);
            this.numericUpDown4.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown4.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericUpDown4.Name = "numericUpDown4";
            this.numericUpDown4.Size = new System.Drawing.Size(107, 26);
            this.numericUpDown4.TabIndex = 9;
            this.numericUpDown4.Value = new decimal(new int[] {
            9,
            0,
            0,
            65536});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "h_target";
            // 
            // AgentGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "AgentGUI";
            this.Size = new System.Drawing.Size(534, 672);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAgentSeed)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBoxAgent.ResumeLayout(false);
            this.groupBoxAgent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATSensorRate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSensorAccuracy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATObaserverSelect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATSigma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAATSensorNum)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label labelAgentNetworkGeneProgress;
        private System.Windows.Forms.ComboBox comboBoxInitOpinion;
        private System.Windows.Forms.NumericUpDown numericUpDownAgentSeed;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerateAgentNetwork;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox groupBoxAgent;
        private System.Windows.Forms.CheckBox checkBoxAATSensorRateEnabled;
        private System.Windows.Forms.NumericUpDown numericUpDownAATSensorRate;
        private System.Windows.Forms.NumericUpDown numericUpDownSensorAccuracy;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownAATObaserverSelect;
        private System.Windows.Forms.Label labelAATObserverSelect;
        private System.Windows.Forms.NumericUpDown numericUpDownAATSigma;
        private System.Windows.Forms.Label labelAATSigma;
        private System.Windows.Forms.Label labelAATSensorNum;
        private System.Windows.Forms.NumericUpDown numericUpDownAATSensorNum;
        private System.Windows.Forms.ComboBox comboBoxAAT;
        private System.Windows.Forms.ComboBox comboBoxGA;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxOtherAlgo;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numericUpDown4;
        private System.Windows.Forms.Label label7;
    }
}
