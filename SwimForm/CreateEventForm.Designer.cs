namespace SwimForm
{
    partial class CreateEventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateEventForm));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.lblStroke = new System.Windows.Forms.Label();
            this.pnlStroke = new System.Windows.Forms.Panel();
            this.rbtIndMedley = new System.Windows.Forms.RadioButton();
            this.rbtFreeStyle = new System.Windows.Forms.RadioButton();
            this.rbtButterfly = new System.Windows.Forms.RadioButton();
            this.rbtBreaststroke = new System.Windows.Forms.RadioButton();
            this.rbtBackstroke = new System.Windows.Forms.RadioButton();
            this.pnlDistance = new System.Windows.Forms.Panel();
            this.rbt_1500 = new System.Windows.Forms.RadioButton();
            this.rbt_800 = new System.Windows.Forms.RadioButton();
            this.rbt_400 = new System.Windows.Forms.RadioButton();
            this.rbt_50 = new System.Windows.Forms.RadioButton();
            this.rbt_200 = new System.Windows.Forms.RadioButton();
            this.rbt_100 = new System.Windows.Forms.RadioButton();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlInput.SuspendLayout();
            this.pnlStroke.SuspendLayout();
            this.pnlDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.statusStrip1);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 125);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(511, 81);
            this.pnlButtons.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 59);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(511, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(371, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(114, 46);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClear.Location = new System.Drawing.Point(199, 3);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(119, 46);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreate.Location = new System.Drawing.Point(26, 3);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(110, 46);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Event";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.lblStroke);
            this.pnlInput.Controls.Add(this.pnlStroke);
            this.pnlInput.Controls.Add(this.pnlDistance);
            this.pnlInput.Controls.Add(this.lblDistance);
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(511, 121);
            this.pnlInput.TabIndex = 0;
            // 
            // lblStroke
            // 
            this.lblStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStroke.AutoSize = true;
            this.lblStroke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStroke.Location = new System.Drawing.Point(9, 96);
            this.lblStroke.Name = "lblStroke";
            this.lblStroke.Size = new System.Drawing.Size(50, 16);
            this.lblStroke.TabIndex = 18;
            this.lblStroke.Text = "Stroke:";
            // 
            // pnlStroke
            // 
            this.pnlStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlStroke.Controls.Add(this.rbtIndMedley);
            this.pnlStroke.Controls.Add(this.rbtFreeStyle);
            this.pnlStroke.Controls.Add(this.rbtButterfly);
            this.pnlStroke.Controls.Add(this.rbtBreaststroke);
            this.pnlStroke.Controls.Add(this.rbtBackstroke);
            this.pnlStroke.Location = new System.Drawing.Point(65, 92);
            this.pnlStroke.Name = "pnlStroke";
            this.pnlStroke.Size = new System.Drawing.Size(435, 26);
            this.pnlStroke.TabIndex = 2;
            // 
            // rbtIndMedley
            // 
            this.rbtIndMedley.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtIndMedley.AutoSize = true;
            this.rbtIndMedley.Location = new System.Drawing.Point(324, 4);
            this.rbtIndMedley.Name = "rbtIndMedley";
            this.rbtIndMedley.Size = new System.Drawing.Size(107, 17);
            this.rbtIndMedley.TabIndex = 4;
            this.rbtIndMedley.Text = "Individual Medley";
            this.rbtIndMedley.UseVisualStyleBackColor = true;
            // 
            // rbtFreeStyle
            // 
            this.rbtFreeStyle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtFreeStyle.AutoSize = true;
            this.rbtFreeStyle.Location = new System.Drawing.Point(251, 4);
            this.rbtFreeStyle.Name = "rbtFreeStyle";
            this.rbtFreeStyle.Size = new System.Drawing.Size(67, 17);
            this.rbtFreeStyle.TabIndex = 3;
            this.rbtFreeStyle.Text = "Freestyle";
            this.rbtFreeStyle.UseVisualStyleBackColor = true;
            // 
            // rbtButterfly
            // 
            this.rbtButterfly.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtButterfly.AutoSize = true;
            this.rbtButterfly.Location = new System.Drawing.Point(182, 4);
            this.rbtButterfly.Name = "rbtButterfly";
            this.rbtButterfly.Size = new System.Drawing.Size(63, 17);
            this.rbtButterfly.TabIndex = 2;
            this.rbtButterfly.Text = "Butterfly";
            this.rbtButterfly.UseVisualStyleBackColor = true;
            // 
            // rbtBreaststroke
            // 
            this.rbtBreaststroke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtBreaststroke.AutoSize = true;
            this.rbtBreaststroke.Location = new System.Drawing.Point(97, 4);
            this.rbtBreaststroke.Name = "rbtBreaststroke";
            this.rbtBreaststroke.Size = new System.Drawing.Size(79, 17);
            this.rbtBreaststroke.TabIndex = 1;
            this.rbtBreaststroke.Text = "Breatstroke";
            this.rbtBreaststroke.UseVisualStyleBackColor = true;
            // 
            // rbtBackstroke
            // 
            this.rbtBackstroke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtBackstroke.AutoSize = true;
            this.rbtBackstroke.Checked = true;
            this.rbtBackstroke.Location = new System.Drawing.Point(12, 4);
            this.rbtBackstroke.Name = "rbtBackstroke";
            this.rbtBackstroke.Size = new System.Drawing.Size(79, 17);
            this.rbtBackstroke.TabIndex = 0;
            this.rbtBackstroke.TabStop = true;
            this.rbtBackstroke.Text = "Backstroke";
            this.rbtBackstroke.UseVisualStyleBackColor = true;
            // 
            // pnlDistance
            // 
            this.pnlDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlDistance.Controls.Add(this.rbt_1500);
            this.pnlDistance.Controls.Add(this.rbt_800);
            this.pnlDistance.Controls.Add(this.rbt_400);
            this.pnlDistance.Controls.Add(this.rbt_50);
            this.pnlDistance.Controls.Add(this.rbt_200);
            this.pnlDistance.Controls.Add(this.rbt_100);
            this.pnlDistance.Location = new System.Drawing.Point(77, 46);
            this.pnlDistance.Name = "pnlDistance";
            this.pnlDistance.Size = new System.Drawing.Size(352, 27);
            this.pnlDistance.TabIndex = 1;
            // 
            // rbt_1500
            // 
            this.rbt_1500.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_1500.AutoSize = true;
            this.rbt_1500.Location = new System.Drawing.Point(294, 4);
            this.rbt_1500.Name = "rbt_1500";
            this.rbt_1500.Size = new System.Drawing.Size(57, 17);
            this.rbt_1500.TabIndex = 6;
            this.rbt_1500.Text = "1500m";
            this.rbt_1500.UseVisualStyleBackColor = true;
            // 
            // rbt_800
            // 
            this.rbt_800.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_800.AutoSize = true;
            this.rbt_800.Location = new System.Drawing.Point(237, 4);
            this.rbt_800.Name = "rbt_800";
            this.rbt_800.Size = new System.Drawing.Size(51, 17);
            this.rbt_800.TabIndex = 5;
            this.rbt_800.Text = "800m";
            this.rbt_800.UseVisualStyleBackColor = true;
            // 
            // rbt_400
            // 
            this.rbt_400.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_400.AutoSize = true;
            this.rbt_400.Location = new System.Drawing.Point(179, 4);
            this.rbt_400.Name = "rbt_400";
            this.rbt_400.Size = new System.Drawing.Size(51, 17);
            this.rbt_400.TabIndex = 4;
            this.rbt_400.Text = "400m";
            this.rbt_400.UseVisualStyleBackColor = true;
            // 
            // rbt_50
            // 
            this.rbt_50.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_50.AutoSize = true;
            this.rbt_50.Checked = true;
            this.rbt_50.Location = new System.Drawing.Point(14, 4);
            this.rbt_50.Name = "rbt_50";
            this.rbt_50.Size = new System.Drawing.Size(45, 17);
            this.rbt_50.TabIndex = 1;
            this.rbt_50.TabStop = true;
            this.rbt_50.Text = "50m";
            this.rbt_50.UseVisualStyleBackColor = true;
            // 
            // rbt_200
            // 
            this.rbt_200.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_200.AutoSize = true;
            this.rbt_200.Location = new System.Drawing.Point(122, 4);
            this.rbt_200.Name = "rbt_200";
            this.rbt_200.Size = new System.Drawing.Size(51, 17);
            this.rbt_200.TabIndex = 3;
            this.rbt_200.Text = "200m";
            this.rbt_200.UseVisualStyleBackColor = true;
            // 
            // rbt_100
            // 
            this.rbt_100.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_100.AutoSize = true;
            this.rbt_100.Location = new System.Drawing.Point(65, 4);
            this.rbt_100.Name = "rbt_100";
            this.rbt_100.Size = new System.Drawing.Size(51, 17);
            this.rbt_100.TabIndex = 2;
            this.rbt_100.Text = "100m";
            this.rbt_100.UseVisualStyleBackColor = true;
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblDistance.AutoSize = true;
            this.lblDistance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDistance.Location = new System.Drawing.Point(9, 51);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(64, 16);
            this.lblDistance.TabIndex = 17;
            this.lblDistance.Text = "Distance:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(166, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(162, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create An Event";
            // 
            // CreateEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(511, 206);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(527, 245);
            this.MinimumSize = new System.Drawing.Size(527, 245);
            this.Name = "CreateEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Event";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            this.pnlStroke.ResumeLayout(false);
            this.pnlStroke.PerformLayout();
            this.pnlDistance.ResumeLayout(false);
            this.pnlDistance.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Panel pnlDistance;
        private System.Windows.Forms.RadioButton rbt_50;
        private System.Windows.Forms.RadioButton rbt_200;
        private System.Windows.Forms.RadioButton rbt_100;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlStroke;
        private System.Windows.Forms.RadioButton rbtButterfly;
        private System.Windows.Forms.RadioButton rbtBreaststroke;
        private System.Windows.Forms.RadioButton rbtBackstroke;
        private System.Windows.Forms.Label lblStroke;
        private System.Windows.Forms.RadioButton rbt_400;
        private System.Windows.Forms.RadioButton rbt_1500;
        private System.Windows.Forms.RadioButton rbt_800;
        private System.Windows.Forms.RadioButton rbtFreeStyle;
        private System.Windows.Forms.RadioButton rbtIndMedley;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
    }
}