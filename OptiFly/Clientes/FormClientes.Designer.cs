namespace OptiFly
{
    partial class FormClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BtnModificar = new System.Windows.Forms.Button();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.BtnAgregar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.domicilio = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.telefono = new System.Windows.Forms.TextBox();
            this.idcliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.GbOpcion = new System.Windows.Forms.GroupBox();
            this.RbModificar = new System.Windows.Forms.RadioButton();
            this.RbEliminar = new System.Windows.Forms.RadioButton();
            this.RbInsertar = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.butnum = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.buttele = new System.Windows.Forms.Button();
            this.butfec = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.GbOpcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnModificar
            // 
            resources.ApplyResources(this.BtnModificar, "BtnModificar");
            this.BtnModificar.FlatAppearance.BorderSize = 0;
            this.BtnModificar.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtnModificar.Name = "BtnModificar";
            this.BtnModificar.UseVisualStyleBackColor = true;
            this.BtnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // BtnEliminar
            // 
            resources.ApplyResources(this.BtnEliminar, "BtnEliminar");
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.UseVisualStyleBackColor = true;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // BtnAgregar
            // 
            resources.ApplyResources(this.BtnAgregar, "BtnAgregar");
            this.BtnAgregar.FlatAppearance.BorderSize = 0;
            this.BtnAgregar.Name = "BtnAgregar";
            this.BtnAgregar.UseVisualStyleBackColor = true;
            this.BtnAgregar.Click += new System.EventHandler(this.BtnAgregar_Click_1);
            // 
            // label5
            // 
            resources.ApplyResources(this.label5, "label5");
            this.label5.Name = "label5";
            // 
            // domicilio
            // 
            resources.ApplyResources(this.domicilio, "domicilio");
            this.domicilio.Name = "domicilio";
            this.domicilio.TextChanged += new System.EventHandler(this.domicilio_TextChanged);
            // 
            // txtnombre
            // 
            resources.ApplyResources(this.txtnombre, "txtnombre");
            this.txtnombre.Name = "txtnombre";
            // 
            // telefono
            // 
            resources.ApplyResources(this.telefono, "telefono");
            this.telefono.Name = "telefono";
            this.telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // idcliente
            // 
            resources.ApplyResources(this.idcliente, "idcliente");
            this.idcliente.Name = "idcliente";
            this.idcliente.TextChanged += new System.EventHandler(this.txtId_TextChanged);
            this.idcliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtId_KeyPress);
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // fecha
            // 
            resources.ApplyResources(this.fecha, "fecha");
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Name = "fecha";
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToOrderColumns = true;
            resources.ApplyResources(this.dgv, "dgv");
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgv.Name = "dgv";
            this.dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellContentClick);
            // 
            // GbOpcion
            // 
            resources.ApplyResources(this.GbOpcion, "GbOpcion");
            this.GbOpcion.Controls.Add(this.RbModificar);
            this.GbOpcion.Controls.Add(this.RbEliminar);
            this.GbOpcion.Controls.Add(this.RbInsertar);
            this.GbOpcion.Name = "GbOpcion";
            this.GbOpcion.TabStop = false;
            this.GbOpcion.Enter += new System.EventHandler(this.GbOpcion_Enter);
            // 
            // RbModificar
            // 
            resources.ApplyResources(this.RbModificar, "RbModificar");
            this.RbModificar.Name = "RbModificar";
            this.RbModificar.TabStop = true;
            this.RbModificar.UseVisualStyleBackColor = true;
            this.RbModificar.CheckedChanged += new System.EventHandler(this.RbModificar_CheckedChanged);
            // 
            // RbEliminar
            // 
            resources.ApplyResources(this.RbEliminar, "RbEliminar");
            this.RbEliminar.Name = "RbEliminar";
            this.RbEliminar.TabStop = true;
            this.RbEliminar.UseVisualStyleBackColor = true;
            this.RbEliminar.CheckedChanged += new System.EventHandler(this.RbEliminar_CheckedChanged_1);
            // 
            // RbInsertar
            // 
            resources.ApplyResources(this.RbInsertar, "RbInsertar");
            this.RbInsertar.Name = "RbInsertar";
            this.RbInsertar.TabStop = true;
            this.RbInsertar.UseVisualStyleBackColor = true;
            this.RbInsertar.CheckedChanged += new System.EventHandler(this.RbInsertar_CheckedChanged_1);
            // 
            // button1
            // 
            resources.ApplyResources(this.button1, "button1");
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Name = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // butnum
            // 
            resources.ApplyResources(this.butnum, "butnum");
            this.butnum.FlatAppearance.BorderSize = 0;
            this.butnum.Name = "butnum";
            this.butnum.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            resources.ApplyResources(this.button5, "button5");
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.Name = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // buttele
            // 
            resources.ApplyResources(this.buttele, "buttele");
            this.buttele.FlatAppearance.BorderSize = 0;
            this.buttele.Name = "buttele";
            this.buttele.UseVisualStyleBackColor = true;
            // 
            // butfec
            // 
            resources.ApplyResources(this.butfec, "butfec");
            this.butfec.FlatAppearance.BorderSize = 0;
            this.butfec.Name = "butfec";
            this.butfec.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            resources.ApplyResources(this.button6, "button6");
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Name = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // FormClientes
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.button6);
            this.Controls.Add(this.butfec);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.buttele);
            this.Controls.Add(this.butnum);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BtnModificar);
            this.Controls.Add(this.BtnEliminar);
            this.Controls.Add(this.BtnAgregar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.domicilio);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.telefono);
            this.Controls.Add(this.idcliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.GbOpcion);
            this.Name = "FormClientes";
            this.Opacity = 0.98D;
            this.Load += new System.EventHandler(this.FormClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.GbOpcion.ResumeLayout(false);
            this.GbOpcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button BtnAgregar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox domicilio;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox telefono;
        private System.Windows.Forms.TextBox idcliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.GroupBox GbOpcion;
        private System.Windows.Forms.RadioButton RbModificar;
        private System.Windows.Forms.RadioButton RbEliminar;
        private System.Windows.Forms.RadioButton RbInsertar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button butnum;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button buttele;
        private System.Windows.Forms.Button butfec;
        private System.Windows.Forms.Button button6;
    }
}