using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimModel;

namespace SwimForm
{
    public partial class SwimmersListForm : Form
    {
        MainForm mainForm;
        Club club;
        Coach coach;
        Event selectedEvent;
        EventForm parentEventForm;
        public SwimmersListForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];
            RefreshSwimmers();
        }
        
        public SwimmersListForm(Club club) : this()
        {
            this.club = club;
        }

        public SwimmersListForm(Coach coach) :this()
        {
            this.coach = coach;
        }

        public SwimmersListForm(Event anEvent, EventForm parent) :this()
        {
            this.selectedEvent = anEvent;
            this.parentEventForm = parent;
        }

        public void RefreshSwimmers()
        {
            dgvSwimmers.DataSource = null;
            dgvSwimmers.DataSource = mainForm.Database.Swimmers;
            dgvSwimmers.Columns["IdNum"].DisplayIndex = 0;
            dgvSwimmers.Columns["IdNum"].Width = 40;
            dgvSwimmers.Columns["Name"].DisplayIndex = 1;
            dgvSwimmers.Columns["Name"].Width = 80;
        }

        private void btnCreateSwimmer_Click(object sender, EventArgs e)
        {
            CreateSwimmerForm swimmerForm = new CreateSwimmerForm(this);
            swimmerForm.StartPosition = FormStartPosition.Manual;
            swimmerForm.Location = new Point(this.Location.X + this.Size.Width, this.Location.Y);
            swimmerForm.ShowDialog();
            swimmerForm.Dispose();
        }

        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {            
            if (selectedEvent == null)
            {
                if (dgvSwimmers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    foreach (DataGridViewRow row in dgvSwimmers.SelectedRows)
                    {
                        club.AddSwimmer(mainForm.Database.Swimmers[row.Index]);
                    }
                    RefreshSwimmers();
                    mainForm.RefreshClubMembersList(club);
                    mainForm.CheckClubsSwimmersIndex();
                    statuslbl.Text = $"Swimmer(s) added to Club.";
                }
                catch (Exception err)
                {
                    RefreshSwimmers();
                    mainForm.RefreshClubMembersList(club);
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (club == null)
            {
                if (dgvSwimmers.SelectedRows.Count < 1)
                {
                    MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    foreach (DataGridViewRow row in dgvSwimmers.SelectedRows)
                    {
                        selectedEvent.AddSwimmer(mainForm.Database.Swimmers[row.Index]);
                    }
                    parentEventForm.RefreshSwimmersList();
                    
                    statuslbl.Text = $"Swimmer(s) added to Club.";
                }
                catch (Exception err)
                {
                    parentEventForm.RefreshSwimmersList();
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                parentEventForm.CheckSwimmersIndex();
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            if (dgvSwimmers.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                foreach (DataGridViewRow row in dgvSwimmers.SelectedRows)
                {
                    coach.AddSwimmer(mainForm.Database.Swimmers[row.Index]);
                }
                mainForm.RefreshCoaches();
                statuslbl.Text = $"Swimmer(s) added to coach.";
            }
            catch (Exception err)
            {
                mainForm.RefreshCoaches();
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mainForm.CheckSwimMeetsIndex();
        }
    }
}
