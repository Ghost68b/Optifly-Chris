namespace OptiFly
{
    partial class Usuarios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label6 = new System.Windows.Forms.Label();
            this.TipoUsuario = new System.Windows.Forms.ComboBox();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpFecha = new System.Windows.Forms.DateTimePicker();
            this.DgvPersonas = new System.Windows.Forms.DataGridView();
            this.GbOpcion = new System.Windows.Forms.GroupBox();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            this.butfech = new System.Windows.Forms.Button();
            this.butnom = new System.Windows.Forms.Button();
            this.butnum = new System.Windows.Forms.Button();
            this.butusu = new System.Windows.Forms.Button();
            this.butcont = new System.Windows.Forms.Button();
            this.butadmi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).BeginInit();
            this.GbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 16);
            this.label6.TabIndex = 36;
            this.label6.Text = "Tipo de Usuario";
            // 
            // TipoUsuario
            // 
            this.TipoUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TipoUsuario.FormattingEnabled = true;
            this.TipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Basico"});
            this.TipoUsuario.Location = new System.Drawing.Point(65, 172);
            this.TipoUsuario.Name = "TipoUsuario";
            this.TipoUsuario.Size = new System.Drawing.Size(176, 21);
            this.TipoUsuario.TabIndex = 42;
            // 
            // BtnModificar
            // 
            this.BtnModificar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnModificar.Image = ((System.Drawing.Image)(resources.GetObject("BtnModificar.Image")));
            this.BtnModificar.Location = new System.Drawing.Point(508, 211);
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.Size = new System.Drawing.Size(75, 75);
            this.BtnModificar.TabIndex = 48;
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("BtnEliminar.Image")));
            this.BtnEliminar.Location = new System.Drawing.Point(346, 205);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(75, 79);
            this.BtnEliminar.TabIndex = 46;
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            this.BtnAgregar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("BtnAgregar.Image")));
            this.BtnAgregar.Location = new System.Drawing.Point(189, 208);
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.Size = new System.Drawing.Size(75, 76);
            this.BtnAgregar.TabIndex = 45;
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(330, 141);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 37;
            this.label5.Text = "Contraseña";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtPassword.Location = new System.Drawing.Point(328, 169);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(135, 20);
            this.txtPassword.TabIndex = 43;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtUsuario.Location = new System.Drawing.Point(514, 102);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(195, 20);
            this.txtUsuario.TabIndex = 41;
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.Location = new System.Drawing.Point(328, 102);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(135, 20);
            this.txtNombre.TabIndex = 40;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtId
            // 
            this.txtId.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtId.Location = new System.Drawing.Point(65, 102);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(176, 20);
            this.txtId.TabIndex = 39;
            this.txtId.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.txtId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(564, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(564, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 16);
            this.label3.TabIndex = 35;
            this.label3.Text = "Usuario";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(335, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 33;
            this.label1.Text = "Numero de Control";
            // 
            // dtpFecha
            // 
            this.dtpFecha.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpFecha.Location = new System.Drawing.Point(514, 169);
            this.dtpFecha.Name = "dtpFecha";
            this.dtpFecha.Size = new System.Drawing.Size(195, 20);
            this.dtpFecha.TabIndex = 44;
            this.dtpFecha.ValueChanged += new System.EventHandler(this.dtpFecha_ValueChanged);
            // 
            // DgvPersonas
            // 
            this.DgvPersonas.AllowUserToAddRows = false;
            this.DgvPersonas.AllowUserToDeleteRows = false;
            this.DgvPersonas.AllowUserToOrderColumns = true;
            this.DgvPersonas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvPersonas.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvPersonas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvPersonas.DefaultCellStyle = dataGridViewCellStyle2;
            this.DgvPersonas.Location = new System.Drawing.Point(21, 290);
            this.DgvPersonas.Name = "DgvPersonas";
            this.DgvPersonas.Size = new System.Drawing.Size(760, 199);
            this.DgvPersonas.TabIndex = 49;
            // 
            // GbOpcion
            // 
            this.GbOpcion.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.GbOpcion.Controls.Add(this.RbModificar);
            this.GbOpcion.Controls.Add(this.RbEliminar);
            this.GbOpcion.Controls.Add(this.RbInsertar);
            this.GbOpcion.Location = new System.Drawing.Point(188, 0);
            this.GbOpcion.Name = "GbOpcion";
            this.GbOpcion.Size = new System.Drawing.Size(394, 57);
            this.GbOpcion.TabIndex = 47;
            this.GbOpcion.TabStop = false;
            this.GbOpcion.Text = "Administrador de Usuarios";
            // 
            // RbModificar
            // 
            this.RbModificar.AutoSize = true;
            this.RbModificar.Location = new System.Drawing.Point(246, 20);
            this.RbModificar.Name = "RbModificar";
            this.RbModificar.Size = new System.Drawing.Size(68, 17);
            this.RbModificar.TabIndex = 2;
            this.RbModificar.TabStop = true;
            this.RbModificar.Text = "Modificar";
            this.RbModificar.UseVisualStyleBackColor = true;
            this.RbModificar.CheckedChanged += new System.EventHandler(this.RbModificar_CheckedChanged);
            // 
            // RbEliminar
            // 
            this.RbEliminar.AutoSize = true;
            this.RbEliminar.Location = new System.Drawing.Point(129, 20);
            this.RbEliminar.Name = "RbEliminar";
            this.RbEliminar.Size = new System.Drawing.Size(61, 17);
            this.RbEliminar.TabIndex = 1;
            this.RbEliminar.TabStop = true;
            this.RbEliminar.Text = "Eliminar";
            this.RbEliminar.UseVisualStyleBackColor = true;
            this.RbEliminar.CheckedChanged += new System.EventHandler(this.RbEliminar_CheckedChanged);
            // 
            // RbInsertar
            // 
            this.RbInsertar.AutoSize = true;
            this.RbInsertar.Location = new System.Drawing.Point(7, 20);
            this.RbInsertar.Name = "RbInsertar";
            this.RbInsertar.Size = new System.Drawing.Size(67, 17);
            this.RbInsertar.TabIndex = 0;
            this.RbInsertar.TabStop = true;
            this.RbInsertar.Text = "Registrar";
            this.RbInsertar.UseVisualStyleBackColor = true;
            this.RbInsertar.CheckedChanged += new System.EventHandler(this.RbInsertar_CheckedChanged);
            // 
            // butfech
            // 
            this.butfech.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butfech.FlatAppearance.BorderSize = 0;
            this.butfech.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butfech.Image = ((System.Drawing.Image)(resources.GetObject("butfech.Image")));
            this.butfech.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butfech.Location = new System.Drawing.Point(620, 132);
            this.butfech.Name = "butfech";
            this.butfech.Size = new System.Drawing.Size(37, 31);
            this.butfech.TabIndex = 92;
            this.butfech.UseVisualStyleBackColor = true;
            // 
            // butnom
            // 
            this.butnom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnom.FlatAppearance.BorderSize = 0;
            this.butnom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnom.Image = ((System.Drawing.Image)(resources.GetObject("butnom.Image")));
            this.butnom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butnom.Location = new System.Drawing.Point(399, 59);
            this.butnom.Name = "butnom";
            this.butnom.Size = new System.Drawing.Size(41, 35);
            this.butnom.TabIndex = 91;
            this.butnom.UseVisualStyleBackColor = true;
            // 
            // butnum
            // 
            this.butnum.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butnum.FlatAppearance.BorderSize = 0;
            this.butnum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butnum.Image = ((System.Drawing.Image)(resources.GetObject("butnum.Image")));
            this.butnum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butnum.Location = new System.Drawing.Point(204, 65);
            this.butnum.Name = "butnum";
            this.butnum.Size = new System.Drawing.Size(37, 31);
            this.butnum.TabIndex = 89;
            this.butnum.UseVisualStyleBackColor = true;
            // 
            // butusu
            // 
            this.butusu.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butusu.FlatAppearance.BorderSize = 0;
            this.butusu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butusu.Image = ((System.Drawing.Image)(resources.GetObject("butusu.Image")));
            this.butusu.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butusu.Location = new System.Drawing.Point(627, 59);
            this.butusu.Name = "butusu";
            this.butusu.Size = new System.Drawing.Size(41, 35);
            this.butusu.TabIndex = 93;
            this.butusu.UseVisualStyleBackColor = true;
            // 
            // butcont
            // 
            this.butcont.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butcont.FlatAppearance.BorderSize = 0;
            this.butcont.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butcont.Image = ((System.Drawing.Image)(resources.GetObject("butcont.Image")));
            this.butcont.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butcont.Location = new System.Drawing.Point(422, 128);
            this.butcont.Name = "butcont";
            this.butcont.Size = new System.Drawing.Size(41, 35);
            this.butcont.TabIndex = 94;
            this.butcont.UseVisualStyleBackColor = true;
            // 
            // butadmi
            // 
            this.butadmi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butadmi.FlatAppearance.BorderSize = 0;
            this.butadmi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butadmi.Image = ((System.Drawing.Image)(resources.GetObject("butadmi.Image")));
            this.butadmi.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.butadmi.Location = new System.Drawing.Point(187, 128);
            this.butadmi.Name = "butadmi";
            this.butadmi.Size = new System.Drawing.Size(41, 35);
            this.butadmi.TabIndex = 95;
            this.butadmi.UseVisualStyleBackColor = true;
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 511);
            this.Controls.Add(this.butadmi);
            this.Controls.Add(this.butcont);
            this.Controls.Add(this.butusu);
            this.Controls.Add(this.butfech);
            this.Controls.Add(this.butnom);
            this.Controls.Add(this.butnum);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TipoUsuario);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFecha);
            this.Controls.Add(this.DgvPersonas);
            this.Controls.Add(this.GbOpcion);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Usuarios";
            this.Opacity = 0.98D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvPersonas)).EndInit();
            this.GbOpcion.ResumeLayout(false);
            this.GbOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TipoUsuario;
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpFecha;
        private System.Windows.Forms.DataGridView DgvPersonas;
        private System.Windows.Forms.GroupBox GbOpcion;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbInsertar;
        private System.Windows.Forms.Button butfech;
        private System.Windows.Forms.Button butnom;
        private System.Windows.Forms.Button butnum;
        private System.Windows.Forms.Button butusu;
        private System.Windows.Forms.Button butcont;
        private System.Windows.Forms.Button butadmi;
    }
}