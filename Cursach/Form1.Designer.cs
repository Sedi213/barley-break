namespace Cursach
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BntStart = new System.Windows.Forms.Button();
            this.CBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnColor = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BntStart
            // 
            this.BntStart.Location = new System.Drawing.Point(12, 12);
            this.BntStart.Name = "BntStart";
            this.BntStart.Size = new System.Drawing.Size(172, 65);
            this.BntStart.TabIndex = 0;
            this.BntStart.Text = "Start";
            this.BntStart.UseVisualStyleBackColor = true;
            this.BntStart.Click += new System.EventHandler(this.BntStart_Click);
            // 
            // CBox
            // 
            this.CBox.FormattingEnabled = true;
            this.CBox.Location = new System.Drawing.Point(12, 196);
            this.CBox.Name = "CBox";
            this.CBox.Size = new System.Drawing.Size(172, 28);
            for (int i = 4; i <7; i++)
                this.CBox.Items.Add(i);
            this.CBox.TabIndex = 1;
            this.CBox.SelectedIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(207, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 140);
            this.label1.TabIndex = 2;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Select count of field";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Cursach.Properties.Resources.main;
            this.pictureBox1.Location = new System.Drawing.Point(234, 177);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(284, 261);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // BtnColor
            // 
            this.BtnColor.Location = new System.Drawing.Point(12, 86);
            this.BtnColor.Name = "BtnColor";
            this.BtnColor.Size = new System.Drawing.Size(172, 65);
            this.BtnColor.TabIndex = 6;
            this.BtnColor.Text = "Choose color";
            this.BtnColor.UseVisualStyleBackColor = true;
            this.BtnColor.Click += new System.EventHandler(this.BtnColor_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 450);
            this.Controls.Add(this.BtnColor);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CBox);
            this.Controls.Add(this.BntStart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BntStart;
        private ComboBox CBox;
        private Label label1;
        private Label label2;
        private PictureBox pictureBox1;
        private Button BtnColor;
    }
}