using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace catalog
{
    public partial class liked : Form
    {

        public static Dictionary<Phone, int> likedphones = new Dictionary<Phone, int>();

        public liked()
        {
            InitializeComponent();
            Draw();
        }

        void Draw ()
        {
            //Controls.Clear();

            int x = 30;
            int y = 50;
            foreach (KeyValuePair<Phone, int> Liked_phones in likedphones)
            {
                Phone phone = Liked_phones.Key;

                #region 1 столбец
                PictureBox picture = new PictureBox();
                picture.Location = new Point(x, y);
                picture.Size = new Size(198, 215);
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                picture.Image = phone.pic.Image;
                panel.Controls.Add(picture);
                #endregion

                #region 2 столбец
                Label label1 = new Label();
                label1.Font = new Font("Calibri", 16);
                label1.Text = "Модель: " + phone.name;
                label1.Location = new Point(x + 210, y + 90);
                label1.Size = new Size(200, 40);
                panel.Controls.Add(label1);

                Label label2 = new Label();
                label2.Font = new Font("Calibri", 12);
                label2.Text = "Внутренняя память: " + phone.memory.ToString();
                label2.Location = new Point(x + 210, y + 40);
                label2.Size = new Size(200, 40);
                panel.Controls.Add(label2);

                /*Label label3 = new Label();
                label2.Font = new Font("Calibri", 12);
                label2.Text = "Внутренняя память: " + phone.memory.ToString();
                label2.Location = new Point(x + 210, y);
                label2.Size = new Size(200, 40);
                panel.Controls.Add(label2);
                */
                #endregion

                #region 3 столбец

                Label label4 = new Label();
                label4.Font = new Font("Calibri", 12);
                label4.Text = "ЦЕНА - " + phone.price + "руб.";
                label4.Location = new Point(x + 210, y);
                label4.Size = new Size(200, 40);
                panel.Controls.Add(label4);
                #endregion

                #region 4 столбец

                Button btn_del = new Button();
                btn_del.Font = new Font("Calibri", 12);
                btn_del.Text = "Удалить";
                btn_del.Location = new Point(x + 400, y + 50);
                btn_del.Size = new Size(100, 40);
                btn_del.Click += new System.EventHandler(Del);
                panel.Controls.Add(btn_del);
                #endregion

                y = y + 269;
            }


        }

        void Del(Object sender, EventArgs e)
        {
            Button b = new Button();
            b = (Button)sender; 
            Dictionary<Phone, int> likedphones1 = new Dictionary<Phone, int>();
            foreach (KeyValuePair<Phone, int> Liked_phones in likedphones)
            {
               if(b.Location == new Point(430, 100))
                { }
               else
                {
                    likedphones1[Liked_phones.Key] = Liked_phones.Value;
                }
            }
            likedphones = likedphones1;
            Draw();
        }

        private void liked_Load(object sender, EventArgs e)
        {

        }
    }
}
