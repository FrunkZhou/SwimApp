namespace SwimForm
{
    partial class BestTimeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BestTimeForm));
            this.combobxCourse = new System.Windows.Forms.ComboBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.combobxDistance = new System.Windows.Forms.ComboBox();
            this.combobxStroke = new System.Windows.Forms.ComboBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblDistance = new System.Windows.Forms.Label();
            this.lblStroke = new System.Windows.Forms.Label();
            this.btnGetBestTime = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // combobxCourse
            // 
            this.combobxCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combobxCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxCourse.FormattingEnabled = true;
            this.combobxCourse.Items.AddRange(new object[] {
            "LCM",
            "SCM",
            "SCY"});
            this.combobxCourse.Location = new System.Drawing.Point(12, 42);
            this.combobxCourse.Name = "combobxCourse";
            this.combobxCourse.Size = new System.Drawing.Size(63, 21);
            this.combobxCourse.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(146, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(117, 29);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // combobxDistance
            // 
            this.combobxDistance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combobxDistance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxDistance.FormattingEnabled = true;
            this.combobxDistance.Items.AddRange(new object[] {
            "50m",
            "100m",
            "200m",
            "400m",
            "800m",
            "1500m"});
            this.combobxDistance.Location = new System.Drawing.Point(81, 42);
            this.combobxDistance.Name = "combobxDistance";
            this.combobxDistance.Size = new System.Drawing.Size(77, 21);
            this.combobxDistance.TabIndex = 2;
            // 
            // combobxStroke
            // 
            this.combobxStroke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.combobxStroke.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combobxStroke.FormattingEnabled = true;
            this.combobxStroke.Items.AddRange(new object[] {
            "Backstroke",
            "Breaststroke",
            "Butterfly",
            "Freestyle",
            "Individual Medley"});
            this.combobxStroke.Location = new System.Drawing.Point(164, 42);
            this.combobxStroke.Name = "combobxStroke";
            this.combobxStroke.Size = new System.Drawing.Size(99, 21);
            this.combobxStroke.TabIndex = 3;
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(23, 20);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(43, 13);
            this.lblCourse.TabIndex = 4;
            this.lblCourse.Text = "Course:";
            // 
            // lblDistance
            // 
            this.lblDistance.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDistance.AutoSize = true;
            this.lblDistance.Location = new System.Drawing.Point(95, 20);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(52, 13);
            this.lblDistance.TabIndex = 5;
            this.lblDistance.Text = "Distance:";
            // 
            // lblStroke
            // 
            this.lblStroke.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStroke.AutoSize = true;
            this.lblStroke.Location = new System.Drawing.Point(191, 20);
            this.lblStroke.Name = "lblStroke";
            this.lblStroke.Size = new System.Drawing.Size(41, 13);
            this.lblStroke.TabIndex = 6;
            this.lblStroke.Text = "Stroke:";
            // 
            // btnGetBestTime
            // 
            this.btnGetBestTime.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnGetBestTime.Location = new System.Drawing.Point(12, 80);
            this.btnGetBestTime.Name = "btnGetBestTime";
            this.btnGetBestTime.Size = new System.Drawing.Size(117, 29);
            this.btnGetBestTime.TabIndex = 0;
            this.btnGetBestTime.Text = "Get Best Time";
            this.btnGetBestTime.UseVisualStyleBackColor = true;
            this.btnGetBestTime.Click += new System.EventHandler(this.btnGetBestTime_Click);
            // 
            // BestTimeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(278, 124);
            this.Controls.Add(this.btnGetBestTime);
            this.Controls.Add(this.lblStroke);
            this.Controls.Add(this.lblDistance);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.combobxStroke);
            this.Controls.Add(this.combobxDistance);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.combobxCourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(294, 163);
            this.MinimumSize = new System.Drawing.Size(294, 163);
            this.Name = "BestTimeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Best Time ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox combobxCourse;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ComboBox combobxDistance;
        private System.Windows.Forms.ComboBox combobxStroke;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblStroke;
        private System.Windows.Forms.Button btnGetBestTime;
    }
}