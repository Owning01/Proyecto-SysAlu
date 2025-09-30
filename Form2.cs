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
        private List<(int comision, string nombre, int edad, int legajo, int DNI, string correo)> estudiantes;
        private void combos()
        {
            universidadbox.AddItem("UTN");
            universidadbox.AddItem("UNT");
            carrerabox.AddItem("Tecnicatura en Programacion");
            fechabox.AddItem("2025");
            añobox.AddItem("1er Año");
            comisionbox.AddItem("1");
            comisionbox.AddItem("2");
            comisionbox.AddItem("3");
            comisionbox.AddItem("4");
            comisionbox.AddItem("5");
            comisionbox.AddItem("6");
            comisionbox.AddItem("7");
        }
        public Form2()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            estudiantes = new List<(int comision, string nombre, int edad, int legajo, int DNI, string correo)>();

            borsup();
            //borde izquierdo para botones seleccionados en el panel izquierdo. 
            leftBorder = new Panel();
            leftBorder.Size = new Size(10, 83); 
            leftBorder.BackColor = Color.FromArgb(85, 28, 35);
            leftBorder.Visible = false;
            leftBorder.Anchor = AnchorStyles.Left;
            panel1.Controls.Add(leftBorder);

            //panel fondo
            
            // Tooltips
            toolTip1.SetToolTip(iconButton5, "Eliminar seleccion");
            toolTip1.SetToolTip(iconButton7, "Buscar por nombre, dni, o legajo.");

            //Esto es para el boton eliminar, para que no tire eer
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect; 
            dataGridView1.MultiSelect = false; 
            dataGridView1.AllowUserToAddRows = false;


            //Panel formuarlio para estadistica
            panelformulario.Visible = true;
            //Comboboxes.
            combos();
            ocultar1();
        }

        //borde superior
        private void borsup()
        {
            //Panel superior, con boton de cerrar nomas 
            panel3.Dock = DockStyle.Top;
            panel3.Height = 25;
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
            //boton adicional
            controlBox1.Dock = DockStyle.Right;
            panel3.Controls.Add(controlBox1);
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
            botonañadir.Visible = false;
            placeholderTextBox1.Visible = false;
        }

        //Mostrar botones del panel
        private void ocultar1 ()
        {
            unilabel.Visible = false;
            universidadbox.Visible = false;
            carrerabox.Visible = false;
            fechabox.Visible = false;
            añobox.Visible = false;
            comisionbox.Visible = false;
            iniciar.Visible = false;
            carrelabel.Visible = false;
            fechalabel.Visible = false;
            añolabel.Visible = false;
            comilabel.Visible = false;
        }  
        private void mostrar1()
        {
            unilabel.Visible = true;
            universidadbox.Visible = true;
            carrerabox.Visible = true;
            fechabox.Visible = true;
            añobox.Visible = true;
            comisionbox.Visible = true;
            iniciar.Visible = true;
            carrelabel.Visible = true;
            fechalabel.Visible = true;
            añolabel.Visible = true;
            comilabel.Visible = true;
        }


