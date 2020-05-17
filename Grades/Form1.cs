using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grades
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttoncalculate_Click(object sender, EventArgs e)
        {
            Single Grade = 0;
            String Name = "";
            Grade = Convert.ToSingle(txtgrades.Text);
            Name = txtnames.Text;
            if (Grade > 50 && Grade <60)
            {
                lbxGrade.Items.Add("Hi " + Name + " Your Grade is " + Grade + " = D");
            }
            {
                Grade = Convert.ToSingle(txtgrades.Text);
                Name = txtnames.Text;
                if (Grade > 60 && Grade < 70)
                {
                    lbxGrade.Items.Add("Hi " + Name + " Your Grade is " + Grade + " = C");
                }
                Grade = Convert.ToSingle(txtgrades.Text);
                Name = txtnames.Text;
                if (Grade > 70 && Grade < 80)
                {
                    lbxGrade.Items.Add("Hi " + Name + " Your Grade is " + Grade + " = B");
                }
                Grade = Convert.ToSingle(txtgrades.Text);
                Name = txtnames.Text;
                if (Grade > 80 && Grade < 90)
                {
                    lbxGrade.Items.Add("Hi " + Name + " Your Grade is " + Grade + " = A");
                }
                Grade = Convert.ToSingle(txtgrades.Text);
                Name = txtnames.Text;
                if (Grade > 90 && Grade < 100)
                {
                    lbxGrade.Items.Add("Hi " + Name + " Your Grade is " + Grade + " = A+");
                }

            }

        }
    }
}
