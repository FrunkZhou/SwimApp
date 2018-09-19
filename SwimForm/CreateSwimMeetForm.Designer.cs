namespace SwimForm
{
    partial class CreateSwimMeetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateSwimMeetForm));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.pnlInput = new System.Windows.Forms.Panel();
            this.dtPkEnd = new System.Windows.Forms.DateTimePicker();
            this.dtPkStart = new System.Windows.Forms.DateTimePicker();
            this.nmUDLanes = new System.Windows.Forms.NumericUpDown();
            this.lblLanes = new System.Windows.Forms.Label();
            this.pnlCourse = new System.Windows.Forms.Panel();
            this.rbtLCM = new System.Windows.Forms.RadioButton();
            this.rbtSCY = new System.Windows.Forms.RadioButton();
            this.rbtSCM = new System.Windows.Forms.RadioButton();
            this.lblCourse = new System.Windows.Forms.Label();
            this.lblEndDate = new System.Windows.Forms.Label();
            this.lblStartDate = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDLanes)).BeginInit();
            this.pnlCourse.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.statusStrip1);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnClear);
            this.pnlButtons.Controls.Add(this.btnCreate);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 175);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(381, 81);
            this.pnlButtons.TabIndex = 1;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 59);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(381, 22);
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
            this.btnCancel.Location = new System.Drawing.Point(277, 6);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 36);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnClear.Location = new System.Drawing.Point(145, 6);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(95, 36);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnCreate
            // 
            this.btnCreate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreate.Location = new System.Drawing.Point(12, 6);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(98, 36);
            this.btnCreate.TabIndex = 1;
            this.btnCreate.Text = "Create Swim Meet";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // pnlInput
            // 
            this.pnlInput.Controls.Add(this.dtPkEnd);
            this.pnlInput.Controls.Add(this.dtPkStart);
            this.pnlInput.Controls.Add(this.nmUDLanes);
            this.pnlInput.Controls.Add(this.lblLanes);
            this.pnlInput.Controls.Add(this.pnlCourse);
            this.pnlInput.Controls.Add(this.lblCourse);
            this.pnlInput.Controls.Add(this.lblEndDate);
            this.pnlInput.Controls.Add(this.lblStartDate);
            this.pnlInput.Controls.Add(this.lblTitle);
            this.pnlInput.Controls.Add(this.txtName);
            this.pnlInput.Controls.Add(this.lblName);
            this.pnlInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlInput.Location = new System.Drawing.Point(0, 0);
            this.pnlInput.Name = "pnlInput";
            this.pnlInput.Size = new System.Drawing.Size(381, 175);
            this.pnlInput.TabIndex = 0;
            // 
            // dtPkEnd
            // 
            this.dtPkEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtPkEnd.Location = new System.Drawing.Point(86, 117);
            this.dtPkEnd.Name = "dtPkEnd";
            this.dtPkEnd.Size = new System.Drawing.Size(134, 20);
            this.dtPkEnd.TabIndex = 3;
            // 
            // dtPkStart
            // 
            this.dtPkStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dtPkStart.Location = new System.Drawing.Point(86, 84);
            this.dtPkStart.Name = "dtPkStart";
            this.dtPkStart.Size = new System.Drawing.Size(134, 20);
            this.dtPkStart.TabIndex = 2;
            // 
            // nmUDLanes
            // 
            this.nmUDLanes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.nmUDLanes.Location = new System.Drawing.Point(161, 149);
            this.nmUDLanes.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.nmUDLanes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmUDLanes.Name = "nmUDLanes";
            this.nmUDLanes.Size = new System.Drawing.Size(31, 20);
            this.nmUDLanes.TabIndex = 4;
            this.nmUDLanes.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblLanes
            // 
            this.lblLanes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblLanes.AutoSize = true;
            this.lblLanes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLanes.Location = new System.Drawing.Point(10, 153);
            this.lblLanes.Name = "lblLanes";
            this.lblLanes.Size = new System.Drawing.Size(113, 16);
            this.lblLanes.TabIndex = 19;
            this.lblLanes.Text = "Number of Lanes:";
            // 
            // pnlCourse
            // 
            this.pnlCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.pnlCourse.Controls.Add(this.rbtLCM);
            this.pnlCourse.Controls.Add(this.rbtSCY);
            this.pnlCourse.Controls.Add(this.rbtSCM);
            this.pnlCourse.Location = new System.Drawing.Point(269, 49);
            this.pnlCourse.Name = "pnlCourse";
            this.pnlCourse.Size = new System.Drawing.Size(84, 73);
            this.pnlCourse.TabIndex = 5;
            // 
            // rbtLCM
            // 
            this.rbtLCM.AutoSize = true;
            this.rbtLCM.Checked = true;
            this.rbtLCM.Location = new System.Drawing.Point(14, 4);
            this.rbtLCM.Name = "rbtLCM";
            this.rbtLCM.Size = new System.Drawing.Size(47, 17);
            this.rbtLCM.TabIndex = 2;
            this.rbtLCM.TabStop = true;
            this.rbtLCM.Text = "LCM";
            this.rbtLCM.UseVisualStyleBackColor = true;
            // 
            // rbtSCY
            // 
            this.rbtSCY.AutoSize = true;
            this.rbtSCY.Location = new System.Drawing.Point(14, 50);
            this.rbtSCY.Name = "rbtSCY";
            this.rbtSCY.Size = new System.Drawing.Size(46, 17);
            this.rbtSCY.TabIndex = 1;
            this.rbtSCY.Text = "SCY";
            this.rbtSCY.UseVisualStyleBackColor = true;
            // 
            // rbtSCM
            // 
            this.rbtSCM.AutoSize = true;
            this.rbtSCM.Location = new System.Drawing.Point(14, 27);
            this.rbtSCM.Name = "rbtSCM";
            this.rbtSCM.Size = new System.Drawing.Size(48, 17);
            this.rbtSCM.TabIndex = 0;
            this.rbtSCM.Text = "SCM";
            this.rbtSCM.UseVisualStyleBackColor = true;
            // 
            // lblCourse
            // 
            this.lblCourse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblCourse.AutoSize = true;
            this.lblCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCourse.Location = new System.Drawing.Point(209, 50);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(54, 16);
            this.lblCourse.TabIndex = 17;
            this.lblCourse.Text = "Course:";
            // 
            // lblEndDate
            // 
            this.lblEndDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEndDate.AutoSize = true;
            this.lblEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndDate.Location = new System.Drawing.Point(10, 119);
            this.lblEndDate.Name = "lblEndDate";
            this.lblEndDate.Size = new System.Drawing.Size(67, 16);
            this.lblEndDate.TabIndex = 15;
            this.lblEndDate.Text = "End Date:";
            // 
            // lblStartDate
            // 
            this.lblStartDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStartDate.AutoSize = true;
            this.lblStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStartDate.Location = new System.Drawing.Point(10, 87);
            this.lblStartDate.Name = "lblStartDate";
            this.lblStartDate.Size = new System.Drawing.Size(70, 16);
            this.lblStartDate.TabIndex = 14;
            this.lblStartDate.Text = "Start Date:";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(87, 9);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(199, 24);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Create A Swim Meet";
            // 
            // txtName
            // 
            this.txtName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtName.Location = new System.Drawing.Point(64, 49);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(128, 20);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(10, 50);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name:";
            // 
            // CreateSwimMeetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(381, 256);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.pnlInput);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(397, 295);
            this.MinimumSize = new System.Drawing.Size(397, 295);
            this.Name = "CreateSwimMeetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Swim Meet";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlInput.ResumeLayout(false);
            this.pnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmUDLanes)).EndInit();
            this.pnlCourse.ResumeLayout(false);
            this.pnlCourse.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Panel pnlInput;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.NumericUpDown nmUDLanes;
        private System.Windows.Forms.Label lblLanes;
        private System.Windows.Forms.Panel pnlCourse;
        private System.Windows.Forms.RadioButton rbtLCM;
        private System.Windows.Forms.RadioButton rbtSCY;
        private System.Windows.Forms.RadioButton rbtSCM;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtPkEnd;
        private System.Windows.Forms.DateTimePicker dtPkStart;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
    }
}