using FontAwesome.Sharp;
using PlaceholderTextBox;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;
namespace SistemaParcial2OctavioGonzalez
{
    public partial class Form2 : Form
    {
        Alumnos obj = new Alumnos();
        Notas obj1 = new Notas();
        private Panel leftBorder;
        private IconButton Current;
        private IconButton Current2;
        private string modoActual = "";
        private int nroComision = 0;
        private List<(int comision, string nombre, int legajo, int edad, string correo)> estudiantes;
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            estudiantes = new List<(int comision, string nombre, int legajo, int edad, string correo)>();
            panel3.Dock = DockStyle.Top;
            panel3.Height = 30;
            panel3.BackColor = Color.FromArgb(0, 171, 148);
            FormBorderStyle = FormBorderStyle.None;
            panel3.Paint += (s, e) =>
            {
                Color bordeColor = Color.FromArgb(0, 171, 148); // el color que quieras
                int grosor = 1; // ancho del borde
                ControlPaint.DrawBorder(e.Graphics, panel3.ClientRectangle,
                    bordeColor, grosor, ButtonBorderStyle.Solid,
                    bordeColor, grosor, ButtonBorderStyle.Solid,
                    bordeColor, grosor, ButtonBorderStyle.Solid,
                    bordeColor, grosor, ButtonBorderStyle.Solid);
            };
            this.Controls.Add(panel3);
            IconButton btnCerrar = new IconButton();
            btnCerrar.IconSize = 20;
            btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            btnCerrar.IconColor = Color.FromArgb(0, 58, 68); ;
            btnCerrar.Dock = DockStyle.Right;
            btnCerrar.FlatStyle= FlatStyle.Flat;
            btnCerrar.Width = 30;
            btnCerrar.FlatAppearance.BorderColor = Color.Gray;
            btnCerrar.BackColor = Color.FromArgb(0, 171, 148) ;
            btnCerrar.Click += (object s, EventArgs t) => Application.Exit();
            panel3.Controls.Add(btnCerrar);
           
            //borde izquierdo para botones seleccionados en el panel izquierdo. 
            leftBorder = new Panel();
            leftBorder.Size = new Size(10, 83); 
            leftBorder.BackColor = Color.FromArgb(85, 28, 35);
            leftBorder.Visible = false;
            leftBorder.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(leftBorder);

            //panel fondo
            new PanelResizer(panelfondo, 8);
            // Tooltips
            toolTip1.SetToolTip(iconButton5, "Eliminar seleccion");
            toolTip1.SetToolTip(iconButton7, "Buscar por nombre, dni, o legajo.");

            //botones comisiones

            comision1.Click += btnComision_Click;
            comision2.Click += btnComision_Click;
            comision3.Click += btnComision_Click;
            comision4.Click += btnComision_Click;
            comision5.Click += btnComision_Click;
            comision6.Click += btnComision_Click;
            comision7.Click += btnComision_Click;
            
            comision1.Tag = 1;
            comision2.Tag = 2;
            comision3.Tag = 3;
            comision4.Tag = 4;
            comision5.Tag = 5;
            comision6.Tag = 6;
            comision7.Tag = 7;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridView1.MultiSelect = false; 
            dataGridView1.AllowUserToAddRows = false; 

        }
//PERSONALIZACION:Cambia de color los botones seleccionados del panel superior cuando selecc notas o alumnos. 
        private void enviar (Object botonsito)
        {
            var b= (IconButton)botonsito;
            b.BackColor = iconButton7.FlatAppearance.BorderColor;
            b.IconColor = Color.FromArgb(170, 56, 71);
            if (Current != null && Current != b)
            {
                Current.BackColor = Color.FromArgb(0, 58, 68);
                Color.FromArgb(101, 164, 171);
                Current.IconColor = Color.FromArgb(101, 164, 171);
            }
            Current = b;

        }

//PERSONALIZACION:Cambia de color y posicion los botones del panel izquierdo.
        private void enviar2 (Object botonsito2)
        {
            if (botonsito2 != null)
            {
                enviar3();
                var n = (IconButton)botonsito2;
                n.BackColor = Color.FromArgb(85, 199, 183);
                n.IconColor = Color.FromArgb(85, 28, 35);
                n.TextAlign = ContentAlignment.MiddleCenter;
                n.TextImageRelation = TextImageRelation.TextBeforeImage;
                n.ImageAlign = ContentAlignment.MiddleRight;
                Current2 = n;

                //Borde izquierdin.

                leftBorder.Height = n.Height;
                leftBorder.Top = n.Top;
                leftBorder.Left = 0;
                leftBorder.Visible = true;
                leftBorder.BringToFront();
                
               
            }
        }
        private void enviar3 ()
        {
            if (Current2 != null)
            {
                Current2.BackColor = Color.FromArgb(0, 58, 68);
                Current2.IconColor = Color.FromArgb(101, 164, 171);
                Current2.TextAlign = ContentAlignment.MiddleLeft;
                Current2.TextImageRelation = TextImageRelation.ImageBeforeText;
                Current2.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }
                         
// LOAD                                  
        public void Form2_Load(object sender, EventArgs e)
        {
            iconButton6.Visible = false;
            iconButton5.Visible = false;
            iconButton7.Visible = false;
            iconButton4.Visible = false;
            botonañadir.Visible = false;
            placeholderTextBox1.Visible = false;
         
            
        }
//Boton alumno 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            modoActual = "Alumnos";
            if (iconButton1.IconColor == Color.FromArgb(101, 164, 171))
            {

                placeholderTextBox1.Visible = true;
                iconButton7.Visible = true;
                iconButton6.Visible = true;
                iconButton5.Visible = true;
                iconButton4.Visible = false;
                label1.Visible = false;
                pictureBox1.Visible = true;
                label2.Visible = true;
                botonañadir.Visible= true;
                pictureBox2.Visible = false;
                enviar2(sender);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                panelcomision.Visible = true;

            }
            else
            {
                panelcomision.Visible = false;
                iconButton1.TextAlign = ContentAlignment.MiddleLeft;
                iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
                iconButton1.ImageAlign = ContentAlignment.MiddleLeft;
                placeholderTextBox1.Visible = false;
                iconButton7.Visible = false;
                iconButton6.Visible = false;
                iconButton5.Visible = false;
                botonañadir.Visible = false;
                pictureBox2.Visible = true;
                label1.Visible = true;
                
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                //volver al color normal
                iconButton1.IconColor = Color.FromArgb(101, 164, 171);
                iconButton1.BackColor = Color.FromArgb(0, 58, 68);
            }
        }
//Boton notas.
        private void iconButton3_Click(object sender, EventArgs e)
        {
            modoActual = "Notas";
            enviar2(sender);
            //Mostrar botones. 
            placeholderTextBox1.Visible = true;
            iconButton7.Visible = true;
            iconButton6.Visible = true;
            iconButton5.Visible = false;
            botonañadir.Visible = true;
            pictureBox2.Visible = false;
            botonañadir.Visible = false;
            label1.Visible = false;
            iconButton4.Visible= true;
            
            panelcomision.Visible = true;
            //LIMPIAR DATAGRID
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            
        }


