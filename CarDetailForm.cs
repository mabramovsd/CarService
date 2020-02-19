using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp11
{
    public partial class CarDetailForm : Form
    {
        public CarDetailForm(string car)
        {
            InitializeComponent();
            
            textBox1.Text = car;
            Text = "Автомобиль " + car;

            try
            {
                pictureBox1.Load("../../Pictures/" + car + ".jpg");
                textBox1.Text = System.IO.File.ReadAllText("../../Pictures/" + car + ".txt");
            }
            catch (Exception) { }
        }

        private void CarDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
