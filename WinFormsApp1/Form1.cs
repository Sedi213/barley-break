using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        
        Button[] btn= new Button[16];
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //initialization button
            for (int i = 0; i < 16; i++)
            {
                int width = 100;
                int height =100;
                btn[i] = new Button();
                btn[i].Text = (i+1).ToString();
                btn[i].Location = new Point((i % 4) * width, height*(i/4));
                btn[i].Height= height;
                btn[i].Width= width;
                btn[i].Tag = i;
                btn[i].Click += button1_Click;
                this.Controls.Add(btn[i]);
            }
            btn[15].Text = "";



            //rand tag
            Random r = new Random();
            int tempPosition=15;
            for (int i = 0; i < 100; i++)
            {
                switch (r.Next(0,4))
                {
                    case 0:
                        if ((tempPosition / 4) + 1 < 4) { //can down swap
                            Tryswapbnt(btn[tempPosition], btn[tempPosition + 4]);
                            tempPosition += 4; }
                        break;
                    case 1:
                        if ((tempPosition / 4) - 1 > -1) { //can down swap
                            Tryswapbnt(btn[tempPosition], btn[tempPosition - 4]);
                            tempPosition -= 4; }
                        break;
                    case 2:
                        if ((tempPosition % 4) + 1 < 4){//can down swap
                            Tryswapbnt(btn[tempPosition], btn[tempPosition + 1]);
                            tempPosition += 1;}
                        break;
                    case 3:
                        if ((tempPosition % 4) - 1 > -1){//can down swap;
                            Tryswapbnt(btn[tempPosition], btn[tempPosition - 1]);
                            tempPosition -= 1;}
                        break;
                 
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int position = Convert.ToInt32(((Button)sender).Tag);
            if ((position / 4) + 1 < 4)//can down swap
                Tryswapbnt(btn[position +4], btn[position]);
            if ((position / 4) - 1 > -1)//can up swap
                Tryswapbnt(btn[position - 4], btn[position]);
            if ((position % 4) + 1 < 4)//can right swap
                Tryswapbnt(btn[position + 1], btn[position]);
            if ((position % 4) - 1 > -1)//can left swap
                Tryswapbnt(btn[position - 1], btn[position]);



            //check win
            for (int i = 0; i < 15; i++)
                if (btn[i].Text != (i + 1).ToString()) return;

            MessageBox.Show("You win");
        }

        private void Tryswapbnt(Button next,Button current)
        {
            if (next.Text == "")
            {
                next.Text = current.Text;
                current.Text = "";
            }
        }
    }
}
