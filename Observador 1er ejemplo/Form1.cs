using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Observador_1er_ejemplo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i < 100; i++)
            {
                
                int count= i ;
                int validator = count / 10;
                if (validator== 7)
                {

                    string validator1 = Convert.ToString(validator);
                    MessageBox.Show("Aqui aparecio un " + validator1 );
                   
                }
            }
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
