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
    public partial class CreateEventForm : Form
    {
        SwimMeet meet;
        MainForm mainForm;
        public CreateEventForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];
        }

        public CreateEventForm(SwimMeet meet) :this()
        {
            this.meet = meet;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            rbt_100.Checked = true;
            rbtBackstroke.Checked = true;
            statuslbl.Text = "";
            this.ActiveControl = rbt_50;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            EventDistance distance;
            Stroke stroke;
            if (rbt_50.Checked)
            {
                distance = EventDistance._50;
            }
            else if (rbt_100.Checked)
            {
                distance = EventDistance._100;
            }
            else if (rbt_200.Checked)
            {
                distance = EventDistance._200;
            }
            else if (rbt_400.Checked)
            {
                distance = EventDistance._400;
            }
            else if (rbt_800.Checked)
            {
                distance = EventDistance._800;
            }
            else
            {
                distance = EventDistance._1500;
            }
            if (rbtBackstroke.Checked)
            {
                stroke = Stroke.Backstroke;       
            }
            else if (rbtBreaststroke.Checked)
            {
                stroke = Stroke.Breaststroke;
            }
            else if (rbtButterfly.Checked)
            {
                stroke = Stroke.Butterfly;
            }
            else if (rbtFreeStyle.Checked)
            {
                stroke = Stroke.Freestyle;
            }
            else
            {
                stroke = Stroke.Individual_Medley;
            }
            try
            {
                Event tempEvent = new Event(distance, stroke);
                tempEvent.Course = meet.Course;
                meet.Events.Add(tempEvent);
                statuslbl.Text = $"Event {Enum.GetName(typeof(Stroke), (int)stroke)}{Enum.GetName(typeof(EventDistance), (int)distance)} was successfully created and added to swim meet {meet.Name}.";
                mainForm.CheckSwimMeetsIndex();
                mainForm.RefreshEventsList(meet);
            }
            catch (FormatException err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
