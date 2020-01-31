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
    public partial class CategoryForm : Form
    {
        public CategoryForm(string category)
        {
            InitializeComponent();

            button2.Visible = true;
            button6.Visible = true;

            Text = "Автомобили класса " + category;
            if (category == "Суперкары")
            {
                button2.Text = "McLaren Senna";
                button6.Text = "Pagani Zonda";
            }
            else if (category == "Бюджетные авто")
            {
                button2.Text = "Renault Logan";
                button6.Visible = false;
            }
            else if (category == "Бизнес-класс")
            {
                button2.Text = "KIA Optima";
                button6.Text = "Toyota Camry";
            }
            else
            {
                button2.Visible = false;
                button6.Visible = false;
            }

            if (button2.Text != "")
            {
                pictureBox2.Load("../../Pictures/" + button2.Text + ".jpg");
            }
            if (button6.Text != "")
            {
                pictureBox4.Load("../../Pictures/" + button6.Text + ".jpg");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CarDetailForm form = new CarDetailForm(button6.Text);
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CarDetailForm form = new CarDetailForm(button2.Text);
            form.Show();
        }

        private void CategoryForm_Load(object sender, EventArgs e)
        {

        }
    }
}
