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
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SwimForm
{
    public partial class MainForm : Form
    {
        ClubsManager clubManager;
        SwimmersManager swimManager;
        
        public SwimDatabase Database { get; set; }
        public MainForm()
        {
            InitializeComponent();
            clubManager = new ClubsManager();
            swimManager = new SwimmersManager(clubManager);
            Database = new SwimDatabase();
            CheckClubsIndex();
            CheckSwimMeetsIndex();
            CheckSwimmersCoachesIndex();
            try
            {
                LoadBin("database.bin");
            }
            catch(Exception err)
            {
                statuslblMain.Text = err.Message;
            }
        }

        public void SaveBin(string fileName)
        {
            FileStream outFile = null;
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                outFile = new FileStream(fileName, FileMode.Create, FileAccess.Write);
                bFormatter.Serialize(outFile, Database);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (outFile != null)
                    outFile.Close();
            }
        }

        public void LoadBin(string fileName)
        {
            FileStream inFile = null;
            BinaryFormatter bFormatter = new BinaryFormatter();
            try
            {
                inFile = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                Database = ((SwimDatabase)bFormatter.Deserialize(inFile));
                RefreshClubsList();
                RefreshCoaches();
                RefreshMeetsList();
                RefreshSwimmersList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (inFile != null)
                    inFile.Close();
            }
        }

        public void RefreshClubsList()
        {
            List<string> ClubsListKey = new List<string>();
            foreach (Club club in Database.Clubs)
            {
                ClubsListKey.Add(club.Name);
            }
            lsbClubsClubs.DataSource = null;
            lsbClubsClubs.DataSource = ClubsListKey;
        }

        public void RefreshSwimmersList()
        {
            List<string> SwimmersListKey = new List<string>();
            foreach (Swimmer swimmer in Database.Swimmers)
            {
                SwimmersListKey.Add(swimmer.Name);
            }
            lsbSwimmersSwimmers.DataSource = null;
            lsbSwimmersSwimmers.DataSource = SwimmersListKey;
        }

        public void RefreshCoaches()
        {
            List<string> CoachesKey = new List<string>();
            foreach (Coach coach in Database.Coaches)
            {
                CoachesKey.Add(coach.Name);
            }
            lsbSwimmersCoaches.DataSource = null;
            lsbSwimmersCoaches.DataSource = CoachesKey;
        }

        public void RefreshMeetsList()
        {
            List<string> MeetsListKey = new List<string>();
            foreach (SwimMeet meet in Database.SwimMeets)
            {
                MeetsListKey.Add(meet.Name);
            }
            lsbMeetsSwimMeets.DataSource = null;
            lsbMeetsSwimMeets.DataSource = MeetsListKey;
        }

        public void RefreshEventsList(SwimMeet meet)
        {
            List<string> EventsListKey = new List<string>();
            foreach(Event anEvent in meet.Events)
            {
                EventsListKey.Add(Enum.GetName(typeof(EventDistance), anEvent.Distance) + " " + Enum.GetName(typeof(Stroke), anEvent.Stroke));
            }
            lsbMeetsEvents.DataSource = null;
            lsbMeetsEvents.DataSource = EventsListKey;
        }

        public void RefreshClubMembersList(Club club)
        {
            List<string> ClubsSwimmersListKey = new List<string>();
            foreach (Swimmer swimmer in club.ClubMembers)
            {
                ClubsSwimmersListKey.Add(swimmer.Name);
            }
            lsbClubsSwimmers.DataSource = null;
            lsbClubsSwimmers.DataSource = ClubsSwimmersListKey;

        }

        public void RefreshClubCoaches(Club club)
        {
            List<string> ClubsCoachesKey = new List<string>();
            foreach (Coach coach in club.CoachList)
            {
                ClubsCoachesKey.Add(coach.Name);
            }
            lsbClubsCoaches.DataSource = null;
            lsbClubsCoaches.DataSource = ClubsCoachesKey;
        }

        public void RefreshSwimmersStudentsList(Coach coach)
        {
            List<string> StudentsListKey = new List<string>();
            foreach (Swimmer swimmer in coach.SwimmersList)
            {
                StudentsListKey.Add(swimmer.Name);
            }
            lsbSwimmersStudents.DataSource = null;
            lsbSwimmersStudents.DataSource = StudentsListKey;
        }

        public void CheckClubsIndex()
        {
            if (lsbClubsClubs.SelectedIndex == -1)
            {
                foreach (Control control in pnlClubsData.Controls)
                {
                    control.Enabled = false;
                }
                foreach (Control control in pnlClubsButtons.Controls)
                {
                    control.Enabled = false;
                }
                btnClubsCreateClub.Enabled = true;
            }
            else
            {
                foreach (Control control in pnlClubsData.Controls)
                {
                    control.Enabled = true;
                }
                foreach (Control control in pnlClubsButtons.Controls)
                {
                    control.Enabled = true;
                }
            }
        }

        public void CheckSwimMeetsIndex()
        {
            if (lsbMeetsSwimMeets.SelectedIndex == -1)
            {
                foreach (Control control in pnlMeetsData.Controls)
                {
                    control.Enabled = false;
                }
                foreach (Control control in pnlMeetsButtons.Controls)
                {
                    control.Enabled = false;
                }
                btnMeetsCreateSwimMeet.Enabled = true;
            }
            else
            {
                foreach (Control control in pnlMeetsData.Controls)
                {
                    control.Enabled = true;
                }
                foreach (Control control in pnlMeetsButtons.Controls)
                {
                    control.Enabled = true;
                }
            }
        }

        public void CheckSwimEventsIndex()
        {
            if (lsbMeetsEvents.SelectedIndex == -1)
            {
                btnMeetsRemoveEvent.Enabled = false;
                btnMeetsEditEvent.Enabled = false;
                btnMeetsSeed.Enabled = false;
            }
            else
            {
                btnMeetsRemoveEvent.Enabled = true;
                btnMeetsEditEvent.Enabled = true;
                btnMeetsSeed.Enabled = true;
            }
        }

        public void CheckSwimmersCoachesIndex()
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1 && lsbSwimmersCoaches.SelectedIndex == -1)
            {
                foreach (Control control in pnlSwimmersData.Controls)
                    control.Enabled = false;
                btnSwimmersUpdateSwimmer.Enabled = false;
                btnSwimmersDeleteSwimmer.Enabled = false;
            }
            else
            {
                foreach(Control control in pnlSwimmersData.Controls)
                    control.Enabled = true;
                if (lsbSwimmersCoaches.SelectedIndex != -1)
                    btnSwimmersGetBestTime.Enabled = false;
                txtSwimmersID.Enabled = false;
                btnSwimmersUpdateSwimmer.Enabled = true;
                btnSwimmersDeleteSwimmer.Enabled = true;
                txtSwimmersClubID.Enabled = false;
                txtSwimmersCoachID.Enabled = false;
            }
        }

        public void CheckSwimmersStudentsIndex()
        {
            if (lsbSwimmersStudents.SelectedIndex == -1)
                btnSwimmersRemoveStudent.Enabled = false;
            else
                btnSwimmersRemoveStudent.Enabled = true;
        }

        public void CheckClubsSwimmersIndex()
        {
            if (lsbClubsSwimmers.SelectedIndex == -1)
                btnClubsRemoveSwimmer.Enabled = false;
            else
                btnClubsRemoveSwimmer.Enabled = true;
        }

        public void CheckClubsCoachesIndex()
        {
            if (lsbClubsCoaches.SelectedIndex == -1)
                btnClubsRemoveCoach.Enabled = false;
            else
                btnClubsRemoveCoach.Enabled = true;

        }

        private void btnMainCreateClub_Click(object sender, EventArgs e)
        {
            CreateClubForm clubForm = new CreateClubForm();
            clubForm.ShowDialog();
            clubForm.Dispose();
        }

        private void btnMainCreateSwimmer_Click(object sender, EventArgs e)
        {
            CreateSwimmerForm swimmerForm = new CreateSwimmerForm();
            swimmerForm.ShowDialog();
            swimmerForm.Dispose();
        }

        private void btnCreateSwimMeet_Click(object sender, EventArgs e)
        {
            CreateSwimMeetForm swimmeetForm = new CreateSwimMeetForm();
            swimmeetForm.ShowDialog();
            swimmeetForm.Dispose();
        }

        private void btnCreateEvent_Click(object sender, EventArgs e)
        {
            CreateEventForm eventForm = new CreateEventForm();
            eventForm.ShowDialog();
            eventForm.Dispose();
        }

        private void btnLoadClubs_Click(object sender, EventArgs e)
        {
            loadFilesDialog.FileName = "Clubs.txt";
            loadFilesDialog.RestoreDirectory = true;
            loadFilesDialog.InitialDirectory = "c:\\";
            loadFilesDialog.Filter = "txt files|*.txt|All files|*.*";
            loadFilesDialog.FilterIndex = 2;
            if (loadFilesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    clubManager.Clubs = Database.Clubs;
                    clubManager.Load(loadFilesDialog.FileName, ',');
                    Database.Clubs = clubManager.Clubs;
                    statuslblMain.Text = "Clubs successfully loaded.";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshClubsList();
        }

        private void lsbClubsClubs_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1 && Database.Clubs.Count == 0)
            {
                return;
            }
            int index = lsbClubsClubs.SelectedIndex == -1 ? 0 : lsbClubsClubs.SelectedIndex;
            txtClubsID.Text = Database.Clubs[index].IdNum.ToString();
            txtClubsName.Text = Database.Clubs[index].Name;
            txtClubsStreet.Text = Database.Clubs[index].Address.Street;
            txtClubsProvince.Text = Database.Clubs[index].Address.Province;
            txtClubsCity.Text = Database.Clubs[index].Address.City;
            txtClubsPostal.Text = Database.Clubs[index].Address.PostalCode;
            txtClubsPhone.Text = Database.Clubs[index].PhoneNumber == 0 ? "" : Database.Clubs[index].PhoneNumber.ToString();
            //populate swimmers list
            RefreshClubMembersList(Database.Clubs[index]);
            //populate coaches list
            RefreshClubCoaches(Database.Clubs[index]);
            CheckClubsIndex();
            CheckClubsSwimmersIndex();
            CheckClubsCoachesIndex();
        }

        private void btnClubsAddClub_Click(object sender, EventArgs e)
        {
            CreateClubForm clubForm = new CreateClubForm();
            clubForm.ShowDialog();
            clubForm.Dispose();
        }

        private void btnClubsUpdateClub_Click(object sender, EventArgs e)
        {
            if (Database.Clubs.Count <= 0)
            {
                MessageBox.Show("No clubs to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to update this club?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (confirm == DialogResult.Yes)
            {
                int index = lsbClubsClubs.SelectedIndex;
                if (txtClubsName.Text == "")
                {
                    MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (index < 0)
                {
                    MessageBox.Show("No club selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    Database.Clubs[index].Name = txtClubsName.Text;
                    Database.Clubs[index].Address.Street = txtClubsStreet.Text;
                    Database.Clubs[index].Address.Province = txtClubsProvince.Text;
                    Database.Clubs[index].Address.City = txtClubsCity.Text;
                    Database.Clubs[index].Address.PostalCode = txtClubsPostal.Text;
                    Database.Clubs[index].PhoneNumber = txtClubsPhone.Text == "" ? 0 : Convert.ToInt64(txtClubsPhone.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                statuslblClubs.Text = "Club successfully updated.";
            }
        }

        private void btnClubsDeleteClub_Click(object sender, EventArgs e)
        {
            if (Database.Clubs.Count <= 0)
            {
                MessageBox.Show("No clubs to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbClubsClubs.SelectedIndex == -1)
            {
                MessageBox.Show("No club selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete {(lsbClubsClubs.SelectedIndices.Count == 1 ? "this club?" : "these clubs?")}", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int index = lsbClubsClubs.SelectedIndex;
                string name = Database.Clubs[index].Name;
                try
                {
                    List<Club> tempClubList = new List<Club>();
                    foreach (int selectedIndex in lsbClubsClubs.SelectedIndices)
                    {
                        tempClubList.Add(Database.Clubs[selectedIndex]);
                    }
                    foreach (Club club in tempClubList)
                    {
                        foreach (Swimmer swimmer in club.ClubMembers.ToList())
                        {
                            swimmer.Club = null;
                        }
                        foreach (Coach coach in club.CoachList.ToList())
                        {
                            coach.Club = null;
                        }
                        Database.Clubs.Remove(club);
                    }
                    RefreshClubsList();
                    lsbClubsClubs.ClearSelected();
                    lsbClubsClubs.SelectedIndex = (index >= Database.Clubs.Count ? index - 1 : index);
                    lsbClubsSwimmers.DataSource = null;
                    lsbClubsCoaches.DataSource = null;
                    CheckClubsIndex();
                }
                catch (Exception)
                {
                    statuslblClubs.Text = $"No clubs left to delete.";
                    return;
                }
                statuslblClubs.Text = $"Club(s) deleted.";
            }
        }

        private void btnClubsRemoveSwimmer_Click(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1)
            {
                MessageBox.Show("No club selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Club selectedClub = Database.Clubs[lsbClubsClubs.SelectedIndex];
            if (selectedClub.ClubMembers.Count == 0)
            {
                MessageBox.Show("No swimmers left to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbClubsSwimmers.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {(lsbClubsSwimmers.SelectedItems.Count == 1 ? "this swimmer?" : "these swimmers?")}", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {

                string name = selectedClub.ClubMembers[lsbClubsSwimmers.SelectedIndex].Name;
                try
                {
                    int index = lsbClubsSwimmers.SelectedIndex;
                    List<Swimmer> tempSwimList = new List<Swimmer>();
                    foreach (int selectedIndex in lsbClubsSwimmers.SelectedIndices)
                    {
                        tempSwimList.Add(selectedClub.ClubMembers[selectedIndex]);
                    }
                    foreach (Swimmer swimmer in tempSwimList)
                    {
                        selectedClub.RemoveSwimmer(swimmer);
                    }
                    RefreshClubMembersList(selectedClub);
                    lsbClubsSwimmers.ClearSelected();
                    lsbClubsSwimmers.SelectedIndex = (index >= selectedClub.ClubMembers.Count ? index - 1 : index);
                    int swimmerIndex = lsbSwimmersSwimmers.SelectedIndex;
                    RefreshSwimmersList();
                    lsbSwimmersSwimmers.SelectedIndex = swimmerIndex;
                }
                catch (Exception)
                {
                    statuslblClubs.Text = $"No swimmers left to remove.";
                    return;
                }
                CheckClubsSwimmersIndex();
                statuslblClubs.Text = $"Swimmer(s) removed from club.";
            }
        }

        private void btnClubsAddSwimmer_Click(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1)
            {
                MessageBox.Show("No club selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int clubsIndex = lsbClubsClubs.SelectedIndex;
            lsbClubsClubs.ClearSelected();
            lsbClubsClubs.SelectedIndex = clubsIndex;
            SwimmersListForm swimmersListForm = new SwimmersListForm(Database.Clubs[lsbClubsClubs.SelectedIndex]);
            swimmersListForm.dgvSwimmers.MultiSelect = true;
            swimmersListForm.ShowDialog();
            swimmersListForm.Dispose();
            int index = lsbSwimmersSwimmers.SelectedIndex;
            RefreshSwimmersList();
            lsbSwimmersSwimmers.SelectedIndex = index;
        }

        private void btnLoadSwimmers_Click(object sender, EventArgs e)
        {
            loadFilesDialog.RestoreDirectory = true;
            loadFilesDialog.InitialDirectory = "c:\\";
            loadFilesDialog.Filter = "txt files|*.txt|All files|*.*";
            loadFilesDialog.FilterIndex = 2;
            if (loadFilesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    swimManager.Swimmers = Database.Swimmers;
                    swimManager.Load(loadFilesDialog.FileName, ',');
                    Database.Swimmers = swimManager.Swimmers;
                    statuslblMain.Text = "Swimmers successfully loaded.";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshSwimmersList();
        }

        private void btnClubsAddCoach_Click(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1)
            {
                MessageBox.Show("No club selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int clubsIndex = lsbClubsClubs.SelectedIndex;
            lsbClubsClubs.ClearSelected();
            lsbClubsClubs.SelectedIndex = clubsIndex;
            CoachesListForm coachesListForm = new CoachesListForm(Database.Clubs[lsbClubsClubs.SelectedIndex]);
            coachesListForm.dgvCoaches.MultiSelect = true;
            coachesListForm.ShowDialog();
            coachesListForm.Dispose();
            int index = lsbSwimmersCoaches.SelectedIndex;
            RefreshCoaches();
            lsbSwimmersCoaches.SelectedIndex = index;
        }

        private void btnClubsRemoveCoach_Click(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1)
            {
                MessageBox.Show("No club selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Club selectedClub = Database.Clubs[lsbClubsClubs.SelectedIndex];
            if (selectedClub.CoachList.Count == 0)
            {
                MessageBox.Show("No coaches left to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbClubsCoaches.SelectedIndex == -1)
            {
                MessageBox.Show("No coach selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {(lsbClubsCoaches.SelectedItems.Count == 1 ? "this coach?" : "these coaches?")}", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {

                string name = selectedClub.CoachList[lsbClubsCoaches.SelectedIndex].Name;
                try
                {
                    int index = lsbClubsCoaches.SelectedIndex;
                    List<Coach> tempCoachList = new List<Coach>();
                    foreach (int selectedIndex in lsbClubsCoaches.SelectedIndices)
                    {
                        tempCoachList.Add(selectedClub.CoachList[selectedIndex]);
                    }
                    foreach (Coach coach in tempCoachList)
                    {
                        selectedClub.RemoveCoach(coach);
                    }
                    RefreshClubCoaches(selectedClub);
                    lsbClubsCoaches.ClearSelected();
                    lsbClubsCoaches.SelectedIndex = (index >= selectedClub.CoachList.Count ? index - 1 : index);
                    int coachIndex = lsbSwimmersCoaches.SelectedIndex;
                    RefreshCoaches();
                    lsbSwimmersCoaches.SelectedIndex = coachIndex;
                }
                catch (Exception)
                {
                    statuslblClubs.Text = $"No coaches left to remove.";
                    return;
                }
                CheckClubsCoachesIndex();
                statuslblClubs.Text = $"Coach(s) removed from club.";
            }
        }

        private void txtClubsPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            else
                e.Handled = true;
        }

        private void txtSwimmersPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            else
                e.Handled = true;
        }

        private void btnSwimmersCreateCoach_Click(object sender, EventArgs e)
        {
            CreateSwimmerForm swimmerForm = new CreateSwimmerForm(new CoachesListForm());
            swimmerForm.ShowDialog();
            swimmerForm.Dispose();
        }

        private void lsbSwimmersSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                return;
            }
            lsbSwimmersCoaches.SelectedIndex = -1;
            int index = lsbSwimmersSwimmers.SelectedIndex;
            //Data fields
            txtSwimmersID.Text = Database.Swimmers[index].IdNum.ToString();
            txtSwimmersName.Text = Database.Swimmers[index].Name;
            txtSwimmersStreet.Text = Database.Swimmers[index].Address.Street;
            txtSwimmersProvince.Text = Database.Swimmers[index].Address.Province;
            txtSwimmersCity.Text = Database.Swimmers[index].Address.City;
            txtSwimmersPostal.Text = Database.Swimmers[index].Address.PostalCode;
            dtPkSwimmersDoB.Value = Database.Swimmers[index].DateOfBirth;
            txtSwimmersPhone.Text = Database.Swimmers[index].PhoneNumber == 0 ? "" : Database.Swimmers[index].PhoneNumber.ToString();
            txtSwimmersClubID.Text = Database.Swimmers[index].Club?.IdNum.ToString();
            txtSwimmersClubName.Text = Database.Swimmers[index].Club?.Name;
            lblSwimmersStudents.Enabled = false;
            lsbSwimmersStudents.Enabled = false;
            txtSwimmersCoachName.Enabled = true;
            btnSwimmersRemoveCoach.Enabled = true;
            lsbSwimmersStudents.DataSource = null;
            txtSwimmersCoachID.Text = Database.Swimmers[index].Coach?.IdNum.ToString();
            lblSwimmersCoach.Enabled = true;
            lblSwimmersCoachesCredentials.Enabled = false;
            txtSwimmersCoachCredentials.Text = "";
            txtSwimmersCoachCredentials.Enabled = false;
            txtSwimmersCoachName.Text = Database.Swimmers[index].Coach?.Name;
            btnSwimmersGetBestTime.Enabled = true;
            //Buttons
            btnSwimmersAddStudent.Enabled = false;
            btnSwimmersRemoveStudent.Enabled = false;
            btnSwimmersUpdateSwimmer.Text = "Update Swimmer";
            btnSwimmersDeleteSwimmer.Text = "Delete Swimmer(s)";
            btnSwimmersChangeCoach.Enabled = true;
            txtSwimmersCoachName.Enabled = true;
            btnSwimmersChangeCoach.Enabled = true;
            btnSwimmersRemoveCoach.Enabled = true;
            CheckSwimmersCoachesIndex();
        }

        private void lsbSwimmersCoaches_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSwimmersCoaches.SelectedIndex == -1)
            {
                return;
            }
            lsbSwimmersSwimmers.SelectedIndex = -1;
            int index = lsbSwimmersCoaches.SelectedIndex;
            //data fields
            txtSwimmersID.Text = Database.Coaches[index].IdNum.ToString();
            txtSwimmersName.Text = Database.Coaches[index].Name;
            txtSwimmersStreet.Text = Database.Coaches[index].Address.Street;
            txtSwimmersProvince.Text = Database.Coaches[index].Address.Province;
            txtSwimmersCity.Text = Database.Coaches[index].Address.City;
            txtSwimmersPostal.Text = Database.Coaches[index].Address.PostalCode;
            dtPkSwimmersDoB.Value = Database.Coaches[index].DateOfBirth;
            txtSwimmersPhone.Text = Database.Coaches[index].PhoneNumber == 0 ? "" : Database.Coaches[index].PhoneNumber.ToString();
            txtSwimmersClubID.Text = Database.Coaches[index].Club?.IdNum.ToString();
            txtSwimmersClubName.Text = Database.Coaches[index].Club?.Name;
            lblSwimmersStudents.Enabled = true;
            lsbSwimmersStudents.Enabled = true;
            btnSwimmersRemoveCoach.Enabled = false;
            txtSwimmersCoachID.Text = "";
            txtSwimmersCoachCredentials.Enabled = true;
            lblSwimmersCoachesCredentials.Enabled = true;
            txtSwimmersCoachCredentials.Text = Database.Coaches[index].Credentials;
            txtSwimmersCoachName.Text = "";
            btnSwimmersGetBestTime.Enabled = false;
            //buttons
            btnSwimmersAddStudent.Enabled = true;
            btnSwimmersRemoveStudent.Enabled = true;
            btnSwimmersUpdateSwimmer.Text = "Update Coach";
            btnSwimmersDeleteSwimmer.Text = "Delete Coach(s)";
            //populate students list
            RefreshSwimmersStudentsList(Database.Coaches[index]);
            CheckSwimmersCoachesIndex();
            CheckSwimmersStudentsIndex();
            lblSwimmersCoach.Enabled = false;
            txtSwimmersCoachName.Enabled = false;
            btnSwimmersChangeCoach.Enabled = false;
            btnSwimmersRemoveCoach.Enabled = false;
        }

        private void btnSwimmersChangeCoach_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CoachesListForm coachesListForm = new CoachesListForm(Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex]);
            coachesListForm.btnAddCoach.Visible = false;
            coachesListForm.btnCreateCoach.Visible = false;
            coachesListForm.btnChangeCoach.Visible = true;
            coachesListForm.ShowDialog();
            coachesListForm.Dispose();
        }

        private void btnSwimmersAddSwimmer_Click(object sender, EventArgs e)
        {
            CreateSwimmerForm swimmerForm = new CreateSwimmerForm(new SwimmersListForm());
            swimmerForm.ShowDialog();
            swimmerForm.Dispose();
        }

        private void lsbClubsSwimmers_DoubleClick(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1 || lsbClubsSwimmers.SelectedIndex == -1)
            {
                return;
            }
            tbCtrlSwim.SelectedTab = tabSwimmers;
            Swimmer selectedSwimmer = Database.Clubs[lsbClubsClubs.SelectedIndex].ClubMembers[lsbClubsSwimmers.SelectedIndex];
            lsbSwimmersSwimmers.ClearSelected();
            lsbSwimmersSwimmers.SelectedIndex = Database.Swimmers.IndexOf(selectedSwimmer);
        }

        private void btnSwimmersUpdateSwimmer_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersCoaches.SelectedIndex == -1 && lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                if (Database.Swimmers.Count <= 0 && Database.Coaches.Count <= 0)
                {
                    MessageBox.Show("Nothing left to update!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("No swimmer or coach selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lsbSwimmersCoaches.SelectedIndex == -1)
            {
                if (Database.Swimmers.Count <= 0)
                {
                    MessageBox.Show("No swimmers to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult confirm = MessageBox.Show("Are you sure you want to update this swimmer?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (confirm == DialogResult.Yes)
                {
                    int index = lsbSwimmersSwimmers.SelectedIndex;
                    if (txtSwimmersName.Text == "")
                    {
                        MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (index < 0)
                    {
                        MessageBox.Show("No swimmer to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        Database.Swimmers[index].Name = txtSwimmersName.Text;
                        Database.Swimmers[index].Address.Street = txtSwimmersStreet.Text;
                        Database.Swimmers[index].Address.Province = txtSwimmersProvince.Text;
                        Database.Swimmers[index].Address.City = txtSwimmersCity.Text;
                        Database.Swimmers[index].Address.PostalCode = txtSwimmersPostal.Text;
                        Database.Swimmers[index].DateOfBirth = dtPkSwimmersDoB.Value;
                        Database.Swimmers[index].PhoneNumber = txtSwimmersPhone.Text == "" ? 0 : Convert.ToInt64(txtSwimmersPhone.Text);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    statuslblSwimmers.Text = "Swimmer successfully updated.";
                }
            }
            else if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                if (Database.Coaches.Count <= 0)
                {
                    MessageBox.Show("No coaches to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult confirm = MessageBox.Show("Are you sure you want to update this coach?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
                if (confirm == DialogResult.Yes)
                {
                    int index = lsbSwimmersCoaches.SelectedIndex;
                    if (txtSwimmersName.Text == "")
                    {
                        MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    if (index < 0)
                    {
                        MessageBox.Show("No coach to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    try
                    {
                        Database.Coaches[index].Name = txtSwimmersName.Text;
                        Database.Coaches[index].Address.Street = txtSwimmersStreet.Text;
                        Database.Coaches[index].Address.Province = txtSwimmersProvince.Text;
                        Database.Coaches[index].Address.City = txtSwimmersCity.Text;
                        Database.Coaches[index].Address.PostalCode = txtSwimmersPostal.Text;
                        Database.Coaches[index].DateOfBirth = dtPkSwimmersDoB.Value;
                        Database.Coaches[index].Credentials = txtSwimmersCoachCredentials.Text;
                        Database.Coaches[index].PhoneNumber = txtSwimmersPhone.Text == "" ? 0 : Convert.ToInt64(txtSwimmersPhone.Text);
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    statuslblSwimmers.Text = "Coach successfully updated.";
                }
            }
            
        }

        private void btnSwimmersDeleteSwimmer_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersCoaches.SelectedIndex == -1 && lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                if (Database.Swimmers.Count <= 0 && Database.Coaches.Count <= 0)
                {
                    MessageBox.Show("Nothing left to delete!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                MessageBox.Show("No swimmer or coach selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lsbSwimmersCoaches.SelectedIndex == -1)
            {
                if (Database.Swimmers.Count <= 0)
                {
                    MessageBox.Show("No swimmers to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete {(lsbSwimmersSwimmers.SelectedIndices.Count == 1 ? "this swimmer?" : "these swimmers?")}", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        int index = lsbSwimmersSwimmers.SelectedIndex;
                        List<Swimmer> tempSwimList = new List<Swimmer>();
                        foreach (int selectedIndex in lsbSwimmersSwimmers.SelectedIndices)
                        {
                            tempSwimList.Add(Database.Swimmers[selectedIndex]);
                        }
                        foreach (Swimmer swimmer in tempSwimList)
                        {
                            swimmer.Club?.RemoveSwimmer(swimmer);
                            swimmer.Coach?.RemoveSwimmer(swimmer);
                            Database.Swimmers.Remove(swimmer);
                        }
                        RefreshSwimmersList();
                        RefreshClubsList();
                        lsbSwimmersSwimmers.ClearSelected();
                        lsbSwimmersSwimmers.SelectedIndex = (index >= Database.Swimmers.Count ? index - 1 : index);
                    }
                    catch (Exception)
                    {
                        statuslblSwimmers.Text = $"No swimmers left to delete.";
                        return;
                    }
                    statuslblSwimmers.Text = $"Swimmer(s) deleted.";
                    CheckSwimmersCoachesIndex();
                }
            }
            else if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                if (Database.Coaches.Count <= 0)
                {
                    MessageBox.Show("No coaches to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently delete {(lsbSwimmersCoaches.SelectedIndices.Count == 1 ? "this coach?" : "these coaches?")}", "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    int index = lsbSwimmersCoaches.SelectedIndex;
                    Coach delCoach = Database.Coaches[index];
                    try
                    {
                        List<Coach> tempCoachList = new List<Coach>();
                        foreach (int selectedIndex in lsbSwimmersCoaches.SelectedIndices)
                        {
                            tempCoachList.Add(Database.Coaches[selectedIndex]);
                        }
                        foreach (Coach coach in tempCoachList)
                        {
                            coach.Club?.RemoveCoach(coach);
                            foreach (Swimmer swimmer in coach.SwimmersList.ToList())
                            {
                                swimmer.Coach = null;
                            }
                            Database.Coaches.Remove(coach);
                        }
                        RefreshCoaches();
                        RefreshClubsList();
                        lsbSwimmersStudents.DataSource = null;
                        lsbSwimmersCoaches.ClearSelected();
                        lsbSwimmersCoaches.SelectedIndex = (index >= Database.Coaches.Count ? index - 1 : index);
                    }
                    catch (Exception)
                    {
                        statuslblSwimmers.Text = $"No coaches left to delete.";
                        return;
                    }
                    statuslblSwimmers.Text = $"Coach(s) deleted.";
                }
                CheckSwimmersCoachesIndex();
            }
        }

        private void btnSwimmersChangeClub_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnSwimmersAddStudent_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersCoaches.SelectedIndex == -1)
            {
                MessageBox.Show("No coach selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int coachIndex = lsbSwimmersCoaches.SelectedIndex;
            lsbSwimmersCoaches.ClearSelected();
            lsbSwimmersCoaches.SelectedIndex = coachIndex;
            SwimmersListForm swimmersListForm = new SwimmersListForm(Database.Coaches[lsbSwimmersCoaches.SelectedIndex]);
            swimmersListForm.btnAddSwimmer.Visible = false;
            swimmersListForm.btnCreateSwimmer.Visible = false;
            swimmersListForm.btnAddStudent.Visible = true;
            swimmersListForm.dgvSwimmers.MultiSelect = true;
            swimmersListForm.ShowDialog();
            swimmersListForm.Dispose();
        }

        private void btnSwimmersRemoveStudent_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersCoaches.SelectedIndex == -1)
            {
                MessageBox.Show("No coach selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Coach selectedCoach = Database.Coaches[lsbSwimmersCoaches.SelectedIndex];
            if (selectedCoach.SwimmersList.Count == 0)
            {
                MessageBox.Show("No students left to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbSwimmersStudents.SelectedIndex == -1)
            {
                MessageBox.Show("No students selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {(lsbSwimmersStudents.SelectedItems.Count == 1 ? "this student?" : "these students?")}", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int index = lsbSwimmersStudents.SelectedIndex;
                    List<Swimmer> tempSwimList = new List<Swimmer>();
                    foreach (int selectedIndex in lsbSwimmersStudents.SelectedIndices)
                    {
                        tempSwimList.Add(selectedCoach.SwimmersList[selectedIndex]);
                    }
                    foreach (Swimmer swimmer in tempSwimList)
                    {
                        selectedCoach.RemoveSwimmer(swimmer);
                    }
                    RefreshSwimmersStudentsList(selectedCoach);
                    lsbSwimmersStudents.ClearSelected();
                    lsbSwimmersStudents.SelectedIndex = (index >= selectedCoach.SwimmersList.Count ? index - 1 : index);
                }
                catch (Exception)
                {
                    statuslblSwimmers.Text = $"No students left to remove.";
                    return;
                }
                CheckSwimmersStudentsIndex();
                statuslblSwimmers.Text = $"Student(s) removed from coach.";

            }
        }

        private void lsbClubsCoaches_DoubleClick(object sender, EventArgs e)
        {
            if (lsbClubsClubs.SelectedIndex == -1 || lsbClubsCoaches.SelectedIndex == -1)
            {
                return;
            }
            tbCtrlSwim.SelectedTab = tabSwimmers;
            Coach selectedCoach = Database.Clubs[lsbClubsClubs.SelectedIndex].CoachList[lsbClubsCoaches.SelectedIndex];
            lsbSwimmersCoaches.ClearSelected();
            lsbSwimmersCoaches.SelectedIndex = Database.Coaches.IndexOf(selectedCoach);
        }

        private void lsbSwimmersStudents_DoubleClick(object sender, EventArgs e)
        {
            if (lsbSwimmersCoaches.SelectedIndex == -1 || lsbSwimmersStudents.SelectedIndex == -1)
            {
                return;
            }
            Swimmer selectedSwimmer = Database.Coaches[lsbSwimmersCoaches.SelectedIndex].SwimmersList[lsbSwimmersStudents.SelectedIndex];
            lsbSwimmersSwimmers.SelectedIndex = Database.Swimmers.IndexOf(selectedSwimmer);
        }

        private void txtSwimmersCoachName_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                return;
            }
            Coach selectedCoach = Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Coach;
            if (selectedCoach != null)
            {
                lsbSwimmersCoaches.ClearSelected();
                lsbSwimmersCoaches.SelectedIndex = Database.Coaches.IndexOf(selectedCoach);
            }
        }

        private void txtSwimmersClubName_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1 && lsbSwimmersCoaches.SelectedIndex == -1)
            {
                return;
            }
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                Club selectedClub = Database.Coaches[lsbSwimmersCoaches.SelectedIndex].Club;
                if (selectedClub != null)
                {
                    tbCtrlSwim.SelectedTab = tabClubs;
                    lsbClubsClubs.ClearSelected();
                    lsbClubsClubs.SelectedIndex = Database.Clubs.IndexOf(selectedClub);
                }
            }
            else
            {
                Club selectedClub = Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Club;
                if (selectedClub != null)
                {
                    tbCtrlSwim.SelectedTab = tabClubs;
                    lsbClubsClubs.ClearSelected();
                    lsbClubsClubs.SelectedIndex = Database.Clubs.IndexOf(selectedClub);
                }
            }
        }

        private void btnSwimmersRemoveCoach_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            Coach coach = Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Coach;
            if (coach == null) 
            {
                MessageBox.Show($"Swimmer {Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Name} has no coach assigned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to remove this coach?", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int index = lsbSwimmersSwimmers.SelectedIndex;
                try
                {
                    Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Coach = null;
                    RefreshSwimmersList();
                    lsbSwimmersSwimmers.SelectedIndex = index;
                }
                catch (Exception)
                {
                    statuslblSwimmers.Text = $"Something went wrong...";
                    return;
                }
                statuslblSwimmers.Text = $"Coach {coach.Name} removed.";
            }
        }

        private void btnSwimmersRemoveClub_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1 && lsbSwimmersCoaches.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer or coach selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                Club club = Database.Coaches[lsbSwimmersCoaches.SelectedIndex].Club;
                if (club == null)
                {
                    MessageBox.Show($"Coach {Database.Coaches[lsbSwimmersCoaches.SelectedIndex].Name} has no club assigned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult confirm = MessageBox.Show("Are you sure you want to remove this club?", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    int index = lsbSwimmersCoaches.SelectedIndex;
                    try
                    {
                        Database.Coaches[lsbSwimmersCoaches.SelectedIndex].Club = null;
                        RefreshClubCoaches(club);
                        RefreshCoaches();
                        lsbSwimmersCoaches.ClearSelected();
                        lsbSwimmersCoaches.SelectedIndex = index;
                    }
                    catch (Exception)
                    {
                        statuslblSwimmers.Text = $"Something went wrong...";
                        return;
                    }
                    statuslblSwimmers.Text = $"Club {club.Name} removed.";
                }
            }
            if (lsbSwimmersCoaches.SelectedIndex == -1)
            {
                Club club = Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Club;
                if (club == null)
                {
                    MessageBox.Show($"Swimmer {Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Name} has no club assigned!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DialogResult confirm = MessageBox.Show("Are you sure you want to remove this club", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (confirm == DialogResult.Yes)
                {
                    int index = lsbSwimmersSwimmers.SelectedIndex;
                    try
                    {
                        Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex].Club = null;
                        RefreshClubMembersList(club);
                        RefreshSwimmersList();
                        lsbSwimmersSwimmers.ClearSelected();
                        lsbSwimmersSwimmers.SelectedIndex = index;
                    }
                    catch (Exception)
                    {
                        statuslblSwimmers.Text = $"Something went wrong...";
                        return;
                    }
                    statuslblSwimmers.Text = $"Club {club.Name} removed.";
                }
            }
        }

        private void btnMeetsAddSwimMeet_Click(object sender, EventArgs e)
        {
            CreateSwimMeetForm swimMeetForm = new CreateSwimMeetForm();
            swimMeetForm.ShowDialog();
            swimMeetForm.Dispose();
        }

        private void lsbMeetsSwimMeets_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbMeetsSwimMeets.SelectedIndex == -1 && Database.SwimMeets.Count == 0)
            {
                return;
            }
            int index = lsbMeetsSwimMeets.SelectedIndex == -1 ? 0 : lsbMeetsSwimMeets.SelectedIndex;
            txtMeetsName.Text = Database.SwimMeets[index].Name;
            if (Database.SwimMeets[index].Course == PoolType.LCM)
            {
                rbtMeetsLCM.Checked = true;
            }
            else if (Database.SwimMeets[index].Course == PoolType.SCM)
            {
                rbtMeetsSCM.Checked = true;
            }
            else
            {
                rbtMeetsSCY.Checked = true;
            }
            dtPkMeetsStart.Value = Database.SwimMeets[index].StartDate;
            dtPkMeetsEnd.Value = Database.SwimMeets[index].EndDate;
            txtMeetsLanes.Text = Database.SwimMeets[index].NumberOfLanes.ToString();
            //populate events list
            RefreshEventsList(Database.SwimMeets[index]);
            CheckSwimMeetsIndex();
            CheckSwimEventsIndex();
        }

        private void btnMeetsUpdateSwimMeet_Click(object sender, EventArgs e)
        {
            if (Database.SwimMeets.Count <= 0)
            {
                MessageBox.Show("No swim meets to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show("Are you sure you want to update this swim meet?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Exclamation);
            if (confirm == DialogResult.Yes)
            {
                int index = lsbMeetsSwimMeets.SelectedIndex;
                if (txtMeetsName.Text == "")
                {
                    MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (index < 0)
                {
                    MessageBox.Show("No swim meet selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    Database.SwimMeets[index].Name = txtMeetsName.Text;
                    if (Database.SwimMeets[index].Course == PoolType.LCM)
                    {
                        Database.SwimMeets[index].Course = PoolType.LCM;
                    }
                    else if (Database.SwimMeets[index].Course == PoolType.SCM)
                    {
                        Database.SwimMeets[index].Course = PoolType.SCM;
                    }
                    else
                    {
                        Database.SwimMeets[index].Course = PoolType.SCY;
                    }
                    Database.SwimMeets[index].StartDate = dtPkMeetsStart.Value;
                    Database.SwimMeets[index].EndDate = dtPkMeetsEnd.Value;
                    //Re-adjusting course for each event in meet (for besttime calculations)
                    foreach (Event anEvent in Database.SwimMeets[index].Events)
                    {
                        anEvent.Course = Database.SwimMeets[index].Course;
                    }
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                statuslblMeets.Text = "Swim meet successfully updated.";
            }
        }

        private void btnMeetsDeleteSwimMeet_Click(object sender, EventArgs e)
        {
            if (Database.SwimMeets.Count <= 0)
            {
                MessageBox.Show("No swim meets to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbMeetsSwimMeets.SelectedIndex == -1)
            {
                MessageBox.Show("No swim meet selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"WARNING: Deleting a swim meet also permanently removes all associated events and their records.\n" +
                                                    $"Are you sure you want to permanently delete {(lsbMeetsSwimMeets.SelectedIndices.Count == 1 ? "this swim meet?" : "these swim meets?")}", 
                                                    "Delete Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                int index = lsbMeetsSwimMeets.SelectedIndex;
                try
                {
                    List<SwimMeet> tempMeetList = new List<SwimMeet>();
                    foreach (int selectedIndex in lsbMeetsSwimMeets.SelectedIndices)
                    {
                        tempMeetList.Add(Database.SwimMeets[selectedIndex]);
                    }
                    foreach (SwimMeet meet in tempMeetList)
                    {
                        //necessary to actually remove all events?
                        meet.Events.Clear();
                        Database.SwimMeets.Remove(Database.SwimMeets[index]);
                    }
                    RefreshMeetsList();
                    lsbMeetsEvents.DataSource = null;
                }
                catch (Exception)
                {
                    statuslblMeets.Text = $"No swim meets left to delete.";
                    return;
                }
                CheckSwimMeetsIndex();
                statuslblMeets.Text = $"Swim meet(s) deleted.";
            }
        }

        private void btnMeetsAddEvent_Click(object sender, EventArgs e)
        { 
            if (lsbMeetsSwimMeets.SelectedIndex == -1)
            {
                MessageBox.Show("No swim meet selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int meetsIndex = lsbMeetsSwimMeets.SelectedIndex;
            lsbMeetsSwimMeets.ClearSelected();
            lsbMeetsSwimMeets.SelectedIndex = meetsIndex;
            CreateEventForm eventForm = new CreateEventForm(Database.SwimMeets[lsbMeetsSwimMeets.SelectedIndex]);
            eventForm.ShowDialog();
            eventForm.Dispose();
        }

        private void btnMeetsRemoveEvent_Click(object sender, EventArgs e)
        {
            if (lsbMeetsSwimMeets.SelectedIndex == -1)
            {
                MessageBox.Show("No swim meet selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SwimMeet selectedMeet = Database.SwimMeets[lsbMeetsSwimMeets.SelectedIndex];
            if (selectedMeet.Events.Count == 0)
            {
                MessageBox.Show("No events left to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbMeetsEvents.SelectedIndex == -1)
            {
                MessageBox.Show("No events selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"Are you sure you want to permanently remove {(lsbMeetsEvents.SelectedItems.Count == 1 ? "this event?" : "these events?")}", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int index = lsbMeetsEvents.SelectedIndex;
                    List<Event> tempEventList = new List<Event>();
                    foreach (int selectedIndex in lsbMeetsEvents.SelectedIndices)
                    {
                        tempEventList.Add(selectedMeet.Events[selectedIndex]);
                    }
                    foreach (Event anEvent in tempEventList)
                    {
                        selectedMeet.Events.Remove(anEvent);
                    }
                    RefreshEventsList(selectedMeet);
                    lsbMeetsEvents.ClearSelected();
                    lsbMeetsEvents.SelectedIndex = (index >= selectedMeet.Events.Count ? index - 1 : index);
                }
                catch (Exception)
                {
                    statuslblMeets.Text = $"No events left to remove.";
                    return;
                }
                statuslblMeets.Text = $"Event(s) removed from swim meet.";
            }
            CheckSwimEventsIndex();
        }

        private void btnMeetsSeed_Click(object sender, EventArgs e)
        {
            if (lsbMeetsSwimMeets.SelectedIndex == -1)
            {
                MessageBox.Show("No swim meet selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"WARNING: Seeding an event will prevent any addtional swimmers to be added or removed. Are you sure you want to seed all events?", "Seed Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    Database.SwimMeets[lsbMeetsSwimMeets.SelectedIndex].Seed();
                }
                catch (Exception)
                {
                    statuslblMeets.Text = $"Something wrong occurred...";
                    return;
                }
                statuslblMeets.Text = $"All events for swim meet {Database.SwimMeets[lsbMeetsSwimMeets.SelectedIndex].Name} seeded.";
            }
        }

        private void btnMeetsEditEvent_Click(object sender, EventArgs e)
        {
            if (lsbMeetsSwimMeets.SelectedIndex == -1)
            {
                MessageBox.Show("No swim meet selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbMeetsEvents.SelectedIndex == -1)
            {
                MessageBox.Show("No event selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EventForm eventForm = new EventForm(Database.SwimMeets[lsbMeetsSwimMeets.SelectedIndex].Events[lsbMeetsEvents.SelectedIndex]);
            eventForm.ShowDialog();
            eventForm.Dispose();
        }

        private void btnSwimmersGetBestTime_Click(object sender, EventArgs e)
        {
            if (lsbSwimmersSwimmers.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BestTimeForm bestTimeForm = new BestTimeForm(Database.Swimmers[lsbSwimmersSwimmers.SelectedIndex]);
            bestTimeForm.ShowDialog();
            bestTimeForm.Dispose();
        }

        private void lsbMeetsEvents_DoubleClick(object sender, EventArgs e)
        {
            if (lsbMeetsSwimMeets.SelectedIndex == -1 || lsbMeetsEvents.SelectedIndex == -1)
            {
                return;
            }
            EventForm eventForm = new EventForm(Database.SwimMeets[lsbMeetsSwimMeets.SelectedIndex].Events[lsbMeetsEvents.SelectedIndex]);
            eventForm.ShowDialog();
            eventForm.Dispose();
        }

        private void btnSaveClubs_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnLoadSwimMeets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnSaveSwimMeets_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnSaveSwimmers_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnLoadCoaches_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnSaveCoaches_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature coming in 1.2.0.");
        }

        private void btnExportBinFile_Click(object sender, EventArgs e)
        {
            loadFilesDialog.RestoreDirectory = true;
            loadFilesDialog.FileName = "database.bin";
            loadFilesDialog.InitialDirectory = "c:\\";
            loadFilesDialog.Filter = "bin files|*.bin|All files|*.*";
            loadFilesDialog.FilterIndex = 1;
            if (loadFilesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    LoadBin(loadFilesDialog.FileName);
                    statuslblMain.Text = "Binary file successfully loaded.";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnImportBinFile_Click(object sender, EventArgs e)
        {
            saveFilesDialog.RestoreDirectory = true;
            saveFilesDialog.FileName = "database.bin";
            saveFilesDialog.InitialDirectory = "c:\\";
            saveFilesDialog.Filter = "bin files (*.bin)|*.bin|All files (*.*)|*.*";
            saveFilesDialog.FilterIndex = 1;
            if (saveFilesDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    SaveBin(saveFilesDialog.FileName);
                    statuslblMain.Text = "Binary file successfully saved.";
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnSaveProgress_Click(object sender, EventArgs e)
        {
            SaveBin("database.bin");
            statuslblMain.Text = "Progress successfully saved";
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Would you like to save all your changes?", "Close Application Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                btnSaveProgress_Click(sender, e);
                MessageBox.Show("Saved.", "Save confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
