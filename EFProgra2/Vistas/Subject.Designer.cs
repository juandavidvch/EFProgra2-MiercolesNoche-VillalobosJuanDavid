﻿namespace EFProgra2
{
    partial class Subject
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
            this.components = new System.ComponentModel.Container();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboProfesor = new System.Windows.Forms.ComboBox();
            this.profesorBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bd_colegioDataSet = new EFProgra2.bd_colegioDataSet();
            this.profesorBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIDMateria = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profesorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.profesorBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.materiaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.profesorTableAdapter = new EFProgra2.bd_colegioDataSetTableAdapters.profesorTableAdapter();
            this.button6 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_colegioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(541, 131);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Eliminar";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(460, 172);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Actualizar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(460, 131);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Editar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 131);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Nuevo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(346, 190);
            this.dataGridView1.TabIndex = 5;
            // 
            // comboProfesor
            // 
            this.comboProfesor.DataSource = this.profesorBindingSource4;
            this.comboProfesor.DisplayMember = "id_profesor";
            this.comboProfesor.FormattingEnabled = true;
            this.comboProfesor.Location = new System.Drawing.Point(460, 93);
            this.comboProfesor.Name = "comboProfesor";
            this.comboProfesor.Size = new System.Drawing.Size(121, 21);
            this.comboProfesor.TabIndex = 31;
            this.comboProfesor.ValueMember = "id_profesor";
            // 
            // profesorBindingSource4
            // 
            this.profesorBindingSource4.DataMember = "profesor";
            this.profesorBindingSource4.DataSource = this.bd_colegioDataSet;
            // 
            // bd_colegioDataSet
            // 
            this.bd_colegioDataSet.DataSetName = "bd_colegioDataSet";
            this.bd_colegioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(460, 52);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 30;
            // 
            // txtIDMateria
            // 
            this.txtIDMateria.Location = new System.Drawing.Point(460, 23);
            this.txtIDMateria.Name = "txtIDMateria";
            this.txtIDMateria.Size = new System.Drawing.Size(100, 20);
            this.txtIDMateria.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(373, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Profesor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(373, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "ID Materia";
            // 
            // profesorTableAdapter
            // 
            this.profesorTableAdapter.ClearBeforeFill = true;
            // 
            // button6
            // 
            this.button6.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button6.Location = new System.Drawing.Point(580, 17);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(56, 31);
            this.button6.TabIndex = 32;
            this.button6.Text = "Buscar";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // Subject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 240);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.comboProfesor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.txtIDMateria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Subject";
            this.Text = "Subject";
            this.Load += new System.EventHandler(this.Subject_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bd_colegioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profesorBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materiaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox comboProfesor;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIDMateria;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource profesorBindingSource;
        private System.Windows.Forms.BindingSource profesorBindingSource1;
        private System.Windows.Forms.BindingSource profesorBindingSource2;
        private System.Windows.Forms.BindingSource profesorBindingSource3;
        private System.Windows.Forms.BindingSource materiaBindingSource;
        private bd_colegioDataSet bd_colegioDataSet;
        private System.Windows.Forms.BindingSource profesorBindingSource4;
        private bd_colegioDataSetTableAdapters.profesorTableAdapter profesorTableAdapter;
        private System.Windows.Forms.Button button6;
    }
}