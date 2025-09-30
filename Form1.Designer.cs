namespace SistemaParcial2OctavioGonzalez
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.iniciar = new ReaLTaiizor.Controls.CyberButton();
            this.contraseña = new CuoreUI.Controls.cuiTextBox();
            this.usuario = new CuoreUI.Controls.cuiTextBox();
            this.iconButton6 = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.controlBox1 = new ReaLTaiizor.Controls.ControlBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(164)))), ((int)(((byte)(171)))));
            this.button3.Location = new System.Drawing.Point(416, 152);
            this.button3.Margin = new System.Windows.Forms.Padding(2);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(178, 59);
            this.button3.TabIndex = 13;
            this.button3.Text = "Ir a form2";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(164)))), ((int)(((byte)(171)))));
            this.button4.Location = new System.Drawing.Point(536, 804);
            this.button4.Margin = new System.Windows.Forms.Padding(2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(89, 31);
            this.button4.TabIndex = 15;
            this.button4.Text = "Ir a form3";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(164)))), ((int)(((byte)(171)))));
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(536, 838);
            this.button5.Margin = new System.Windows.Forms.Padding(2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(89, 31);
            this.button5.TabIndex = 16;
            this.button5.Text = "Ir a form4";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SistemaParcial2OctavioGonzalez.Properties.Resources.alumno;
            this.pictureBox1.Location = new System.Drawing.Point(250, 32);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(148, 145);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.iniciar);
            this.panel1.Controls.Add(this.contraseña);
            this.panel1.Controls.Add(this.usuario);
            this.panel1.Controls.Add(this.iconButton6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(1, 223);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(632, 423);
            this.panel1.TabIndex = 29;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(283, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 35;
            this.label1.Text = "LOGIN";
            // 
            // iniciar
            // 
            this.iniciar.Alpha = 20;
            this.iniciar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iniciar.BackColor = System.Drawing.Color.Transparent;
            this.iniciar.Background = true;
            this.iniciar.Background_WidthPen = 4F;
            this.iniciar.BackgroundPen = true;
            this.iniciar.ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(171)))), ((int)(((byte)(148)))));
            this.iniciar.ColorBackground_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.iniciar.ColorBackground_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.iniciar.ColorBackground_Pen = System.Drawing.Color.DarkOliveGreen;
            this.iniciar.ColorLighting = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.iniciar.ColorPen_1 = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(52)))), ((int)(((byte)(68)))));
            this.iniciar.ColorPen_2 = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(63)))), ((int)(((byte)(86)))));
            this.iniciar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            this.iniciar.Effect_1 = true;
            this.iniciar.Effect_1_ColorBackground = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(200)))), ((int)(((byte)(238)))));
            this.iniciar.Effect_1_Transparency = 25;
            this.iniciar.Effect_2 = true;
            this.iniciar.Effect_2_ColorBackground = System.Drawing.Color.White;
            this.iniciar.Effect_2_Transparency = 20;
            this.iniciar.Font = new System.Drawing.Font("Arial", 12F);
            this.iniciar.ForeColor = System.Drawing.Color.Black;
            this.iniciar.Lighting = false;
            this.iniciar.LinearGradient_Background = false;
            this.iniciar.LinearGradientPen = false;
            this.iniciar.Location = new System.Drawing.Point(205, 345);
            this.iniciar.Name = "iniciar";
            this.iniciar.PenWidth = 15;
            this.iniciar.Rounding = true;
            this.iniciar.RoundingInt = 70;
            this.iniciar.Size = new System.Drawing.Size(235, 50);
            this.iniciar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.iniciar.TabIndex = 32;
            this.iniciar.Tag = "Cyber";
            this.iniciar.TextButton = "Iniciar Sesión";
            this.iniciar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.iniciar.Timer_Effect_1 = 5;
            this.iniciar.Timer_RGB = 300;
            this.iniciar.Click += new System.EventHandler(this.cyberButton1_Click);
            // 
            // contraseña
            // 
            this.contraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.contraseña.BackColor = System.Drawing.Color.Transparent;
            this.contraseña.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.contraseña.Content = "";
            this.contraseña.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.contraseña.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.contraseña.FocusImageTint = System.Drawing.Color.Black;
            this.contraseña.FocusOutlineColor = System.Drawing.Color.Black;
            this.contraseña.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseña.ForeColor = System.Drawing.Color.Black;
            this.contraseña.Image = null;
            this.contraseña.ImageExpand = new System.Drawing.Point(0, 0);
            this.contraseña.ImageOffset = new System.Drawing.Point(0, 0);
            this.contraseña.Location = new System.Drawing.Point(153, 266);
            this.contraseña.Margin = new System.Windows.Forms.Padding(4);
            this.contraseña.Multiline = false;
            this.contraseña.Name = "contraseña";
            this.contraseña.NormalImageTint = System.Drawing.Color.White;
            this.contraseña.OutlineColor = System.Drawing.Color.Black;
            this.contraseña.Padding = new System.Windows.Forms.Padding(16, 6, 16, 0);
            this.contraseña.PasswordChar = true;
            this.contraseña.PlaceholderColor = System.Drawing.Color.Gray;
            this.contraseña.PlaceholderText = "Contraseña";
            this.contraseña.Rounding = new System.Windows.Forms.Padding(8);
            this.contraseña.Size = new System.Drawing.Size(347, 28);
            this.contraseña.TabIndex = 31;
            this.contraseña.TextOffset = new System.Drawing.Size(0, 0);
            this.contraseña.UnderlinedStyle = true;
            // 
            // usuario
            // 
            this.usuario.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usuario.BackColor = System.Drawing.Color.Transparent;
            this.usuario.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.usuario.Content = "";
            this.usuario.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.usuario.FocusBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.usuario.FocusImageTint = System.Drawing.Color.Black;
            this.usuario.FocusOutlineColor = System.Drawing.Color.Black;
            this.usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usuario.ForeColor = System.Drawing.Color.Black;
            this.usuario.Image = null;
            this.usuario.ImageExpand = new System.Drawing.Point(0, 0);
            this.usuario.ImageOffset = new System.Drawing.Point(0, 0);
            this.usuario.Location = new System.Drawing.Point(153, 176);
            this.usuario.Margin = new System.Windows.Forms.Padding(4);
            this.usuario.Multiline = false;
            this.usuario.Name = "usuario";
            this.usuario.NormalImageTint = System.Drawing.Color.White;
            this.usuario.OutlineColor = System.Drawing.Color.Black;
            this.usuario.Padding = new System.Windows.Forms.Padding(16, 6, 16, 0);
            this.usuario.PasswordChar = false;
            this.usuario.PlaceholderColor = System.Drawing.Color.Gray;
            this.usuario.PlaceholderText = "Usuario";
            this.usuario.Rounding = new System.Windows.Forms.Padding(8);
            this.usuario.Size = new System.Drawing.Size(347, 28);
            this.usuario.TabIndex = 30;
            this.usuario.TextOffset = new System.Drawing.Size(0, 0);
            this.usuario.UnderlinedStyle = true;
            // 
            // iconButton6
            // 
            this.iconButton6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.iconButton6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.iconButton6.FlatAppearance.BorderSize = 0;
            this.iconButton6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton6.ForeColor = System.Drawing.Color.White;
            this.iconButton6.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconButton6.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(164)))), ((int)(((byte)(171)))));
            this.iconButton6.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton6.IconSize = 25;
            this.iconButton6.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton6.Location = new System.Drawing.Point(518, 271);
            this.iconButton6.Margin = new System.Windows.Forms.Padding(2);
            this.iconButton6.Name = "iconButton6";
            this.iconButton6.Padding = new System.Windows.Forms.Padding(8, 0, 15, 0);
            this.iconButton6.Size = new System.Drawing.Size(44, 23);
            this.iconButton6.TabIndex = 29;
            this.iconButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.iconButton6.UseVisualStyleBackColor = false;
            this.iconButton6.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(58)))), ((int)(((byte)(68)))));
            this.label3.Font = new System.Drawing.Font("Cascadia Mono SemiBold", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(196, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 52);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bienvenido";
            // 
            // controlBox1
            // 
            this.controlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.controlBox1.CloseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(17)))), ((int)(((byte)(35)))));
            this.controlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.controlBox1.DefaultLocation = true;
            this.controlBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlBox1.EnableHoverHighlight = true;
            this.controlBox1.EnableMaximizeButton = true;
            this.controlBox1.EnableMinimizeButton = true;
            this.controlBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(155)))));
            this.controlBox1.Location = new System.Drawing.Point(544, 0);
            this.controlBox1.MaximizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.controlBox1.MinimizeHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(65)))));
            this.controlBox1.Name = "controlBox1";
            this.controlBox1.Size = new System.Drawing.Size(90, 25);
            this.controlBox1.TabIndex = 32;
            this.controlBox1.Text = "controlBox1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(87)))), ((int)(((byte)(91)))));
            this.ClientSize = new System.Drawing.Size(634, 886);
            this.ControlBox = false;
            this.Controls.Add(this.controlBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " SysAlu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton iconButton6;
        private ReaLTaiizor.Controls.ControlBox controlBox1;
        private CuoreUI.Controls.cuiTextBox usuario;
        private CuoreUI.Controls.cuiTextBox contraseña;
        private ReaLTaiizor.Controls.CyberButton iniciar;
        private System.Windows.Forms.Label label1;
    }
}

