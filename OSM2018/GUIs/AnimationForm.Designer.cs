namespace OSM2018.GUIs
{
    partial class AnimationForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBoxLeft = new System.Windows.Forms.CheckBox();
            this.checkBoxDown = new System.Windows.Forms.CheckBox();
            this.checkBoxRight = new System.Windows.Forms.CheckBox();
            this.checkBoxUp = new System.Windows.Forms.CheckBox();
            this.checkBoxZoomOut = new System.Windows.Forms.CheckBox();
            this.checkBoxZoomIn = new System.Windows.Forms.CheckBox();
            this.pictureBoxAnimation = new System.Windows.Forms.PictureBox();
            this.buttonUpdateAnimationView = new System.Windows.Forms.Button();
            this.comboBoxLayout = new System.Windows.Forms.ComboBox();
            this.trackBarRadius = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBoxLeft
            // 
            this.checkBoxLeft.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxLeft.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxLeft.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxLeft.BackgroundImage = global::OSM2018.Properties.Resources.icon_left;
            this.checkBoxLeft.FlatAppearance.BorderSize = 0;
            this.checkBoxLeft.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxLeft.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLeft.Location = new System.Drawing.Point(609, 512);
            this.checkBoxLeft.Name = "checkBoxLeft";
            this.checkBoxLeft.Size = new System.Drawing.Size(48, 48);
            this.checkBoxLeft.TabIndex = 34;
            this.checkBoxLeft.UseVisualStyleBackColor = false;
            // 
            // checkBoxDown
            // 
            this.checkBoxDown.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxDown.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxDown.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxDown.BackgroundImage = global::OSM2018.Properties.Resources.icon_down;
            this.checkBoxDown.FlatAppearance.BorderSize = 0;
            this.checkBoxDown.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxDown.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxDown.Location = new System.Drawing.Point(663, 512);
            this.checkBoxDown.Name = "checkBoxDown";
            this.checkBoxDown.Size = new System.Drawing.Size(48, 48);
            this.checkBoxDown.TabIndex = 33;
            this.checkBoxDown.UseVisualStyleBackColor = false;
            // 
            // checkBoxRight
            // 
            this.checkBoxRight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxRight.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxRight.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxRight.BackgroundImage = global::OSM2018.Properties.Resources.icon_right;
            this.checkBoxRight.FlatAppearance.BorderSize = 0;
            this.checkBoxRight.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxRight.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxRight.Location = new System.Drawing.Point(717, 512);
            this.checkBoxRight.Name = "checkBoxRight";
            this.checkBoxRight.Size = new System.Drawing.Size(48, 48);
            this.checkBoxRight.TabIndex = 32;
            this.checkBoxRight.UseVisualStyleBackColor = false;
            // 
            // checkBoxUp
            // 
            this.checkBoxUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxUp.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxUp.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxUp.BackgroundImage = global::OSM2018.Properties.Resources.icon_up;
            this.checkBoxUp.FlatAppearance.BorderSize = 0;
            this.checkBoxUp.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxUp.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUp.Location = new System.Drawing.Point(663, 458);
            this.checkBoxUp.Name = "checkBoxUp";
            this.checkBoxUp.Size = new System.Drawing.Size(48, 48);
            this.checkBoxUp.TabIndex = 31;
            this.checkBoxUp.UseVisualStyleBackColor = false;
            // 
            // checkBoxZoomOut
            // 
            this.checkBoxZoomOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxZoomOut.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxZoomOut.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxZoomOut.BackgroundImage = global::OSM2018.Properties.Resources.icon_minus;
            this.checkBoxZoomOut.FlatAppearance.BorderSize = 0;
            this.checkBoxZoomOut.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxZoomOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxZoomOut.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxZoomOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxZoomOut.Location = new System.Drawing.Point(734, 404);
            this.checkBoxZoomOut.Name = "checkBoxZoomOut";
            this.checkBoxZoomOut.Size = new System.Drawing.Size(48, 48);
            this.checkBoxZoomOut.TabIndex = 30;
            this.checkBoxZoomOut.UseVisualStyleBackColor = false;
            // 
            // checkBoxZoomIn
            // 
            this.checkBoxZoomIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBoxZoomIn.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBoxZoomIn.BackColor = System.Drawing.Color.Transparent;
            this.checkBoxZoomIn.BackgroundImage = global::OSM2018.Properties.Resources.icon_seedplus;
            this.checkBoxZoomIn.FlatAppearance.BorderSize = 0;
            this.checkBoxZoomIn.FlatAppearance.CheckedBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxZoomIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.checkBoxZoomIn.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBoxZoomIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxZoomIn.Location = new System.Drawing.Point(734, 350);
            this.checkBoxZoomIn.Name = "checkBoxZoomIn";
            this.checkBoxZoomIn.Size = new System.Drawing.Size(48, 48);
            this.checkBoxZoomIn.TabIndex = 29;
            this.checkBoxZoomIn.UseVisualStyleBackColor = false;
            // 
            // pictureBoxAnimation
            // 
            this.pictureBoxAnimation.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pictureBoxAnimation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxAnimation.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxAnimation.Name = "pictureBoxAnimation";
            this.pictureBoxAnimation.Size = new System.Drawing.Size(806, 563);
            this.pictureBoxAnimation.TabIndex = 28;
            this.pictureBoxAnimation.TabStop = false;
            this.pictureBoxAnimation.SizeChanged += new System.EventHandler(this.pictureBoxAnimation_SizeChanged);
            this.pictureBoxAnimation.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxAnimation_Paint);
            this.pictureBoxAnimation.DoubleClick += new System.EventHandler(this.pictureBoxAnimation_DoubleClick);
            this.pictureBoxAnimation.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAnimation_MouseClick);
            this.pictureBoxAnimation.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAnimation_MouseDown);
            this.pictureBoxAnimation.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAnimation_MouseMove);
            this.pictureBoxAnimation.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxAnimation_MouseUp);
            // 
            // buttonUpdateAnimationView
            // 
            this.buttonUpdateAnimationView.AutoSize = true;
            this.buttonUpdateAnimationView.BackColor = System.Drawing.Color.Transparent;
            this.buttonUpdateAnimationView.BackgroundImage = global::OSM2018.Properties.Resources.icon_update;
            this.buttonUpdateAnimationView.FlatAppearance.BorderSize = 0;
            this.buttonUpdateAnimationView.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonUpdateAnimationView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonUpdateAnimationView.Location = new System.Drawing.Point(0, 2);
            this.buttonUpdateAnimationView.Name = "buttonUpdateAnimationView";
            this.buttonUpdateAnimationView.Size = new System.Drawing.Size(48, 48);
            this.buttonUpdateAnimationView.TabIndex = 35;
            this.buttonUpdateAnimationView.UseVisualStyleBackColor = false;
            // 
            // comboBoxLayout
            // 
            this.comboBoxLayout.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.comboBoxLayout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLayout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxLayout.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxLayout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.comboBoxLayout.FormattingEnabled = true;
            this.comboBoxLayout.Location = new System.Drawing.Point(54, 12);
            this.comboBoxLayout.Name = "comboBoxLayout";
            this.comboBoxLayout.Size = new System.Drawing.Size(252, 27);
            this.comboBoxLayout.TabIndex = 36;
            // 
            // trackBarRadius
            // 
            this.trackBarRadius.LargeChange = 1;
            this.trackBarRadius.Location = new System.Drawing.Point(312, 12);
            this.trackBarRadius.Maximum = 20;
            this.trackBarRadius.Minimum = 1;
            this.trackBarRadius.Name = "trackBarRadius";
            this.trackBarRadius.Size = new System.Drawing.Size(252, 45);
            this.trackBarRadius.TabIndex = 37;
            this.trackBarRadius.Value = 1;
            this.trackBarRadius.Scroll += new System.EventHandler(this.trackBarRadius_Scroll);
            // 
            // AnimationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(806, 563);
            this.Controls.Add(this.trackBarRadius);
            this.Controls.Add(this.buttonUpdateAnimationView);
            this.Controls.Add(this.comboBoxLayout);
            this.Controls.Add(this.checkBoxLeft);
            this.Controls.Add(this.checkBoxDown);
            this.Controls.Add(this.checkBoxRight);
            this.Controls.Add(this.checkBoxUp);
            this.Controls.Add(this.checkBoxZoomOut);
            this.Controls.Add(this.checkBoxZoomIn);
            this.Controls.Add(this.pictureBoxAnimation);
            this.Name = "AnimationForm";
            this.Text = "AnimationForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAnimation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRadius)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBoxLeft;
        private System.Windows.Forms.CheckBox checkBoxDown;
        private System.Windows.Forms.CheckBox checkBoxRight;
        private System.Windows.Forms.CheckBox checkBoxUp;
        private System.Windows.Forms.CheckBox checkBoxZoomOut;
        private System.Windows.Forms.CheckBox checkBoxZoomIn;
        private System.Windows.Forms.PictureBox pictureBoxAnimation;
        private System.Windows.Forms.Button buttonUpdateAnimationView;
        private System.Windows.Forms.ComboBox comboBoxLayout;
        private System.Windows.Forms.TrackBar trackBarRadius;
    }
}