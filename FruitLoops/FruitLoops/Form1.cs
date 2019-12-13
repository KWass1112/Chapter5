using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FruitLoops
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            int numGreetings = Convert.ToInt32(txtGreetings.Text);
            for (int i = 0; i < numGreetings; ++i)
            {
                lblResult.Text += "Hello\n";
            }
        }
    }
}
