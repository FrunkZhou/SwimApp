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
using System.Text.RegularExpressions;

namespace SwimForm
{
    public partial class CreateSwimMeetForm : Form
    {
        MainForm mainForm;
        public CreateSwimMeetForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];
            nmUDLanes.Value = 8;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            dtPkStart.ResetText();
            dtPkEnd.ResetText();
            rbtLCM.Checked = true;
            nmUDLanes.Value = 8;
            statuslbl.Text = "";
            this.ActiveControl = txtName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            PoolType course;
            if (txtName.Text == "")
            {
                MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtName;
                return;
            }
            if (rbtLCM.Checked)
            {
                course = PoolType.LCM;
            }
            else if (rbtSCM.Checked)
            {
                course = PoolType.SCM;
            }
            else
            {
                course = PoolType.SCY;
            }
            try
            {     
                mainForm.Database.SwimMeets.Add(new SwimMeet(txtName.Text, dtPkStart.Value, dtPkEnd.Value, course, (int)nmUDLanes.Value));
                mainForm.RefreshMeetsList();
                statuslbl.Text = $"Swim meet {txtName.Text} was successfully created.";
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
                this.ActiveControl = txtName;
            }           
        }
    }
}
