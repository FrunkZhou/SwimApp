namespace SwimForm
{
    partial class CoachesListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CoachesListForm));
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnChangeCoach = new System.Windows.Forms.Button();
            this.btnCreateCoach = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAddCoach = new System.Windows.Forms.Button();
            this.dgvCoaches = new System.Windows.Forms.DataGridView();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.statusStrip1);
            this.pnlButtons.Controls.Add(this.btnChangeCoach);
            this.pnlButtons.Controls.Add(this.btnCreateCoach);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnAddCoach);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 346);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(320, 66);
            this.pnlButtons.TabIndex = 4;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 44);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(320, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // btnChangeCoach
            // 
            this.btnChangeCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnChangeCoach.Location = new System.Drawing.Point(12, 5);
            this.btnChangeCoach.Name = "btnChangeCoach";
            this.btnChangeCoach.Size = new System.Drawing.Size(87, 35);
            this.btnChangeCoach.TabIndex = 3;
            this.btnChangeCoach.Text = "Change Coach";
            this.btnChangeCoach.UseVisualStyleBackColor = true;
            this.btnChangeCoach.Visible = false;
            this.btnChangeCoach.Click += new System.EventHandler(this.btnChangeCoach_Click);
            // 
            // btnCreateCoach
            // 
            this.btnCreateCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreateCoach.Location = new System.Drawing.Point(118, 5);
            this.btnCreateCoach.Name = "btnCreateCoach";
            this.btnCreateCoach.Size = new System.Drawing.Size(87, 35);
            this.btnCreateCoach.TabIndex = 2;
            this.btnCreateCoach.Text = "Create Coach";
            this.btnCreateCoach.UseVisualStyleBackColor = true;
            this.btnCreateCoach.Click += new System.EventHandler(this.btnCreateCoach_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnAddCoach
            // 
            this.btnAddCoach.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddCoach.Location = new System.Drawing.Point(12, 5);
            this.btnAddCoach.Name = "btnAddCoach";
            this.btnAddCoach.Size = new System.Drawing.Size(87, 35);
            this.btnAddCoach.TabIndex = 1;
            this.btnAddCoach.Text = "Add Coach(s)";
            this.btnAddCoach.UseVisualStyleBackColor = true;
            this.btnAddCoach.Click += new System.EventHandler(this.btnAddCoach_Click);
            // 
            // dgvCoaches
            // 
            this.dgvCoaches.AllowUserToAddRows = false;
            this.dgvCoaches.AllowUserToDeleteRows = false;
            this.dgvCoaches.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCoaches.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoaches.Location = new System.Drawing.Point(0, 1);
            this.dgvCoaches.MultiSelect = false;
            this.dgvCoaches.Name = "dgvCoaches";
            this.dgvCoaches.ReadOnly = true;
            this.dgvCoaches.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoaches.ShowEditingIcon = false;
            this.dgvCoaches.Size = new System.Drawing.Size(320, 344);
            this.dgvCoaches.StandardTab = true;
            this.dgvCoaches.TabIndex = 1;
            // 
            // CoachesListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(320, 412);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvCoaches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(336, 451);
            this.Name = "CoachesListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List of Coaches";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoaches)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pnlButtons;
        public System.Windows.Forms.Button btnCreateCoach;
        private System.Windows.Forms.Button btnCancel;
        public System.Windows.Forms.Button btnAddCoach;
        public System.Windows.Forms.DataGridView dgvCoaches;
        public System.Windows.Forms.Button btnChangeCoach;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
    }
}