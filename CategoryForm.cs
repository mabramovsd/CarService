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
        Button[] btn = new Button[10];

        public CategoryForm(string category)
        {
            InitializeComponent();

            btn[0] = button1;
            btn[1] = button2;
            btn[2] = button3;

            for (int i = 0; i < 3; i++)
            {
                btn[i].Visible = true;
            }

            Text = "Автомобили класса " + category;
            if (category == "Суперкары")
            {
                button1.Text = "McLaren Senna";
                button2.Text = "McLaren Senna";
                button3.Text = "Pagani Zonda";
            }
            else if (category == "Бюджетные авто")
            {
                button1.Text = "Renault Logan";
                for (int i = 1; i < 3; i++)
                {
                    btn[i].Visible = true;
                }
            }
            else if (category == "Бизнес-класс")
            {
                button1.Text = "Toyota Camry";
                button2.Text = "KIA Optima";
                button3.Visible = false;
            }
            else
            {
                for (int i = 0; i < 3; i++)
                {
                    btn[i].Visible = false;
                }
            }

            if (button1.Text != "")
            {
                pictureBox1.Load("../../Pictures/" + button1.Text + ".jpg");
            }
            if (button2.Text != "")
            {
                pictureBox2.Load("../../Pictures/" + button2.Text + ".jpg");
            }
            if (button3.Text != "")
            {
                pictureBox3.Load("../../Pictures/" + button3.Text + ".jpg");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            CarDetailForm form = new CarDetailForm(button3.Text);
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
