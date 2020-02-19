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
    public struct Car
    {
        public string name;
        public string factory;
        public int price;
        public Button btn;
        public PictureBox pb;

        public Car(string _name, string _factory, int _price)
        {
            name = _name;
            factory = _factory;
            price = _price;
            btn = new Button();
            pb = new PictureBox();
        }
    }


    public partial class FIlterForm : Form
    {
        Car[] car_list = new Car[100];

        public FIlterForm()
        {
            InitializeComponent();

            car_list[0] = new Car("Lada Priora", "VAZ", 400000);
            car_list[1] = new Car("Lada Vesta", "VAZ", 500000);
            car_list[2] = new Car("Pagani Zonda", "Pagani", 40000000);
            car_list[3] = new Car("KIA Optima", "KIA", 800000);

            int x = 10;
            int y = 200;
            for (int i = 0; i < 4; i++)
            {
                car_list[i].btn.Location = new Point(x, y);
                car_list[i].btn.Size = new Size(120, 50);
                car_list[i].btn.Text = car_list[i].name;
                car_list[i].btn.Click += new EventHandler(this.button6_Click);

                car_list[i].pb.Location = new Point(x, y + 50);
                car_list[i].pb.Size = new Size(120, 80);
                car_list[i].pb.SizeMode = PictureBoxSizeMode.StretchImage;

                try
                {
                    car_list[i].pb.Load("../../Pictures/" + car_list[i].name + ".jpg");
                }
                catch (Exception) { }

                Controls.Add(car_list[i].btn);
                Controls.Add(car_list[i].pb);

                x = x + 130;
                if (x > Width - 130)
                {
                    x = 10;
                    y = y + 140;
                }
            }
        }

        private void FIlterForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = 10;
            int y = 200;
            for (int i =0; i < 4; i++)
            {
                bool Visible = true;
                car_list[i].btn.Visible = false;
                car_list[i].pb.Visible = false;

                if (maxPriceTextBox.Text != "" &&
                    car_list[i].price >= Convert.ToInt32(maxPriceTextBox.Text))
                {
                    Visible = false;
                }
                else if (minPriceTextBox.Text != "" &&
                    car_list[i].price <= Convert.ToInt32(minPriceTextBox.Text))
                {
                    Visible = false;
                }
                else if (factoryCheckedListBox.CheckedItems.Count > 0)
                {
                    Visible = false;
                    for (int k = 0; k < factoryCheckedListBox.CheckedItems.Count; k++)
                    {
                        if (car_list[i].factory == factoryCheckedListBox.CheckedItems[k].ToString())
                        {
                            Visible = true;
                        }
                    }
                }

                if (Visible)
                {
                    car_list[i].btn.Location = new Point(x, y);
                    car_list[i].pb.Location = new Point(x, y + 50);
                    car_list[i].btn.Visible = true;
                    car_list[i].pb.Visible = true;
                    car_list[i].btn.Text = car_list[i].name;

                    x = x + 130;
                    if (x > Width - 130)
                    {
                        x = 10;
                        y = y + 140;
                    }
                }
            }
        }

        private void maxPriceTextBox_TextChanged(object sender, EventArgs e)
        {
        }

        private void maxPriceTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(null, null);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button3 = (Button)sender;
            CarDetailForm form = new CarDetailForm(button3.Text);
            form.Show();
        }
    }
}
