using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;
namespace SistemaParcial2OctavioGonzalez
{
    public partial class Form3 : Form
    {
        public (int comision, string nombre, int legajo, int edad, string correo) Estudiante { get; set; }
        public Form3()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            
        }
        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
        }
        private void iconButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {

        }
        
        private void botonañadir_Click(object sender, EventArgs e)
        {


            Estudiante = ((int.Parse(textBox5.Text), textBox1.Text, int.Parse(textBox4.Text), int.Parse(textBox2.Text), textBox3.Text));
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
