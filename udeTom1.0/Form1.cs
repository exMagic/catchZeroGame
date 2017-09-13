using System;
using System.Drawing;
using System.Windows.Forms;

namespace udeTom1._0
{
    public partial class buf : Form
    {
        public buf()
        {
            InitializeComponent();
        }
        void calculate()
        {
            string n1 = button1z.Text + button2z.Text + button3z.Text;
            string n2 = button4z.Text + button5z.Text;
            string n3 = button6z.Text + button7z.Text + button8z.Text;
            string n4 = button9z.Text + button10z.Text;

            int l1 = int.Parse(n1);
            int l2 = int.Parse(n2);
            int l3 = int.Parse(n3);
            int l4 = int.Parse(n4);

            int suma1 = l1 * l2;
            sum1.Text = $"{suma1}";
            int suma2 = l3 * l4;
            sum2.Text = $"{suma2}";
            int diffVal = suma1 - suma2;
            diff.Text = $"{diffVal}";
        }
        bool loaded =true;
        string inTmp;
        private void button1_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                tmp.Text = button1z.Text;
                button1z.Text = "";
                button1z.BackColor = Color.Red;
                loaded = false;
            }
            else
            {
                button1z.Text = tmp.Text;
                
                calculate();
                loaded = true;
                tmp.Text = "";
                button1z.BackColor = Color.Gray;
            }
           
        }

        private void button2z_Click(object sender, EventArgs e)
        {
            if (loaded)
            {
                tmp.Text = button2z.Text;
                button2z.Text = "";
                button2z.BackColor = Color.Red;
                loaded = false;
            }
            else
            {
                button2z.Text = tmp.Text;

                calculate();
                loaded = true;
                tmp.Text = "";
                button2z.BackColor = Color.Gray;
            }

        }

        private void button3z_Click(object sender, EventArgs e)
        {
            inTmp = button3z.Text;
            button3z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button4z_Click(object sender, EventArgs e)
        {
            inTmp = button4z.Text;
            button4z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button5z_Click(object sender, EventArgs e)
        {
            inTmp = button5z.Text;
            button5z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button6z_Click(object sender, EventArgs e)
        {
            inTmp = button6z.Text;
            button6z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button7z_Click(object sender, EventArgs e)
        {
            inTmp = button7z.Text;
            button7z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button8z_Click(object sender, EventArgs e)
        {
            inTmp = button8z.Text;
            button8z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button9z_Click(object sender, EventArgs e)
        {
            inTmp = button9z.Text;
            button9z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }

        private void button10z_Click(object sender, EventArgs e)
        {
            inTmp = button10z.Text;
            button10z.Text = tmp.Text;
            tmp.Text = inTmp;
            calculate();
        }
    }
}
