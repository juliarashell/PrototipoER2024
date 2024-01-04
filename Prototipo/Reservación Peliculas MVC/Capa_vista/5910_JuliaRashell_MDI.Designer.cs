
namespace Vista_PrototipoMenu
{
    partial class frmChequeo
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
            this.btn_status = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboRes = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.txt_descripcion = new System.Windows.Forms.TextBox();
            this.lbl_descripcion = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_estado_c = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboEmp = new System.Windows.Forms.ComboBox();
            this.ch_entrada = new System.Windows.Forms.CheckBox();
            this.ch_salida = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.catálogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.informesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.herramientasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_status
            // 
            this.btn_status.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_status.FlatAppearance.BorderSize = 0;
            this.btn_status.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_status.Location = new System.Drawing.Point(187, 211);
            this.btn_status.Margin = new System.Windows.Forms.Padding(4);
            this.btn_status.Name = "btn_status";
            this.btn_status.Size = new System.Drawing.Size(21, 12);
            this.btn_status.TabIndex = 77;
            this.btn_status.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Location = new System.Drawing.Point(37, 179);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(172, 25);
            this.textBox1.TabIndex = 76;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Nombre Alumno";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(259, 159);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 17);
            this.label9.TabIndex = 79;
            this.label9.Text = "Carrera";
            // 
            // comboRes
            // 
            this.comboRes.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboRes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboRes.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboRes.FormattingEnabled = true;
            this.comboRes.Location = new System.Drawing.Point(263, 178);
            this.comboRes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboRes.Name = "comboRes";
            this.comboRes.Size = new System.Drawing.Size(171, 24);
            this.comboRes.TabIndex = 78;
            this.comboRes.SelectedIndexChanged += new System.EventHandler(this.comboRes_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.ForestGreen;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(708, 410);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 44);
            this.button1.TabIndex = 80;
            this.button1.Text = "Realizar Asignación";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_descripcion.Location = new System.Drawing.Point(36, 358);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(4);
            this.txt_descripcion.Multiline = true;
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(291, 79);
            this.txt_descripcion.TabIndex = 82;
            this.txt_descripcion.Tag = "eva_descripcion";
            // 
            // lbl_descripcion
            // 
            this.lbl_descripcion.AutoSize = true;
            this.lbl_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_descripcion.Location = new System.Drawing.Point(33, 325);
            this.lbl_descripcion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_descripcion.Name = "lbl_descripcion";
            this.lbl_descripcion.Size = new System.Drawing.Size(232, 17);
            this.lbl_descripcion.TabIndex = 81;
            this.lbl_descripcion.Text = "Descripcion Asignacion Cursos";
            this.lbl_descripcion.Click += new System.EventHandler(this.lbl_descripcion_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(717, 276);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 22);
            this.dateTimePicker1.TabIndex = 83;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(713, 257);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 17);
            this.label1.TabIndex = 84;
            this.label1.Text = "Fecha Asignación";
            // 
            // txt_estado_c
            // 
            this.txt_estado_c.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.txt_estado_c.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_estado_c.Location = new System.Drawing.Point(446, 277);
            this.txt_estado_c.Margin = new System.Windows.Forms.Padding(4);
            this.txt_estado_c.Multiline = true;
            this.txt_estado_c.Name = "txt_estado_c";
            this.txt_estado_c.Size = new System.Drawing.Size(172, 25);
            this.txt_estado_c.TabIndex = 86;
            this.txt_estado_c.TextChanged += new System.EventHandler(this.txt_estado_c_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(442, 258);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 17);
            this.label3.TabIndex = 85;
            this.label3.Text = "Jornada";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(443, 344);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 17);
            this.label4.TabIndex = 88;
            this.label4.Text = "Curso a Asignar";
            // 
            // comboEmp
            // 
            this.comboEmp.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboEmp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboEmp.FormattingEnabled = true;
            this.comboEmp.Location = new System.Drawing.Point(447, 363);
            this.comboEmp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboEmp.Name = "comboEmp";
            this.comboEmp.Size = new System.Drawing.Size(169, 24);
            this.comboEmp.TabIndex = 87;
            this.comboEmp.SelectedIndexChanged += new System.EventHandler(this.comboEmp_SelectedIndexChanged);
            // 
            // ch_entrada
            // 
            this.ch_entrada.AutoSize = true;
            this.ch_entrada.Location = new System.Drawing.Point(716, 178);
            this.ch_entrada.Margin = new System.Windows.Forms.Padding(4);
            this.ch_entrada.Name = "ch_entrada";
            this.ch_entrada.Size = new System.Drawing.Size(80, 21);
            this.ch_entrada.TabIndex = 89;
            this.ch_entrada.Text = "Entrada";
            this.ch_entrada.UseVisualStyleBackColor = true;
            this.ch_entrada.CheckedChanged += new System.EventHandler(this.ch_entrada_CheckedChanged);
            // 
            // ch_salida
            // 
            this.ch_salida.AutoSize = true;
            this.ch_salida.Location = new System.Drawing.Point(855, 176);
            this.ch_salida.Margin = new System.Windows.Forms.Padding(4);
            this.ch_salida.Name = "ch_salida";
            this.ch_salida.Size = new System.Drawing.Size(69, 21);
            this.ch_salida.TabIndex = 90;
            this.ch_salida.Text = "Salida";
            this.ch_salida.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catálogosToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.informesToolStripMenuItem,
            this.herramientasToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.menuStrip1.Size = new System.Drawing.Size(961, 30);
            this.menuStrip1.TabIndex = 91;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // catálogosToolStripMenuItem
            // 
            this.catálogosToolStripMenuItem.Name = "catálogosToolStripMenuItem";
            this.catálogosToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.catálogosToolStripMenuItem.Text = "Catálogos";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // informesToolStripMenuItem
            // 
            this.informesToolStripMenuItem.Name = "informesToolStripMenuItem";
            this.informesToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.informesToolStripMenuItem.Text = "Informes";
            // 
            // herramientasToolStripMenuItem
            // 
            this.herramientasToolStripMenuItem.Name = "herramientasToolStripMenuItem";
            this.herramientasToolStripMenuItem.Size = new System.Drawing.Size(112, 26);
            this.herramientasToolStripMenuItem.Text = "Herramientas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 26);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(182, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(377, 29);
            this.label5.TabIndex = 92;
            this.label5.Text = "Asignación De Cursos Alumnos";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(442, 159);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 94;
            this.label6.Text = "Sede";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(446, 178);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(171, 24);
            this.comboBox1.TabIndex = 93;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // frmChequeo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.ch_salida);
            this.Controls.Add(this.ch_entrada);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboEmp);
            this.Controls.Add(this.txt_estado_c);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lbl_descripcion);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboRes);
            this.Controls.Add(this.btn_status);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChequeo";
            this.Text = "5910_Julia Rashell_MDI";
            this.Load += new System.EventHandler(this.frmChequeo_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_status;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboRes;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_descripcion;
        private System.Windows.Forms.Label lbl_descripcion;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_estado_c;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboEmp;
        private System.Windows.Forms.CheckBox ch_entrada;
        private System.Windows.Forms.CheckBox ch_salida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem catálogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem informesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem herramientasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}