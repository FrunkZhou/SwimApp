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
    public partial class EventForm : Form
    {
        MainForm mainForm;
        Event selectedEvent;
        public EventForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];            
        }

        public EventForm(Event anEvent) :this()
        {
            this.selectedEvent = anEvent;
            RefreshSwimmersList();
            CheckIfSeeded();
            this.Text = mainForm.Database.SwimMeets[mainForm.lsbMeetsSwimMeets.SelectedIndex].Name + ": " + Enum.GetName(typeof(EventDistance), selectedEvent.Distance) + " " + Enum.GetName(typeof(Stroke), selectedEvent.Stroke);
            UpdateEventFields();
            CheckSwimmersIndex();
        }

        public void UpdateEventFields()
        {
            if (selectedEvent.Distance == EventDistance._50)
                rbt_50.Checked = true;
            else if (selectedEvent.Distance == EventDistance._100)
                rbt_100.Checked = true;
            else if (selectedEvent.Distance == EventDistance._200)
                rbt_200.Checked = true;
            else if (selectedEvent.Distance == EventDistance._400)
                rbt_400.Checked = true;
            else if (selectedEvent.Distance == EventDistance._800)
                rbt_800.Checked = true;
            else
                rbt_1500.Checked = true;
            if (selectedEvent.Stroke == Stroke.Backstroke)
                rbtBackstroke.Checked = true;
            else if (selectedEvent.Stroke == Stroke.Breaststroke)
                rbtBreaststroke.Checked = true;
            else if (selectedEvent.Stroke == Stroke.Butterfly)
                rbtButterfly.Checked = true;
            else if (selectedEvent.Stroke == Stroke.Freestyle)
                rbtFreeStyle.Checked = true;
            else
                rbtIndMedley.Checked = true;
        }
        public void CheckIfSeeded()
        {
            if (selectedEvent.IsSeeded)
            {
                btnAddSwimmer.Enabled = false;
                btnRemoveSwimmer.Enabled = false;
                btnAddChangeTime.Enabled = true;
                btnSeedEvent.Enabled = false;
                lblEventSeeded.Text = "Seeded";
            }
            else
            {
                btnAddSwimmer.Enabled = true;
                btnRemoveSwimmer.Enabled = true;
                btnAddChangeTime.Enabled = false;
                btnSeedEvent.Enabled = true;
                lblEventSeeded.Text = "Not seeded";
            }
        }

        public void CheckSwimmersIndex()
        {
            if (lsbSwimmers.SelectedIndex == -1)
            {
                btnSeedEvent.Enabled = false;
                btnRemoveSwimmer.Enabled = false;
            }
            else
            {
                btnSeedEvent.Enabled = true;
                btnRemoveSwimmer.Enabled = true;
            }
        }

        public void RefreshSwimmersList()
        {
            if (selectedEvent.SwimmersList == null)
            {
                return;
            }
            List<string> swimmerKeyList = new List<string>();
            foreach (Swimmer swimmer in selectedEvent.SwimmersList)
            {
                swimmerKeyList.Add(swimmer.Name);
            }
            lsbSwimmers.DataSource = null;
            lsbSwimmers.DataSource = swimmerKeyList;
        }

        private void btnUpdateEvent_Click(object sender, EventArgs e)
        {
            DialogResult confirm = MessageBox.Show($"Are you sure you want to update this event?", "Update Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                if (rbt_50.Checked)
                {
                    selectedEvent.Distance = EventDistance._50;
                }
                else if (rbt_100.Checked)
                {
                    selectedEvent.Distance = EventDistance._100;
                }
                else if (rbt_200.Checked)
                {
                    selectedEvent.Distance = EventDistance._200;
                }
                else if (rbt_400.Checked)
                {
                    selectedEvent.Distance = EventDistance._400;
                }
                else if (rbt_800.Checked)
                {
                    selectedEvent.Distance = EventDistance._800;
                }
                else
                {
                    selectedEvent.Distance = EventDistance._1500;
                }
                if (rbtBackstroke.Checked)
                {
                    selectedEvent.Stroke = Stroke.Backstroke;
                }
                else if (rbtBreaststroke.Checked)
                {
                    selectedEvent.Stroke = Stroke.Breaststroke;
                }
                else if (rbtButterfly.Checked)
                {
                    selectedEvent.Stroke = Stroke.Butterfly;
                }
                else if (rbtFreeStyle.Checked)
                {
                    selectedEvent.Stroke = Stroke.Freestyle;
                }
                else
                {
                    selectedEvent.Stroke = Stroke.Individual_Medley;
                }
                this.Text = mainForm.Database.SwimMeets[mainForm.lsbMeetsSwimMeets.SelectedIndex].Name + ": " + Enum.GetName(typeof(EventDistance), selectedEvent.Distance) + " " + Enum.GetName(typeof(Stroke), selectedEvent.Stroke);
                statuslblEvent.Text = "Event updated.";
            }
        }

        private void btnAddSwimmer_Click(object sender, EventArgs e)
        {
            if (selectedEvent.IsSeeded)
            {
                MessageBox.Show("Cannot add swimmer, this event is already seeded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SwimmersListForm swimmersListForm = new SwimmersListForm(selectedEvent, this);
            swimmersListForm.dgvSwimmers.MultiSelect = true;
            swimmersListForm.ShowDialog();
            swimmersListForm.Dispose();
        }

        private void btnRemoveSwimmer_Click(object sender, EventArgs e)
        {
            if (selectedEvent.IsSeeded)
            {
                MessageBox.Show("Cannot remove swimmer, this event is already seeded.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (lsbSwimmers.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer selected!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (selectedEvent.SwimmersList.Count == 0)
            {
                MessageBox.Show("No swimmers left to remove.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show($"Are you sure you want to remove {(lsbSwimmers.SelectedItems.Count == 1 ? "this swimmer?" : "these swimmers?")}", "Remove Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    int index = lsbSwimmers.SelectedIndex;
                    List<Swimmer> tempSwimList = new List<Swimmer>();
                    foreach (int selectedIndex in lsbSwimmers.SelectedIndices)
                    {
                        tempSwimList.Add(selectedEvent.SwimmersList[selectedIndex]);
                    }
                    foreach (Swimmer swimmer in tempSwimList)
                    {
                        selectedEvent.SwimmersList.Remove(swimmer);
                    }
                    RefreshSwimmersList();
                    lsbSwimmers.ClearSelected();
                    lsbSwimmers.SelectedIndex = (index >= selectedEvent.SwimmersList.Count ? index - 1 : index);
                }
                catch (Exception)
                {
                    statuslblEvent.Text = $"No swimmers left to remove.";
                    return;
                }
                CheckSwimmersIndex();
                statuslblEvent.Text = $"Swimmer(s) removed from event.";
            }
        }

        private void btnSeedEvent_Click(object sender, EventArgs e)
        {
            if (selectedEvent.SwimmersList.Count == 0)
            {
                MessageBox.Show("Cannot seed an event with no swimmers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult confirm = MessageBox.Show("WARNING: Seeding an event will prevent any addtional swimmers to be added or removed. Are you sure you want to seed this event?", "Seed Confirmation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
            if (confirm == DialogResult.Yes)
            {
                try
                {
                    selectedEvent.Seed(mainForm.Database.SwimMeets[mainForm.lsbMeetsSwimMeets.SelectedIndex].NumberOfLanes);
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                CheckIfSeeded();
                RefreshSwimmersList();
                statuslblEvent.Text = "Event successfully seeded.";
            }
        }

        private void lsbSwimmers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lsbSwimmers.SelectedIndex == -1)
            {
                return;
            }
            int index = lsbSwimmers.SelectedIndex;
            txtSwimmersID.Text = selectedEvent.SwimmersList[index].IdNum.ToString();
            txtSwimmersName.Text = selectedEvent.SwimmersList[index].Name;
            txtSwimmersLane.Text = selectedEvent.Swim[index].Lane == 0 ? "Not seeded" : selectedEvent.Swim[index].Lane.ToString();
            txtSwimmersHeat.Text = selectedEvent.Swim[index].Heat == 0 ? "Not seeded" : selectedEvent.Swim[index].Heat.ToString();
            if (selectedEvent.Swim[index].SwimTime.Minutes == 0 && selectedEvent.Swim[index].SwimTime.Seconds == 0 && selectedEvent.Swim[index].SwimTime.Milliseconds == 0)
            {
                txtSwimmersTime.Text = "No time entered";
            }
            else
            {
                txtSwimmersTime.Text = selectedEvent.Swim[index].SwimTime.ToString("mm\\:ss\\:ff");
            }
        }

        private void btnAddChangeTime_Click(object sender, EventArgs e)
        {
            if (lsbSwimmers.SelectedIndex == -1)
            {
                MessageBox.Show("No swimmer selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SwimTimeForm swimTimeForm = new SwimTimeForm(selectedEvent, selectedEvent.SwimmersList[lsbSwimmers.SelectedIndex], this);
            swimTimeForm.ShowDialog();
            swimTimeForm.Dispose();
        }

        private void lsbSwimmers_DoubleClick(object sender, EventArgs e)
        {
            if (lsbSwimmers.SelectedIndex == -1)
            {
                return;
            }
            Swimmer swimmer = selectedEvent.SwimmersList[lsbSwimmers.SelectedIndex];
            mainForm.tbCtrlSwim.SelectedTab = mainForm.tabSwimmers;
            mainForm.lsbSwimmersSwimmers.ClearSelected();
            mainForm.lsbSwimmersSwimmers.SelectedIndex = mainForm.Database.Swimmers.IndexOf(swimmer);
        }
    }
}
