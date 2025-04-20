using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input1 = txt1.Text;
            string input2 = txt2.Text;
            if (float.TryParse(input1,out float n1) && float.TryParse(input2,out float n2))
            {
                float result = (n1 * n2)/2;
                label1.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Inserisci dei numeri validi");
            }
        }
    }
}
