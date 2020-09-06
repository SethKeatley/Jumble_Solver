using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class JumbleSolver : Form
    {
        public int numLetters;

        private int txtBoxStartPosition = 100;
        private int txtBoxStartPositionV = 25;
        public JumbleSolver()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            numLetters = int.Parse(txtNumLetters.Text);
            txtNumLetters.Hide();
            btnConfirm.Hide();


            for(int i = 0; i <= numLetters; i++)
            {
                TextBox newTxt = new TextBox();
                newTxt.Location = new System.Drawing.Point(txtBoxStartPosition, txtBoxStartPositionV);
                newTxt.Size = new System.Drawing.Size(70, 40);
                newTxt.Text = i.ToString();

                pnlLetters.Add(newTxt);
                txtBoxStartPositionV += 30;
            }
        }
    }
}
