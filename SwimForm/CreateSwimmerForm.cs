using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SwimModel;

namespace SwimForm
{
    public partial class CreateSwimmerForm : Form
    {
        MainForm mainForm;

        SwimmersListForm parentSwimmersForm;
        CoachesListForm parentCoachesForm;
        public CreateSwimmerForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];
            this.ActiveControl = txtName;
        }

        public CreateSwimmerForm(SwimmersListForm form) :this()
        {
            parentSwimmersForm = form;
            this.cbxCoach.Checked = false;
            this.lblCredentials.Enabled = false;
            this.cbxCoach.Enabled = false;
        }

        public CreateSwimmerForm(CoachesListForm form) : this()
        {
            parentCoachesForm = form;
            this.cbxCoach.Checked = true;
            this.lblCredentials.Enabled = true;
            this.cbxCoach.Enabled = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            txtPhone.ResetText();
            dtPkDoB.ResetText();
            txtStreet.ResetText();
            txtCity.ResetText();
            txtProvince.ResetText();
            txtPostal.ResetText();
            statuslbl.Text = "";
            this.ActiveControl = txtName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtName;
                return;
            }
            if (cbxCoach.Checked)
            {
                try
                {
                    mainForm.Database.Coaches.Add(new Coach(txtName.Text, dtPkDoB.Value, new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPostal.Text), Convert.ToInt64(txtPhone.Text == "" ? "0" : txtPhone.Text), txtCredentials.Text));
                    parentCoachesForm.RefreshCoaches();
                    mainForm.RefreshCoaches();
                    statuslbl.Text = $"Coach {txtName.Text} was successfully created.";
                }
                catch (FormatException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPostal.SelectAll();
                    this.ActiveControl = txtPostal;
                }
                catch (ArgumentException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.SelectAll();
                    this.ActiveControl = txtPhone;
                }
            }
            else
            {
                try
                {
                    mainForm.Database.Swimmers.Add(new Swimmer(txtName.Text, dtPkDoB.Value, new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPostal.Text), Convert.ToInt64(txtPhone.Text == "" ? "0" : txtPhone.Text)));
                    parentSwimmersForm.RefreshSwimmers();
                    mainForm.RefreshSwimmersList();
                    statuslbl.Text = $"Swimmer {txtName.Text} was successfully created.";
                }
                catch (FormatException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPostal.SelectAll();
                    this.ActiveControl = txtPostal;
                }
                catch (ArgumentException err)
                {
                    MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPhone.SelectAll();
                    this.ActiveControl = txtPhone;
                }
            }           
        }

        private void cbxCoach_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxCoach.Checked)
            {
                lblCredentials.Enabled = true;
                txtCredentials.Enabled = true;
                this.lblTitle.Text = "Create A Coach";
                this.btnCreate.Text = "Create Coach";
                this.Text = "Create a Coach";
            }
            else
            {
                lblCredentials.Enabled = false;
                txtCredentials.Enabled = false;
                this.lblTitle.Text = "Create A Swimmer";
                this.btnCreate.Text = "Create Swimmer";
                this.Text = "Create a Swimmer";
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            else
                e.Handled = true;
        }
    }
}
