using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pratybos_2
{
    public partial class Form1 : Form
    {
        static int[] Array = new int[10];
        static int count; 

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (count < 10)
            {
                try
                {
                    Array[count] = int.Parse(textBox1.Text);
                    count++;
                    label1.Text = "Ivestas " + count.ToString() + " elementas";
                } catch
                {
                    label1.Text = "KLAIDA!";
                    return;
                }
            } else
            {
                int sum = 0;
                for (int i = 0; i < 10; i++)
                {
                    sum = sum + Array[i];
                }
                label1.Text = "Suma: " + sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int dydis;

            richTextBox1.Text = "";
            try
            {
                dydis = int.Parse(textBox2.Text);
            }
            catch
            {
                richTextBox1.Text = "Neteisingas dydis!";
                return;
            }

            if (dydis <= 0 || dydis > 20)
            {
                richTextBox1.Text = "Dydis turi buti 1-20 !";
                return;
            }

            int ntarpai = dydis;
            for (int i = 1; i <= dydis; i++)
            {
                String prefix = new String(' ', ntarpai);
                richTextBox1.Text = richTextBox1.Text + prefix;

                for (int j = 1; j <= i; j++)
                {
                    richTextBox1.Text = richTextBox1.Text + "* ";
                }
                richTextBox1.Text = richTextBox1.Text + "\n";
                ntarpai--;
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
