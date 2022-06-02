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
                DialogResult dialogResult = MessageBox.Show(ex.Message, "błąd", MessageBoxButtons.OK);
                if (dialogResult == DialogResult.OK  )
                {
                    label1.Text = textBox1.Text + " " + textBox2.Text;

                }
                
            }
            lol.lol = String.Format("Wynik dodawania: {0}", x + y);
            label1.Text = lol.lol;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
