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
            for (int i = 0; i < 16; i++)
            {
                int width = 70;
                int height =70;
                btn[i] = new Button();
                btn[i].Text = (i+1).ToString();
                btn[i].Location = new Point((i % 4) * width, height*(i/4));
                btn[i].Height= height;
                btn[i].Width= width;
                btn[i].Tag = i;
                btn[i].Click += button1_Click;
                this.Controls.Add(btn[i]);
            }
              
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           int position = Convert.ToInt32(((Button)sender).Tag);
            if ((position / 4) + 1 < 4) { MessageBox.Show("down"); }
            if ((position / 4) - 1 > -1) { MessageBox.Show("up"); }
            if ((position % 4) + 1 < 4) { MessageBox.Show("right"); }
            if ((position % 4) - 1 > -1) { MessageBox.Show("lef"); }
        }
    }
}
