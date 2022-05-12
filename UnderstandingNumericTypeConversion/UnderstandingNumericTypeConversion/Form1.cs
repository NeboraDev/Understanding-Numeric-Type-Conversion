using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnderstandingNumericTypeConversion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double validFormDoubleValue;
            int validFormIntValue;

            bool isFormValueADouble = double.TryParse(textBox3.Text, out validFormDoubleValue);
            bool isFormValueAInt = int.TryParse(textBox2.Text, out validFormIntValue);

            if (!isFormValueADouble)
            {
                textBox1.Text = "Please enter a valid Double(decimal) in the first box";
            }

            if (!isFormValueAInt)
            {
                textBox1.Text = "Please enter a valid integer (no decimals) in the second box";
            }

            if (isFormValueADouble && isFormValueAInt)
            {
                double result = validFormDoubleValue * validFormIntValue;
                textBox1.Text = result.ToString();
            }
        }
    }
}
