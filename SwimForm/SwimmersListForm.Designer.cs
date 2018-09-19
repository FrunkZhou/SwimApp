namespace SwimForm
{
    partial class SwimmersListForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SwimmersListForm));
            this.btnCreateSwimmer = new System.Windows.Forms.Button();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.btnAddStudent = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statuslbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.dgvSwimmers = new System.Windows.Forms.DataGridView();
            this.pnlButtons.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwimmers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateSwimmer
            // 
            this.btnCreateSwimmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCreateSwimmer.Location = new System.Drawing.Point(117, 3);
            this.btnCreateSwimmer.Name = "btnCreateSwimmer";
            this.btnCreateSwimmer.Size = new System.Drawing.Size(87, 35);
            this.btnCreateSwimmer.TabIndex = 2;
            this.btnCreateSwimmer.Text = "Create Swimmer";
            this.btnCreateSwimmer.UseVisualStyleBackColor = true;
            this.btnCreateSwimmer.Click += new System.EventHandler(this.btnCreateSwimmer_Click);
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddSwimmer.Location = new System.Drawing.Point(12, 3);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(87, 35);
            this.btnAddSwimmer.TabIndex = 1;
            this.btnAddSwimmer.Text = "Add Swimmer(s)";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(223, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 35);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.btnAddStudent);
            this.pnlButtons.Controls.Add(this.btnCreateSwimmer);
            this.pnlButtons.Controls.Add(this.statusStrip1);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnAddSwimmer);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 346);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(320, 66);
            this.pnlButtons.TabIndex = 1;
            // 
            // btnAddStudent
            // 
            this.btnAddStudent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddStudent.Location = new System.Drawing.Point(12, 3);
            this.btnAddStudent.Name = "btnAddStudent";
            this.btnAddStudent.Size = new System.Drawing.Size(87, 35);
            this.btnAddStudent.TabIndex = 3;
            this.btnAddStudent.Text = "Add Student(s)";
            this.btnAddStudent.UseVisualStyleBackColor = true;
            this.btnAddStudent.Visible = false;
            this.btnAddStudent.Click += new System.EventHandler(this.btnAddStudent_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslbl});
            this.statusStrip1.Location = new System.Drawing.Point(0, 44);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(320, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statuslbl
            // 
            this.statuslbl.Name = "statuslbl";
            this.statuslbl.Size = new System.Drawing.Size(0, 17);
            // 
            // dgvSwimmers
            // 
            this.dgvSwimmers.AllowUserToAddRows = false;
            this.dgvSwimmers.AllowUserToDeleteRows = false;
            this.dgvSwimmers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSwimmers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSwimmers.Location = new System.Drawing.Point(0, 0);
            this.dgvSwimmers.MultiSelect = false;
            this.dgvSwimmers.Name = "dgvSwimmers";
            this.dgvSwimmers.ReadOnly = true;
            this.dgvSwimmers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSwimmers.ShowEditingIcon = false;
            this.dgvSwimmers.Size = new System.Drawing.Size(320, 340);
            this.dgvSwimmers.StandardTab = true;
            this.dgvSwimmers.TabIndex = 0;
            // 
            // SwimmersListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(320, 412);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.dgvSwimmers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(336, 451);
            this.Name = "SwimmersListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "List of Swimmers";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSwimmers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        public System.Windows.Forms.Button btnCreateSwimmer;
        public System.Windows.Forms.Button btnAddSwimmer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel pnlButtons;
        public System.Windows.Forms.DataGridView dgvSwimmers;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statuslbl;
        public System.Windows.Forms.Button btnAddStudent;
    }
}