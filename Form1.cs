using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_11._5_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Double ans;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "+";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = (n1 + n2);
            lblAns.Text = Convert.ToString(ans);
            
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "-";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = (n1 - n2);
            lblAns.Text = Convert.ToString(ans);
        }

        private void btnMult_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "x";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = (n1 * n2);
            lblAns.Text = Convert.ToString(ans); 
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "/";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = (n1 / n2);
            lblAns.Text = Convert.ToString(ans);
        }

        private void btnExponent_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "^";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = (n1 / (n1 * n2));
            lblAns.Text = Convert.ToString(ans);
        }

        private void BtnRoot_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "√";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = (n1 / (n1 * n2));
            lblAns.Text = Convert.ToString(ans);
        }

        private void btnAverage_Click(object sender, EventArgs e)
        {
            lblOperator.Show();
            lblOperator.Text = "Average";
            int n1 = Convert.ToInt32(txtNumOne.Text);
            int n2 = Convert.ToInt32(txtNumTwo.Text);
            ans = ((n1 + n2) / 2);
            lblAns.Text = Convert.ToString(ans);
        }    
        
        private void lblEquals_Click(object sender, EventArgs e)
        {
            lblEquals.Text = "=";
        }

        private void btnEqual_Click(object sender, EventArgs e)
        {
            if (txtNumTwo.Text.Length > 0)
            {
                lblAns.Show();
            }
        }

        private void txtNumTwo_TextChanged(object sender, EventArgs e)
        {
            if (txtNumTwo.Text.Length > 0) 
            {
                btnAdd.Show();
                btnSub.Show();
                btnMult.Show();
                btnDivide.Show();
                btnExponent.Show();
                btnRoot.Show();
                btnAverage.Show();
                btnEqual.Show();
            }

            else
            {
                btnAdd.Hide();
                btnSub.Hide();
                btnMult.Hide();
                btnDivide.Hide();
                btnExponent.Hide();
                btnRoot.Hide();
                btnAverage.Hide();
                btnEqual.Hide();
                lblAns.Hide();
            }


        }
    }
}
