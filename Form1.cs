using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SistemaParcial2OctavioGonzalez
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            this.AcceptButton = iconButton3;
            this.StartPosition = FormStartPosition.CenterScreen;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
   
        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
            this.Hide();
        }
    
        private void button4_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }   
        private void button5_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show();
            this.Hide();
        }
        private void iconButton3_Click(object sender, EventArgs e)
        {
            if (usuario.Text.Trim().ToLower()== "admin")
            {
                
                if ( contraseña.Content.Trim()=="1234")
                {
                    MessageBox.Show("Bienvenido", "Acceso concedido");
                    Form2 f = new Form2();
                    f.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Usuario incorrecto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
        private void iconButton6_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }

        // Para poder mover el formulario sin necesidad del borde clasico. 
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void contraseña_FinishedTypingContent(object sender, EventArgs e)
        {

        }
    }
}
