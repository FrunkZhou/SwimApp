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
    public partial class BestTimeForm : Form
    {
        Swimmer swimmer;
        public BestTimeForm()
        {
            InitializeComponent();
        }

        public BestTimeForm(Swimmer swimmer) : this()
        {
            this.swimmer = swimmer;
        }

        private void btnGetBestTime_Click(object sender, EventArgs e)
        {
            PoolType course;
            EventDistance distance;
            Stroke stroke;
            if (combobxCourse.Text == "" || combobxDistance.Text == "" || combobxStroke.Text == "")
            {
                MessageBox.Show("No selections can be empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (combobxCourse.Text == "LCM")
                course = PoolType.LCM;
            else if (combobxCourse.Text == "SCM")
                course = PoolType.SCM;
            else
                course = PoolType.SCY;
            if (combobxDistance.Text == "50m")
                distance = EventDistance._50;
            else if (combobxDistance.Text == "100m")
                distance = EventDistance._100;
            else if (combobxDistance.Text == "200m")
                distance = EventDistance._200;
            else if (combobxDistance.Text == "400m")
                distance = EventDistance._400;
            else if (combobxDistance.Text == "800m")
                distance = EventDistance._800;
            else
                distance = EventDistance._1500;
            if (combobxStroke.Text == "Backstroke")
                stroke = Stroke.Backstroke;
            else if (combobxStroke.Text == "Breaststroke")
                stroke = Stroke.Breaststroke;
            else if (combobxStroke.Text == "Butterfly")
                stroke = Stroke.Butterfly;
            else if (combobxStroke.Text == "Freestyle")
                stroke = Stroke.Freestyle;
            else
                stroke = Stroke.Individual_Medley;
            try
            {
                string bestTime = swimmer.GetBestTime(course, stroke, distance).ToString("mm\\:ss\\:ff");
                MessageBox.Show(bestTime, "Best Time", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }
    }
}
