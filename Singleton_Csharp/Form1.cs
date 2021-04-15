using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_Csharp
{
    /// <summary>
    /// Implementacion del singleton
    /// </summary>
    public class welcome
    {
        public void mostrar()
        {
            MessageBox.Show("Bienvenido a recargas Papotico");
        }
        
    }
    
    public partial class Form1 : Form

        
      
    {
        
        public Form1()
        {
            InitializeComponent();
            welcome welcome = new welcome();
            welcome.mostrar();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Su numero  "+ textBox1.Text + "\n\n" + "Compañia: "+ textBox3.Text+ "\n\n"+ "Monto: "+ textBox2.Text);
            
        }
    }
}
