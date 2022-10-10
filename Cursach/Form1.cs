namespace Cursach
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BntStart_Click(object sender, EventArgs e)
        {
            
            GameForm temp = new GameForm(int.Parse(CBox.SelectedItem.ToString()),BtnColor.BackColor);
            
        
        
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            ColorDialog MyDialog = new ColorDialog();

            if (MyDialog.ShowDialog() == DialogResult.OK)
                BtnColor.BackColor = MyDialog.Color;
        }
    }
}