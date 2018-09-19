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
    public partial class CoachesListForm : Form
    {
        MainForm mainForm;
        Club club;
        Swimmer swimmer;
        public CoachesListForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];
            RefreshCoaches();
        }

        public CoachesListForm(Club club) : this()
        {
            this.club = club;
        }

        public CoachesListForm(Swimmer swimmer) :this()
        {
            this.swimmer = swimmer;
        }

        public void RefreshCoaches()
        {
            dgvCoaches.DataSource = null;
            dgvCoaches.DataSource = mainForm.Database.Coaches;
            dgvCoaches.Columns["IdNum"].DisplayIndex = 0;
            dgvCoaches.Columns["IdNum"].Width = 40;
            dgvCoaches.Columns["Name"].DisplayIndex = 1;
            dgvCoaches.Columns["Name"].Width = 80;
            dgvCoaches.Columns["Club"].DisplayIndex = 2;
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            if (dgvCoaches.SelectedRows.Count < 1)
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                foreach (DataGridViewRow row in dgvCoaches.SelectedRows)
                {
                    club.AddCoach(mainForm.Database.Coaches[row.Index]);
                }
                RefreshCoaches();
                mainForm.RefreshClubCoaches(club);
                statuslbl.Text = $"Coach(s) added to club.";
            }
            catch (Exception err)
            {
                RefreshCoaches();
                mainForm.RefreshClubCoaches(club);
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            mainForm.CheckClubsCoachesIndex();
        }

        private void btnCreateCoach_Click(object sender, EventArgs e)
        {
            CreateSwimmerForm swimmerForm = new CreateSwimmerForm(this);
            swimmerForm.StartPosition = FormStartPosition.Manual;
            swimmerForm.Location = new System.Drawing.Point(this.Location.X + this.Size.Width, this.Location.Y);
            swimmerForm.ShowDialog();
            swimmerForm.Dispose();
        }

        private void btnChangeCoach_Click(object sender, EventArgs e)
        {
            if (dgvCoaches.SelectedRows.Count != 1)
            {
                MessageBox.Show("No row selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                string name = mainForm.Database.Coaches[dgvCoaches.SelectedRows[0].Index].Name;
                swimmer.AddCoach(mainForm.Database.Coaches[dgvCoaches.SelectedRows[0].Index]);
                mainForm.RefreshSwimmersList();
                statuslbl.Text = $"Coach {name} added to swimmer.";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
