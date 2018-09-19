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
    public partial class SwimTimeForm : Form
    {
        Event selectedEvent;
        Swimmer swimmer;
        EventForm parentForm;
        public SwimTimeForm()
        {
            InitializeComponent();
        }

        public SwimTimeForm(Event selectedEvent, Swimmer swimmer, EventForm form) :this()
        {
            this.selectedEvent = selectedEvent;
            this.swimmer = swimmer;
            this.parentForm = form;
        }

        private void txtMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            else if ((char.IsDigit(e.KeyChar) && txtMin.Text.Length <= 1) || txtMin.SelectionLength > 0)
                return;
            else
                e.Handled = true;
        }

        private void txtSec_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            else if ((char.IsDigit(e.KeyChar) && txtSec.Text.Length <= 1) || txtSec.SelectionLength > 0)
                return;
            else
                e.Handled = true;
        }

        private void txtMilli_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            else if ((char.IsDigit(e.KeyChar) && txtMilli.Text.Length <= 1) || txtMilli.SelectionLength > 0)
                return;
            else
                e.Handled = true;
        }

        private void btnSetTime_Click(object sender, EventArgs e)
        {
            string min;
            string sec;
            string milli;
            if (txtMin.Text.Length == 0)
                min = "00";
            else if (txtMin.Text.Length == 1)
                min = "0" + txtMin.Text;
            else
                min = txtMin.Text;
            if (txtSec.Text.Length == 0)
                sec = "00";
            else if (txtMin.Text.Length == 1)
                sec = "0" + txtSec.Text;
            else
                sec = txtMin.Text;
            if (txtMilli.Text.Length == 0)
                milli = "00";
            else if (txtMilli.Text.Length == 1)
                milli = txtMilli.Text + "0";
            else
                milli = txtMilli.Text;
            string time = min + ":" + sec + "." + milli;
            if (time == "00:00.00")
            {
                MessageBox.Show("Time cannot be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                selectedEvent.EnterSwimmersTime(swimmer, time);
                parentForm.txtSwimmersTime.Text = time;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            statuslblSwimmerTime.Text = $"{time} successfully added.";
        }
    }
}
