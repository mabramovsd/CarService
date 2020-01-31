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
            
            pictureBox1.Load("../../Pictures/" + car +".jpg");
            Text = "Автомобиль " + car;
            textBox1.Text = car;

            if (car == "Pagani Zonda")
            {
                textBox1.Text += 
                    Environment.NewLine + "Максимальная скорость 330 км / ч" +
                    Environment.NewLine + "Мощность 700 л.с.";
            }
            if (car == "KIA Optima")
            {
                textBox1.Text +=
                    Environment.NewLine + "Максимальная скорость 220 км / ч" +
                    Environment.NewLine + "Мощность 200 л.с.";
            }
        }

        private void CarDetailForm_Load(object sender, EventArgs e)
        {

        }
    }
}
