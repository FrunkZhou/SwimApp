namespace SwimForm
{
    partial class SwimTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwimTimeForm));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSetTime = new System.Windows.Forms.Button();
            this.lblMin = new System.Windows.Forms.Label();
            this.lblSec = new System.Windows.Forms.Label();
            this.lblMilli = new System.Windows.Forms.Label();
            this.lblMinSecSeparater = new System.Windows.Forms.Label();
            this.lblSecMilliSeparator = new System.Windows.Forms.Label();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtMilli = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslblSwimmerTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(110, 65);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(81, 32);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSetTime
            // 
            this.btnSetTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSetTime.Location = new System.Drawing.Point(12, 65);
            this.btnSetTime.Name = "btnSetTime";
            this.btnSetTime.Size = new System.Drawing.Size(81, 32);
            this.btnSetTime.TabIndex = 3;
            this.btnSetTime.Text = "Set Time";
            this.btnSetTime.UseVisualStyleBackColor = true;
            this.btnSetTime.Click += new System.EventHandler(this.btnSetTime_Click);
            // 
            // lblMin
            // 
            this.lblMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMin.AutoSize = true;
            this.lblMin.Location = new System.Drawing.Point(11, 19);
            this.lblMin.Name = "lblMin";
            this.lblMin.Size = new System.Drawing.Size(44, 13);
            this.lblMin.TabIndex = 2;
            this.lblMin.Text = "Minutes";
            // 
            // lblSec
            // 
            this.lblSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSec.AutoSize = true;
            this.lblSec.Location = new System.Drawing.Point(72, 19);
            this.lblSec.Name = "lblSec";
            this.lblSec.Size = new System.Drawing.Size(49, 13);
            this.lblSec.TabIndex = 3;
            this.lblSec.Text = "Seconds";
            // 
            // lblMilli
            // 
            this.lblMilli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMilli.AutoSize = true;
            this.lblMilli.Location = new System.Drawing.Point(127, 19);
            this.lblMilli.Name = "lblMilli";
            this.lblMilli.Size = new System.Drawing.Size(64, 13);
            this.lblMilli.TabIndex = 4;
            this.lblMilli.Text = "Milliseconds";
            // 
            // lblMinSecSeparater
            // 
            this.lblMinSecSeparater.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMinSecSeparater.AutoSize = true;
            this.lblMinSecSeparater.Location = new System.Drawing.Point(59, 38);
            this.lblMinSecSeparater.Name = "lblMinSecSeparater";
            this.lblMinSecSeparater.Size = new System.Drawing.Size(10, 13);
            this.lblMinSecSeparater.TabIndex = 5;
            this.lblMinSecSeparater.Text = ":";
            // 
            // lblSecMilliSeparator
            // 
            this.lblSecMilliSeparator.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblSecMilliSeparator.AutoSize = true;
            this.lblSecMilliSeparator.Location = new System.Drawing.Point(122, 38);
            this.lblSecMilliSeparator.Name = "lblSecMilliSeparator";
            this.lblSecMilliSeparator.Size = new System.Drawing.Size(10, 13);
            this.lblSecMilliSeparator.TabIndex = 6;
            this.lblSecMilliSeparator.Text = ".";
            // 
            // txtMin
            // 
            this.txtMin.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMin.Location = new System.Drawing.Point(12, 35);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(41, 20);
            this.txtMin.TabIndex = 0;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMin_KeyPress);
            // 
            // txtSec
            // 
            this.txtSec.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtSec.Location = new System.Drawing.Point(75, 35);
            this.txtSec.Name = "txtSec";
            this.txtSec.Size = new System.Drawing.Size(41, 20);
            this.txtSec.TabIndex = 1;
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSec.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSec_KeyPress);
            // 
            // txtMilli
            // 
            this.txtMilli.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtMilli.Location = new System.Drawing.Point(138, 35);
            this.txtMilli.Name = "txtMilli";
            this.txtMilli.Size = new System.Drawing.Size(41, 20);
            this.txtMilli.TabIndex = 2;
            this.txtMilli.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMilli_KeyPress);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslblSwimmerTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 100);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(204, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStripSwimmerTime";
            // 
            // statuslblSwimmerTime
            // 
            this.statuslblSwimmerTime.Name = "statuslblSwimmerTime";
            this.statuslblSwimmerTime.Size = new System.Drawing.Size(0, 17);
            // 
            // SwimTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(204, 122);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.txtMilli);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.txtMin);
            this.Controls.Add(this.lblSecMilliSeparator);
            this.Controls.Add(this.lblMinSecSeparater);
            this.Controls.Add(this.lblMilli);
            this.Controls.Add(this.lblSec);
            this.Controls.Add(this.lblMin);
            this.Controls.Add(this.btnSetTime);
            this.Controls.Add(this.btnCancel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(220, 161);
            this.MinimumSize = new System.Drawing.Size(220, 161);
            this.Name = "SwimTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Time";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSetTime;
        private System.Windows.Forms.Label lblMin;
        private System.Windows.Forms.Label lblSec;
        private System.Windows.Forms.Label lblMilli;
        private System.Windows.Forms.Label lblMinSecSeparater;
        private System.Windows.Forms.Label lblSecMilliSeparator;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtMilli;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslblSwimmerTime;
    }
}