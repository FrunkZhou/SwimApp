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
    public partial class CreateClubForm : Form
    {
        MainForm mainForm;
        public CreateClubForm()
        {
            InitializeComponent();
            mainForm = (MainForm)Application.OpenForms[0];         
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.ResetText();
            txtPhone.ResetText();
            txtStreet.ResetText();
            txtCity.ResetText();
            txtProvince.ResetText();
            txtPostal.ResetText();
            statuslbl.Text = "";
            this.ActiveControl = txtName;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            //Check same name
            if (txtName.Text == "")
            {
                MessageBox.Show("Name must not be empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.ActiveControl = txtName;
                return;
            }
            try
            {
                mainForm.Database.Clubs.Add(new Club(txtName.Text, new Address(txtStreet.Text, txtCity.Text, txtProvince.Text, txtPostal.Text), Convert.ToInt64(txtPhone.Text == "" ? "0" : txtPhone.Text)));
                mainForm.RefreshClubsList();
                mainForm.lsbClubsClubs.SelectedIndex = mainForm.Database.Clubs.Count - 1;
                statuslbl.Text = $"Club {txtName.Text} was successfully created.";
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

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
                return;
            else
                e.Handled = true;
        }
    }
}
