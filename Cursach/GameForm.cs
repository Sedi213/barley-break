using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cursach
{
    public partial class GameForm : Form
    {
        private int CountTag { get; set; }
        private Button[] btn;
        private Color ColorTag;
        public GameForm(int _CountTag,Color _color)
        {
            CountTag= _CountTag;
            ColorTag = _color;
            InitializeComponent();
            
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            this.Width = this.Height =1;//Window always be norm size
           
            btn= new Button[CountTag*CountTag];
            for (int i = 0; i < CountTag * CountTag; i++)
            {
                int width = 120 - 5 * CountTag;
                int height = 120 - 5 * CountTag;
                btn[i] = new Button();
                btn[i].Text = (i + 1).ToString();
                btn[i].Location = new Point((i % CountTag) * width, height * (i / CountTag));
                btn[i].Height = height;
                btn[i].Width = width;
                btn[i].Tag = i;
                btn[i].BackColor = ColorTag;
                btn[i].Click += Tag_Click;
                this.Controls.Add(btn[i]);
            }
            btn[^1].Text = "";

            RandomTag();
        }
        private void Tag_Click(object sender, EventArgs e)
        {
            int position = Convert.ToInt32(((Button)sender).Tag);
            if ((position / CountTag) + 1 < CountTag)//can down swap
                Tryswapbnt(btn[position + CountTag], btn[position]);
            if ((position / CountTag) - 1 > -1)//can up swap
                Tryswapbnt(btn[position - CountTag], btn[position]);
            if ((position % CountTag) + 1 < CountTag)//can right swap
                Tryswapbnt(btn[position + 1], btn[position]);
            if ((position % CountTag) - 1 > -1)//can left swap
                Tryswapbnt(btn[position - 1], btn[position]);



            CheckWin();
            
        }

        private void CheckWin()
        {
            for (int i = 0; i < CountTag * CountTag-1; i++)
                if (btn[i].Text != (i + 1).ToString()) return;

            MessageBox.Show("You win");
        }
        private void Tryswapbnt(Button next, Button current)
        {
            if (next.Text == "")
            {
                next.Text = current.Text;
                current.Text = "";
            }
        }

        private void RandomTag()
        {
            Random r = new Random();
            int CurentPosition = CountTag*CountTag-1;
            for (int i = 0; i < 100; i++)
            {
                switch (r.Next(0, CountTag))
                {
                    case 0:
                        if ((CurentPosition / CountTag) + 1 < CountTag)
                        { //can down swap
                            Tryswapbnt(btn[CurentPosition], btn[CurentPosition + CountTag]);
                            CurentPosition += CountTag;
                        }
                        break;
                    case 1:
                        if ((CurentPosition / CountTag) - 1 > -1)
                        { //can down swap
                            Tryswapbnt(btn[CurentPosition], btn[CurentPosition - CountTag]);
                            CurentPosition -= CountTag;
                        }
                        break;
                    case 2:
                        if ((CurentPosition % CountTag) + 1 < CountTag)
                        {//can down swap
                            Tryswapbnt(btn[CurentPosition], btn[CurentPosition + 1]);
                            CurentPosition += 1;
                        }
                        break;
                    case 3:
                        if ((CurentPosition % CountTag) - 1 > -1)
                        {//can down swap;
                            Tryswapbnt(btn[CurentPosition], btn[CurentPosition - 1]);
                            CurentPosition -= 1;
                        }
                        break;

                }
            }
        }
    }
}
