using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        loololloloolloololloloollo lol;
      
        int x = -555;
        int y = -555;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lol = new loololloloolloololloloollo();

            try
            {
                x = int.Parse(textBox1.Text);
                y = int.Parse(textBox2.Text);
            }
            catch (Exception ex)
            {
                DialogResult dialogResult = MessageBox.Show("Błąd", ex.Message, MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes  )
                {
                    label1.Text = textBox1.Text + " " + textBox2.Text;

                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("co ty robisz", "",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Restart();
                }
            }
            lol.lol = String.Format("Wynik dodawania: {0}", x + y);
            label1.Text = lol.lol;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
