namespace SwimForm
{
    partial class EventForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventForm));
            this.lblSwimmers = new System.Windows.Forms.Label();
            this.lsbSwimmers = new System.Windows.Forms.ListBox();
            this.pnlButtons = new System.Windows.Forms.Panel();
            this.statusStripEvent = new System.Windows.Forms.StatusStrip();
            this.statuslblEvent = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnSeedEvent = new System.Windows.Forms.Button();
            this.btnRemoveSwimmer = new System.Windows.Forms.Button();
            this.btnAddSwimmer = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdateEvent = new System.Windows.Forms.Button();
            this.pnlSwimmersData = new System.Windows.Forms.Panel();
            this.btnAddChangeTime = new System.Windows.Forms.Button();
            this.lblSwimmersTime = new System.Windows.Forms.Label();
            this.lblSwimmerTitle = new System.Windows.Forms.Label();
            this.lblSwimmersHeat = new System.Windows.Forms.Label();
            this.txtSwimmersName = new System.Windows.Forms.TextBox();
            this.txtSwimmersTime = new System.Windows.Forms.TextBox();
            this.txtSwimmersHeat = new System.Windows.Forms.TextBox();
            this.lblSwimmersLane = new System.Windows.Forms.Label();
            this.lblSwimmersName = new System.Windows.Forms.Label();
            this.txtSwimmersID = new System.Windows.Forms.TextBox();
            this.txtSwimmersLane = new System.Windows.Forms.TextBox();
            this.lblSwimmersID = new System.Windows.Forms.Label();
            this.pnlEventData = new System.Windows.Forms.Panel();
            this.lblEventSeeded = new System.Windows.Forms.Label();
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
            this.lblEventTitle = new System.Windows.Forms.Label();
            this.pnlButtons.SuspendLayout();
            this.statusStripEvent.SuspendLayout();
            this.pnlSwimmersData.SuspendLayout();
            this.pnlEventData.SuspendLayout();
            this.pnlStroke.SuspendLayout();
            this.pnlDistance.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSwimmers
            // 
            this.lblSwimmers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSwimmers.AutoSize = true;
            this.lblSwimmers.Location = new System.Drawing.Point(59, -1);
            this.lblSwimmers.Name = "lblSwimmers";
            this.lblSwimmers.Size = new System.Drawing.Size(54, 13);
            this.lblSwimmers.TabIndex = 19;
            this.lblSwimmers.Text = "Swimmers";
            // 
            // lsbSwimmers
            // 
            this.lsbSwimmers.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lsbSwimmers.FormattingEnabled = true;
            this.lsbSwimmers.Location = new System.Drawing.Point(0, 12);
            this.lsbSwimmers.Name = "lsbSwimmers";
            this.lsbSwimmers.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lsbSwimmers.Size = new System.Drawing.Size(169, 238);
            this.lsbSwimmers.TabIndex = 18;
            this.lsbSwimmers.TabStop = false;
            this.lsbSwimmers.SelectedIndexChanged += new System.EventHandler(this.lsbSwimmers_SelectedIndexChanged);
            this.lsbSwimmers.DoubleClick += new System.EventHandler(this.lsbSwimmers_DoubleClick);
            // 
            // pnlButtons
            // 
            this.pnlButtons.Controls.Add(this.statusStripEvent);
            this.pnlButtons.Controls.Add(this.btnSeedEvent);
            this.pnlButtons.Controls.Add(this.btnRemoveSwimmer);
            this.pnlButtons.Controls.Add(this.btnAddSwimmer);
            this.pnlButtons.Controls.Add(this.btnCancel);
            this.pnlButtons.Controls.Add(this.btnUpdateEvent);
            this.pnlButtons.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlButtons.Location = new System.Drawing.Point(0, 249);
            this.pnlButtons.Name = "pnlButtons";
            this.pnlButtons.Size = new System.Drawing.Size(609, 76);
            this.pnlButtons.TabIndex = 1;
            this.pnlButtons.TabStop = true;
            // 
            // statusStripEvent
            // 
            this.statusStripEvent.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statuslblEvent});
            this.statusStripEvent.Location = new System.Drawing.Point(0, 54);
            this.statusStripEvent.Name = "statusStripEvent";
            this.statusStripEvent.Size = new System.Drawing.Size(609, 22);
            this.statusStripEvent.TabIndex = 21;
            this.statusStripEvent.Text = "statusStrip1";
            // 
            // statuslblEvent
            // 
            this.statuslblEvent.Name = "statuslblEvent";
            this.statuslblEvent.Size = new System.Drawing.Size(0, 17);
            // 
            // btnSeedEvent
            // 
            this.btnSeedEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSeedEvent.Location = new System.Drawing.Point(234, 7);
            this.btnSeedEvent.Name = "btnSeedEvent";
            this.btnSeedEvent.Size = new System.Drawing.Size(113, 40);
            this.btnSeedEvent.TabIndex = 1;
            this.btnSeedEvent.Text = "Seed Event";
            this.btnSeedEvent.UseVisualStyleBackColor = true;
            this.btnSeedEvent.Click += new System.EventHandler(this.btnSeedEvent_Click);
            // 
            // btnRemoveSwimmer
            // 
            this.btnRemoveSwimmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnRemoveSwimmer.Location = new System.Drawing.Point(87, 7);
            this.btnRemoveSwimmer.Name = "btnRemoveSwimmer";
            this.btnRemoveSwimmer.Size = new System.Drawing.Size(77, 40);
            this.btnRemoveSwimmer.TabIndex = 20;
            this.btnRemoveSwimmer.TabStop = false;
            this.btnRemoveSwimmer.Text = "Remove Swimmer(s)";
            this.btnRemoveSwimmer.UseVisualStyleBackColor = true;
            this.btnRemoveSwimmer.Click += new System.EventHandler(this.btnRemoveSwimmer_Click);
            // 
            // btnAddSwimmer
            // 
            this.btnAddSwimmer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddSwimmer.Location = new System.Drawing.Point(8, 7);
            this.btnAddSwimmer.Name = "btnAddSwimmer";
            this.btnAddSwimmer.Size = new System.Drawing.Size(71, 40);
            this.btnAddSwimmer.TabIndex = 19;
            this.btnAddSwimmer.TabStop = false;
            this.btnAddSwimmer.Text = "Add Swimmer(s)";
            this.btnAddSwimmer.UseVisualStyleBackColor = true;
            this.btnAddSwimmer.Click += new System.EventHandler(this.btnAddSwimmer_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(512, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 40);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnUpdateEvent
            // 
            this.btnUpdateEvent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnUpdateEvent.Location = new System.Drawing.Point(417, 7);
            this.btnUpdateEvent.Name = "btnUpdateEvent";
            this.btnUpdateEvent.Size = new System.Drawing.Size(85, 40);
            this.btnUpdateEvent.TabIndex = 2;
            this.btnUpdateEvent.Text = "Update Event";
            this.btnUpdateEvent.UseVisualStyleBackColor = true;
            this.btnUpdateEvent.Click += new System.EventHandler(this.btnUpdateEvent_Click);
            // 
            // pnlSwimmersData
            // 
            this.pnlSwimmersData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlSwimmersData.Controls.Add(this.btnAddChangeTime);
            this.pnlSwimmersData.Controls.Add(this.lblSwimmersTime);
            this.pnlSwimmersData.Controls.Add(this.lblSwimmerTitle);
            this.pnlSwimmersData.Controls.Add(this.lblSwimmersHeat);
            this.pnlSwimmersData.Controls.Add(this.txtSwimmersName);
            this.pnlSwimmersData.Controls.Add(this.txtSwimmersTime);
            this.pnlSwimmersData.Controls.Add(this.txtSwimmersHeat);
            this.pnlSwimmersData.Controls.Add(this.lblSwimmersLane);
            this.pnlSwimmersData.Controls.Add(this.lblSwimmersName);
            this.pnlSwimmersData.Controls.Add(this.txtSwimmersID);
            this.pnlSwimmersData.Controls.Add(this.txtSwimmersLane);
            this.pnlSwimmersData.Controls.Add(this.lblSwimmersID);
            this.pnlSwimmersData.Location = new System.Drawing.Point(175, 12);
            this.pnlSwimmersData.Name = "pnlSwimmersData";
            this.pnlSwimmersData.Size = new System.Drawing.Size(227, 238);
            this.pnlSwimmersData.TabIndex = 21;
            // 
            // btnAddChangeTime
            // 
            this.btnAddChangeTime.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnAddChangeTime.Enabled = false;
            this.btnAddChangeTime.Location = new System.Drawing.Point(21, 204);
            this.btnAddChangeTime.Name = "btnAddChangeTime";
            this.btnAddChangeTime.Size = new System.Drawing.Size(187, 24);
            this.btnAddChangeTime.TabIndex = 21;
            this.btnAddChangeTime.TabStop = false;
            this.btnAddChangeTime.Text = "Add/Change Time";
            this.btnAddChangeTime.UseVisualStyleBackColor = true;
            this.btnAddChangeTime.Click += new System.EventHandler(this.btnAddChangeTime_Click);
            // 
            // lblSwimmersTime
            // 
            this.lblSwimmersTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSwimmersTime.AutoSize = true;
            this.lblSwimmersTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmersTime.Location = new System.Drawing.Point(16, 168);
            this.lblSwimmersTime.Name = "lblSwimmersTime";
            this.lblSwimmersTime.Size = new System.Drawing.Size(52, 20);
            this.lblSwimmersTime.TabIndex = 39;
            this.lblSwimmersTime.Text = "Time:";
            // 
            // lblSwimmerTitle
            // 
            this.lblSwimmerTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSwimmerTitle.AutoSize = true;
            this.lblSwimmerTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmerTitle.Location = new System.Drawing.Point(72, 10);
            this.lblSwimmerTitle.Name = "lblSwimmerTitle";
            this.lblSwimmerTitle.Size = new System.Drawing.Size(96, 24);
            this.lblSwimmerTitle.TabIndex = 38;
            this.lblSwimmerTitle.Text = "Swimmer";
            // 
            // lblSwimmersHeat
            // 
            this.lblSwimmersHeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSwimmersHeat.AutoSize = true;
            this.lblSwimmersHeat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmersHeat.Location = new System.Drawing.Point(17, 108);
            this.lblSwimmersHeat.Name = "lblSwimmersHeat";
            this.lblSwimmersHeat.Size = new System.Drawing.Size(53, 20);
            this.lblSwimmersHeat.TabIndex = 37;
            this.lblSwimmersHeat.Text = "Heat:";
            // 
            // txtSwimmersName
            // 
            this.txtSwimmersName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSwimmersName.Enabled = false;
            this.txtSwimmersName.Location = new System.Drawing.Point(83, 78);
            this.txtSwimmersName.Name = "txtSwimmersName";
            this.txtSwimmersName.ReadOnly = true;
            this.txtSwimmersName.Size = new System.Drawing.Size(125, 20);
            this.txtSwimmersName.TabIndex = 31;
            this.txtSwimmersName.TabStop = false;
            this.txtSwimmersName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSwimmersTime
            // 
            this.txtSwimmersTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSwimmersTime.BackColor = System.Drawing.SystemColors.Control;
            this.txtSwimmersTime.Enabled = false;
            this.txtSwimmersTime.Location = new System.Drawing.Point(83, 173);
            this.txtSwimmersTime.Name = "txtSwimmersTime";
            this.txtSwimmersTime.ReadOnly = true;
            this.txtSwimmersTime.Size = new System.Drawing.Size(125, 20);
            this.txtSwimmersTime.TabIndex = 35;
            this.txtSwimmersTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSwimmersHeat
            // 
            this.txtSwimmersHeat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSwimmersHeat.BackColor = System.Drawing.SystemColors.Control;
            this.txtSwimmersHeat.Enabled = false;
            this.txtSwimmersHeat.Location = new System.Drawing.Point(83, 110);
            this.txtSwimmersHeat.Name = "txtSwimmersHeat";
            this.txtSwimmersHeat.ReadOnly = true;
            this.txtSwimmersHeat.Size = new System.Drawing.Size(125, 20);
            this.txtSwimmersHeat.TabIndex = 33;
            this.txtSwimmersHeat.TabStop = false;
            this.txtSwimmersHeat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSwimmersLane
            // 
            this.lblSwimmersLane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSwimmersLane.AutoSize = true;
            this.lblSwimmersLane.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmersLane.Location = new System.Drawing.Point(16, 140);
            this.lblSwimmersLane.Name = "lblSwimmersLane";
            this.lblSwimmersLane.Size = new System.Drawing.Size(54, 20);
            this.lblSwimmersLane.TabIndex = 36;
            this.lblSwimmersLane.Text = "Lane:";
            // 
            // lblSwimmersName
            // 
            this.lblSwimmersName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSwimmersName.AutoSize = true;
            this.lblSwimmersName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmersName.Location = new System.Drawing.Point(16, 76);
            this.lblSwimmersName.Name = "lblSwimmersName";
            this.lblSwimmersName.Size = new System.Drawing.Size(60, 20);
            this.lblSwimmersName.TabIndex = 32;
            this.lblSwimmersName.Text = "Name:";
            // 
            // txtSwimmersID
            // 
            this.txtSwimmersID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSwimmersID.Enabled = false;
            this.txtSwimmersID.Location = new System.Drawing.Point(83, 46);
            this.txtSwimmersID.Name = "txtSwimmersID";
            this.txtSwimmersID.ReadOnly = true;
            this.txtSwimmersID.Size = new System.Drawing.Size(125, 20);
            this.txtSwimmersID.TabIndex = 30;
            this.txtSwimmersID.TabStop = false;
            this.txtSwimmersID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtSwimmersLane
            // 
            this.txtSwimmersLane.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.txtSwimmersLane.BackColor = System.Drawing.SystemColors.Control;
            this.txtSwimmersLane.Enabled = false;
            this.txtSwimmersLane.Location = new System.Drawing.Point(83, 142);
            this.txtSwimmersLane.Name = "txtSwimmersLane";
            this.txtSwimmersLane.ReadOnly = true;
            this.txtSwimmersLane.Size = new System.Drawing.Size(125, 20);
            this.txtSwimmersLane.TabIndex = 34;
            this.txtSwimmersLane.TabStop = false;
            this.txtSwimmersLane.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSwimmersID
            // 
            this.lblSwimmersID.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblSwimmersID.AutoSize = true;
            this.lblSwimmersID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSwimmersID.Location = new System.Drawing.Point(18, 46);
            this.lblSwimmersID.Name = "lblSwimmersID";
            this.lblSwimmersID.Size = new System.Drawing.Size(29, 18);
            this.lblSwimmersID.TabIndex = 29;
            this.lblSwimmersID.Text = "ID:";
            // 
            // pnlEventData
            // 
            this.pnlEventData.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pnlEventData.Controls.Add(this.lblEventSeeded);
            this.pnlEventData.Controls.Add(this.lblStroke);
            this.pnlEventData.Controls.Add(this.pnlStroke);
            this.pnlEventData.Controls.Add(this.pnlDistance);
            this.pnlEventData.Controls.Add(this.lblDistance);
            this.pnlEventData.Controls.Add(this.lblEventTitle);
            this.pnlEventData.Location = new System.Drawing.Point(408, 12);
            this.pnlEventData.Name = "pnlEventData";
            this.pnlEventData.Size = new System.Drawing.Size(196, 238);
            this.pnlEventData.TabIndex = 0;
            this.pnlEventData.TabStop = true;
            // 
            // lblEventSeeded
            // 
            this.lblEventSeeded.AutoSize = true;
            this.lblEventSeeded.Location = new System.Drawing.Point(21, 173);
            this.lblEventSeeded.Name = "lblEventSeeded";
            this.lblEventSeeded.Size = new System.Drawing.Size(61, 13);
            this.lblEventSeeded.TabIndex = 24;
            this.lblEventSeeded.Text = "NotSeeded";
            // 
            // lblStroke
            // 
            this.lblStroke.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblStroke.AutoSize = true;
            this.lblStroke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStroke.Location = new System.Drawing.Point(-147, 210);
            this.lblStroke.Name = "lblStroke";
            this.lblStroke.Size = new System.Drawing.Size(50, 16);
            this.lblStroke.TabIndex = 23;
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
            this.pnlStroke.Location = new System.Drawing.Point(11, 46);
            this.pnlStroke.Name = "pnlStroke";
            this.pnlStroke.Size = new System.Drawing.Size(91, 116);
            this.pnlStroke.TabIndex = 1;
            this.pnlStroke.TabStop = true;
            // 
            // rbtIndMedley
            // 
            this.rbtIndMedley.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbtIndMedley.AutoSize = true;
            this.rbtIndMedley.Location = new System.Drawing.Point(152, 4);
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
            this.rbtFreeStyle.Location = new System.Drawing.Point(4, 78);
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
            this.rbtButterfly.Location = new System.Drawing.Point(4, 55);
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
            this.rbtBreaststroke.Location = new System.Drawing.Point(4, 32);
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
            this.rbtBackstroke.Location = new System.Drawing.Point(4, 9);
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
            this.pnlDistance.Location = new System.Drawing.Point(108, 46);
            this.pnlDistance.Name = "pnlDistance";
            this.pnlDistance.Size = new System.Drawing.Size(72, 181);
            this.pnlDistance.TabIndex = 2;
            this.pnlDistance.TabStop = true;
            // 
            // rbt_1500
            // 
            this.rbt_1500.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.rbt_1500.AutoSize = true;
            this.rbt_1500.Location = new System.Drawing.Point(12, 125);
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
            this.rbt_800.Location = new System.Drawing.Point(12, 102);
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
            this.rbt_400.Location = new System.Drawing.Point(12, 79);
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
            this.rbt_50.Location = new System.Drawing.Point(12, 10);
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
            this.rbt_200.Location = new System.Drawing.Point(12, 56);
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
            this.rbt_100.Location = new System.Drawing.Point(12, 33);
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
            this.lblDistance.Location = new System.Drawing.Point(-147, 165);
            this.lblDistance.Name = "lblDistance";
            this.lblDistance.Size = new System.Drawing.Size(64, 16);
            this.lblDistance.TabIndex = 22;
            this.lblDistance.Text = "Distance:";
            // 
            // lblEventTitle
            // 
            this.lblEventTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lblEventTitle.AutoSize = true;
            this.lblEventTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEventTitle.Location = new System.Drawing.Point(69, 10);
            this.lblEventTitle.Name = "lblEventTitle";
            this.lblEventTitle.Size = new System.Drawing.Size(63, 24);
            this.lblEventTitle.TabIndex = 19;
            this.lblEventTitle.Text = "Event";
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(609, 325);
            this.Controls.Add(this.pnlEventData);
            this.Controls.Add(this.pnlSwimmersData);
            this.Controls.Add(this.pnlButtons);
            this.Controls.Add(this.lblSwimmers);
            this.Controls.Add(this.lsbSwimmers);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MinimumSize = new System.Drawing.Size(625, 364);
            this.Name = "EventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Event";
            this.pnlButtons.ResumeLayout(false);
            this.pnlButtons.PerformLayout();
            this.statusStripEvent.ResumeLayout(false);
            this.statusStripEvent.PerformLayout();
            this.pnlSwimmersData.ResumeLayout(false);
            this.pnlSwimmersData.PerformLayout();
            this.pnlEventData.ResumeLayout(false);
            this.pnlEventData.PerformLayout();
            this.pnlStroke.ResumeLayout(false);
            this.pnlStroke.PerformLayout();
            this.pnlDistance.ResumeLayout(false);
            this.pnlDistance.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSwimmers;
        private System.Windows.Forms.ListBox lsbSwimmers;
        private System.Windows.Forms.Panel pnlButtons;
        private System.Windows.Forms.Button btnSeedEvent;
        private System.Windows.Forms.Button btnRemoveSwimmer;
        private System.Windows.Forms.Button btnAddSwimmer;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdateEvent;
        private System.Windows.Forms.Panel pnlSwimmersData;
        private System.Windows.Forms.Panel pnlEventData;
        private System.Windows.Forms.Label lblStroke;
        private System.Windows.Forms.Panel pnlStroke;
        private System.Windows.Forms.RadioButton rbtIndMedley;
        private System.Windows.Forms.RadioButton rbtFreeStyle;
        private System.Windows.Forms.RadioButton rbtButterfly;
        private System.Windows.Forms.RadioButton rbtBreaststroke;
        private System.Windows.Forms.RadioButton rbtBackstroke;
        private System.Windows.Forms.Panel pnlDistance;
        private System.Windows.Forms.RadioButton rbt_1500;
        private System.Windows.Forms.RadioButton rbt_800;
        private System.Windows.Forms.RadioButton rbt_400;
        private System.Windows.Forms.RadioButton rbt_50;
        private System.Windows.Forms.RadioButton rbt_200;
        private System.Windows.Forms.RadioButton rbt_100;
        private System.Windows.Forms.Label lblDistance;
        private System.Windows.Forms.Label lblEventTitle;
        private System.Windows.Forms.Label lblSwimmersHeat;
        private System.Windows.Forms.TextBox txtSwimmersName;
        public System.Windows.Forms.TextBox txtSwimmersTime;
        private System.Windows.Forms.TextBox txtSwimmersHeat;
        private System.Windows.Forms.Label lblSwimmersLane;
        private System.Windows.Forms.Label lblSwimmersName;
        private System.Windows.Forms.TextBox txtSwimmersID;
        private System.Windows.Forms.TextBox txtSwimmersLane;
        private System.Windows.Forms.Label lblSwimmersID;
        private System.Windows.Forms.Label lblSwimmerTitle;
        private System.Windows.Forms.Button btnAddChangeTime;
        private System.Windows.Forms.Label lblSwimmersTime;
        private System.Windows.Forms.StatusStrip statusStripEvent;
        private System.Windows.Forms.ToolStripStatusLabel statuslblEvent;
        private System.Windows.Forms.Label lblEventSeeded;
    }
}