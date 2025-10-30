using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CalculatorPrivateAssembly;

namespace BasicCalculator_Fangon
{
    public partial class FrmBasicCalculator : Form
    {
        public FrmBasicCalculator()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 0)
            {
                string tb1 = textBox1.Text;
                float t1 = float.Parse(tb1);

                string tb2 = textBox2.Text;
                float t2 = float.Parse(tb2);

                float t3 = CalculatorPrivateAssembly.BasicComputation.Add2(t1, t2);

                string tb3 = t3.ToString();
                textBox3.Text = tb3;
                Console.WriteLine(tb3);
            }

            if (comboBox1.SelectedIndex == 1)
            {
                string tb1 = textBox1.Text;
                float t1 = float.Parse(tb1);

                string tb2 = textBox2.Text;
                float t2 = float.Parse(tb2);

                float t3 = CalculatorPrivateAssembly.BasicComputation.Subtract2(t1, t2);

                string tb3 = t3.ToString();
                textBox3.Text = tb3;
            }

            if (comboBox1.SelectedIndex == 2)
            {
                string tb1 = textBox1.Text;
                float t1 = float.Parse(tb1);

                string tb2 = textBox2.Text;
                float t2 = float.Parse(tb2);

                float t3 = CalculatorPrivateAssembly.BasicComputation.Multiply2(t1, t2);

                string tb3 = t3.ToString();
                textBox3.Text = tb3;
            }

            if (comboBox1.SelectedIndex == 3)
            {
                string tb1 = textBox1.Text;
                float t1 = float.Parse(tb1);

                string tb2 = textBox2.Text;
                float t2 = float.Parse(tb2);

                float t3 = CalculatorPrivateAssembly.BasicComputation.Divide2(t1, t2);

                string tb3 = t3.ToString();
                textBox3.Text = tb3;
            }
        }
    }
}