        //Funcion

private void AbrirFormHija(object formhija)
        {
            if (this.panelformulario.Controls.Count > 0)
                this.panelformulario.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelformulario.Controls.Add(fh);
            this.panelformulario.Tag = fh;
            panelformulario.BringToFront();
            panelformulario.BorderStyle = BorderStyle.None;
            panelformulario.BackColor = Color.White;

            fh.Show();
        }

        //Boton estadistica
        private void iconButton2_Click(object sender, EventArgs e)
        {
            enviar2(sender);
            panelcomision.Visible = false;
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            placeholderTextBox1.Visible = false;
            iconButton7.Visible = false;
            iconButton6.Visible = false;
            iconButton5.Visible = false;
            iconButton4.Visible = false;

            AbrirFormHija(new Form4());

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            var f = new Form3();
          
            if (f.ShowDialog() == DialogResult.OK)
            {
                estudiantes.Add(f.Estudiante);
                dataGridView1.Rows.Add(f.Estudiante.nombre, f.Estudiante.legajo, f.Estudiante.edad, f.Estudiante.correo);

            }
        }
//Boton ver notas. (ojo)
        private void iconButton6_Click(object sender, EventArgs e)
        {

//PERSONALIZACION:Alternar ojito cerrado y ojito abierto 
            if (iconButton6.IconChar == FontAwesome.Sharp.IconChar.EyeSlash)
            {
                iconButton6.IconChar = FontAwesome.Sharp.IconChar.Eye;
                dataGridView1.Visible = true;
                label1.Visible = false;
                pictureBox2.Visible = false;
            }
            else
            {
                iconButton6.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                dataGridView1.Visible = false;
                pictureBox2.Visible = true;
                label1.Visible = true;
            }
        }
        
//Boton: TUPLA EN CLASE Y DATAGRID:Buscar y seleccionar encontrados. 
        private void iconButton7_Click(object sender, EventArgs e)
        {
           
            var alumno = placeholderTextBox1.Text;
          
           
            var filtro = obj.Obcomision(nroComision).Where(n => (n.Nombre == alumno) || n.Legajo.ToString() == alumno || n.DNI.ToString() == alumno).ToList();
            
            if (filtro.Count>0) 
            {
               
                dataGridView1.Rows.Clear();
                foreach (var n in filtro)
                {
                  dataGridView1.Rows.Add(n.Nombre, n.Legajo, n.DNI, n.Correo);
                }
            }
            else
            {
                dataGridView1.Rows.Clear();
                if (dataGridView1.Columns.Count != 0)
                {
                    foreach (var n in obj.Obcomision(nroComision))
                    {
                        dataGridView1.Rows.Add(n.Nombre, n.Legajo, n.DNI, n.Correo);
                    }
                }
            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }     
        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        private void button7_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
        private void button8_Click(object sender, EventArgs e)
        {
            Form3 f = new Form3();
            f.Show();
            this.Hide();
        }

        //BOTON PARA ELIMINAR ALUMNO. 
        private void iconButton5_Click(object sender, EventArgs e)
        {

            if (nroComision == 0)
            {
                MessageBox.Show("Selecciona una comisión antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dataGridView1.Rows.Count > 0 && dataGridView1.CurrentRow != null)
            {
                int indice = dataGridView1.CurrentRow.Index;
                var lista = obj.Obcomision(nroComision);
                if (indice >= 0 && indice < lista.Count)
                {
                    lista.RemoveAt(indice);
                    dataGridView1.Rows.RemoveAt(indice);
                    MessageBox.Show("Alumno eliminado.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
        }

        private void placeholderTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


//PERSONALIZACION:para poder mover ventana
        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, 0xA1, 0x2, 0);
            }
        }
        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
           
        }
//PERSONALIZACION:Este es el panel de arriba del boton cerrar.
        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            panel3.MouseDown += Form2_MouseDown;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelfondo_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //COMISIONES BOTONES.
        private void comision1_Click(object sender, EventArgs e)
        {

        }
        private void btnComision_Click(object sender, EventArgs e)
        {
           IconButton btn = sender as IconButton;
            nroComision = Convert.ToInt32(btn.Tag);
           
            if (btn.IconColor == Color.FromArgb(101, 164, 171))
            {
                enviar(sender);
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();

                if (modoActual == "Alumnos")
                {
                    //Cargo columna
                    foreach (var n in obj.Ob8())
                    {
                        dataGridView1.Columns.Add(n.codigo, n.materia);
                    }
                    //Cargo filas
                    foreach (var alumno in obj.Obcomision(nroComision))
                    {
                        dataGridView1.Rows.Add(alumno.Nombre, alumno.Legajo, alumno.DNI, alumno.Correo);
                    }
                }
                else if (modoActual == "Notas")
                {
                    foreach (var n in obj1.colu())
                    {
                        dataGridView1.Columns.Add(n.codigo, n.materia);
                    }
                    foreach (var alumno in obj.Obcomision(nroComision))
                    {
                        dataGridView1.Rows.Add(alumno.Nombre);
                    }

                    int fila = 0;
                    foreach (var t in obj1.N())
                    {
                        dataGridView1.Rows[fila].Cells["Lengua"].Value = t.Lengua;
                        dataGridView1.Rows[fila].Cells["Ingles"].Value = t.Ingles;
                        dataGridView1.Rows[fila].Cells["Matematica"].Value = t.Matematica;
                        dataGridView1.Rows[fila].Cells["Economia"].Value = t.Economia;
                        dataGridView1.Rows[fila].Cells["Politica"].Value = t.Politica;
                        fila++;
                    }
                }
            }
            else
            {
              
                btn.IconColor = Color.FromArgb(101, 164, 171);
               

                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
            }
        }
        private void comision2_Click(object sender, EventArgs e)
        {
       
        }

        private void comision3_Click(object sender, EventArgs e)
        {
            
        }

        private void comision4_Click(object sender, EventArgs e)
        {
          
        }

        private void comision5_Click(object sender, EventArgs e)
        {
            
        }

        private void comision6_Click(object sender, EventArgs e)
        {
            
        }
        private void comision7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void panelcomision_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton4_Click_1(object sender, EventArgs e)
        {

            Random rnd = new Random();
            // Recorremos todas las filas
            for (int fila = 0; fila < dataGridView1.Rows.Count; fila++)

            {
                double n1 = rnd.Next(0, 11);
                double n2 = rnd.Next(0, 11);
                double n3 = rnd.Next(0, 11);
                double n4 = rnd.Next(0, 11);
                double n5 = rnd.Next(0, 11);
                dataGridView1.Rows[fila].Cells["Lengua"].Value = n1;
                dataGridView1.Rows[fila].Cells["Matematica"].Value = n2;
                dataGridView1.Rows[fila].Cells["Ingles"].Value = n3;
                dataGridView1.Rows[fila].Cells["Economia"].Value = n4;
                dataGridView1.Rows[fila].Cells["Politica"].Value = n5;
            }
        }

        private void panelformulario_Paint(object sender, PaintEventArgs e)
        {


        }

        //METODO GENERICO PARA ABRIR FORMULARIOS DENTRO DE UN PANEL.

        //private void Abrirform<MiForm>() where MiForm : Form, new()
        //{
        //    Form formulario;
        //    formulario = panel1.Controls.OfType < MiForm > ().FirstOrDefault();//Busca en la colección el form

        //    //si no existe

        //    if (formulario == null)
        //    {
        //        formulario = new MiForm();
        //        formulario.TopLevel = false;
        //        //formulario.Dock = DockStyle.Fill;
        //        panelformularios.Controls.Add(formulario);
        //        panelformularios.Tag = formulario;
        //        //formulario.FormBorderStyle = FormBorderStyle.None;
        //        formulario.Show();
        //        formulario.BringToFront();
        //    }
        //    else
        //    {
        //        formulario.BringToFront();
        //    }

    }
}
//Uso .nombre, .legajo, etc para llamar a cada dato de la tupla, pero porque en el metdo Obtener las llame asi. 