//Boton alumno 
        private void iconButton1_Click(object sender, EventArgs e)
        {
            mostrar1();
            modoActual = "Alumnos";
            if (iconButton1.IconColor == Color.FromArgb(101, 164, 171))
            {

                placeholderTextBox1.Visible = true;
                iconButton7.Visible = true;
                iconButton6.Visible = true;
                iconButton5.Visible = true;
                label1.Visible = false;
                pictureBox1.Visible = true;
                label2.Visible = true;
                botonañadir.Visible= true;
                pictureBox2.Visible = false;
                dataGridView1.Columns.Clear();
                dataGridView1.Rows.Clear();
                ocultarformulario();
                dataGridView1.Visible = true;
                enviar2(sender);
            }
            else
            {
               
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
                ocultarformulario();
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
            dataGridView1.Visible = true;

            //LIMPIAR DATAGRID
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            ocultarformulario();
        }
        //Funcion ocultar panel formularios. 
        private void ocultarformulario()
        {
            panelformulario.Controls.Clear();
            panelformulario.Controls.Add(dataGridView1);
        }

        //Funcion para abrir formulario desde el panel que quiera
        Form fh = new Form();
        private void AbrirFormHija(Form formhija)
        {
            if (this.panelformulario.Controls.Count > 0)
                this.panelformulario.Controls.RemoveAt(0);//Controla de que un formulario no haya sido abierto
            {
                fh = formhija;
                fh.TopLevel = false; //Indica que el formulario que se abrira, no sera el "admiN"
                fh.Dock = DockStyle.Fill;  
                this.panelformulario.Controls.Add(fh); //Añade el formulario al panel como si fuera un control 
                this.panelformulario.Tag = fh;
                fh.Show();
                //Personalizacion del panel
                panelformulario.BringToFront(); 
                panelformulario.BorderStyle = BorderStyle.None;
                panelformulario.BackColor = Color.White;
                panelformulario.Visible = true;
            }
        }
        //Funcion para ocultar en el boton estadistica lo que no quiero que se vea en el panel. 
        private void ocultarenestadistica()
        {
            placeholderTextBox1.Visible = false;
            iconButton7.Visible = false;
            iconButton6.Visible = false;
            iconButton5.Visible = false;
            pictureBox2.Visible = false;
            label1.Visible = false;
            botonañadir.Visible = false; 
            dataGridView1.Rows.Clear();
            dataGridView1.Columns.Clear();
            dataGridView1.Visible = false;
        }
        //Boton estadistica
        private void iconButton2_Click(object sender, EventArgs e)
        {
            if (iconButton2.IconColor == Color.FromArgb(101, 164, 171))
            {
                enviar2(sender);
                ocultarenestadistica();
                AbrirFormHija(new Form4());
            }
            else 
            {
                iconButton2.IconColor = Color.FromArgb(101, 164, 171);
                pictureBox2.Visible = true;
                label1.Visible = true;
                //cerrar el formulario 4 
                panelformulario.Controls.Clear();
                panelformulario.Visible = false;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            dataGridView1.Visible = true;

            var f = new Form3();
          
            if (f.ShowDialog() == DialogResult.OK)
            {
                estudiantes.Add(f.Estudiante);
                dataGridView1.Rows.Add(f.Estudiante.nombre, f.Estudiante.edad, f.Estudiante.legajo, f.Estudiante.DNI, f.Estudiante.correo);

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


        //COMISIONES BOTONES.
        private void iniciar_Click(object sender, EventArgs e)
        {
            
            dataGridView1.Visible = true;
            dataGridView1.BringToFront();
            string nur = universidadbox.SelectedItem;
            switch (nur)
            {
                case "UTN":
                    try
                    {
                        nroComision = int.Parse(comisionbox.SelectedItem);
                    }
                    catch
                    {
                        MessageBox.Show("Seleccione una comisión válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    btnComision();
                    break;
                case "UNT":
                    MessageBox.Show("No añadio nada aun. ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    btnComision();
                    break;
                default:
                    break;
            }

            }

        private void btnComision()
        {

            dataGridView1.Columns.Clear();
            dataGridView1.Rows.Clear();
            iniciar.ColorBackground = Color.DarkOliveGreen;

            if (modoActual == "Alumnos")
            {
                //Cargo columna
                foreach (var n in obj.Ob8())
                {
                    dataGridView1.Columns.Add(n.codigo, n.campo);
                }
                //Cargo filas
                foreach (var alumno in obj.Obcomision(nroComision))
                {
                    dataGridView1.Rows.Add(alumno.Nombre, alumno.edad, alumno.Legajo, alumno.DNI, alumno.Correo);
                }
            }
            else if (modoActual == "Notas")
            {
                foreach (var p in obj1.colu())
                {
                    dataGridView1.Columns.Add(p.codigo, p.campo);// columnas 
                }
                foreach (var alumno in obj.Obcomision(nroComision))
                {
                    dataGridView1.Rows.Add(alumno.Nombre); //Añado todaslasfilas de cada nombre.
                }
                int fila = 0;
                foreach (var t in obj1.Nota(nroComision))
                {
                    dataGridView1.Rows[fila].Cells["Lengua"].Value = t.Lengua;
                    dataGridView1.Rows[fila].Cells["Ingles"].Value = t.Ingles;
                    dataGridView1.Rows[fila].Cells["Matematica"].Value = t.Matematica;
                    dataGridView1.Rows[fila].Cells["Economia"].Value = t.Economia;
                    dataGridView1.Rows[fila].Cells["Politica"].Value = t.Politica;
                    dataGridView1.Rows[fila].Cells["Asistencia"].Value = t.Asistencia;
                    fila++;
                }
            }
        }
     
       
 
        private void panelformulario_Paint(object sender, PaintEventArgs e)
        {
        }

        private void universidadbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
//Uso .nombre, .legajo, etc para llamar a cada dato de la tupla, pero porque en el metdo Obtener las llame asi. 
