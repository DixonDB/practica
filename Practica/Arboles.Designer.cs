
namespace Practica
{
    partial class Arboles
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbEliminar = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.txteliminar = new System.Windows.Forms.TextBox();
            this.gbRecorridos = new System.Windows.Forms.GroupBox();
            this.btnPreOrden = new System.Windows.Forms.Button();
            this.btnPosOrden = new System.Windows.Forms.Button();
            this.btnInOrden = new System.Windows.Forms.Button();
            this.lstRecorridos = new System.Windows.Forms.ListBox();
            this.lblRecorridos = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btncontinuar = new System.Windows.Forms.Button();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gbEliminar.SuspendLayout();
            this.gbRecorridos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtedad);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnguardar);
            this.groupBox2.Controls.Add(this.txtnombre);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Enabled = false;
            this.groupBox2.Location = new System.Drawing.Point(12, 106);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 92);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(323, 31);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Edad";
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(348, 57);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(75, 23);
            this.btnguardar.TabIndex = 2;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(85, 31);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(12, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(475, 200);
            this.dataGridView1.TabIndex = 7;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Edad";
            this.Column2.Name = "Column2";
            // 
            // gbEliminar
            // 
            this.gbEliminar.Controls.Add(this.label5);
            this.gbEliminar.Controls.Add(this.btnEliminar);
            this.gbEliminar.Controls.Add(this.txteliminar);
            this.gbEliminar.Font = new System.Drawing.Font("Microsoft Tai Le", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEliminar.ForeColor = System.Drawing.Color.Black;
            this.gbEliminar.Location = new System.Drawing.Point(12, 204);
            this.gbEliminar.Name = "gbEliminar";
            this.gbEliminar.Size = new System.Drawing.Size(475, 92);
            this.gbEliminar.TabIndex = 26;
            this.gbEliminar.TabStop = false;
            this.gbEliminar.Text = "Eliminación";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Ingrese el dato a eliminar:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ForeColor = System.Drawing.Color.Black;
            this.btnEliminar.Location = new System.Drawing.Point(323, 31);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(117, 35);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txteliminar
            // 
            this.txteliminar.Location = new System.Drawing.Point(202, 37);
            this.txteliminar.Name = "txteliminar";
            this.txteliminar.Size = new System.Drawing.Size(115, 23);
            this.txteliminar.TabIndex = 6;
            // 
            // gbRecorridos
            // 
            this.gbRecorridos.Controls.Add(this.btnPreOrden);
            this.gbRecorridos.Controls.Add(this.btnPosOrden);
            this.gbRecorridos.Controls.Add(this.btnInOrden);
            this.gbRecorridos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbRecorridos.ForeColor = System.Drawing.Color.Black;
            this.gbRecorridos.Location = new System.Drawing.Point(12, 508);
            this.gbRecorridos.Name = "gbRecorridos";
            this.gbRecorridos.Size = new System.Drawing.Size(372, 175);
            this.gbRecorridos.TabIndex = 28;
            this.gbRecorridos.TabStop = false;
            this.gbRecorridos.Text = "Recorridos:";
            // 
            // btnPreOrden
            // 
            this.btnPreOrden.ForeColor = System.Drawing.Color.Black;
            this.btnPreOrden.Location = new System.Drawing.Point(17, 113);
            this.btnPreOrden.Name = "btnPreOrden";
            this.btnPreOrden.Size = new System.Drawing.Size(98, 34);
            this.btnPreOrden.TabIndex = 5;
            this.btnPreOrden.Text = "PREORDEN";
            this.btnPreOrden.UseVisualStyleBackColor = true;
            this.btnPreOrden.Click += new System.EventHandler(this.btnPreOrden_Click);
            // 
            // btnPosOrden
            // 
            this.btnPosOrden.ForeColor = System.Drawing.Color.Black;
            this.btnPosOrden.Location = new System.Drawing.Point(17, 63);
            this.btnPosOrden.Name = "btnPosOrden";
            this.btnPosOrden.Size = new System.Drawing.Size(99, 34);
            this.btnPosOrden.TabIndex = 4;
            this.btnPosOrden.Text = "POSORDEN";
            this.btnPosOrden.UseVisualStyleBackColor = true;
            this.btnPosOrden.Click += new System.EventHandler(this.btnPosOrden_Click);
            // 
            // btnInOrden
            // 
            this.btnInOrden.ForeColor = System.Drawing.Color.Black;
            this.btnInOrden.Location = new System.Drawing.Point(17, 23);
            this.btnInOrden.Name = "btnInOrden";
            this.btnInOrden.Size = new System.Drawing.Size(98, 34);
            this.btnInOrden.TabIndex = 3;
            this.btnInOrden.Text = "INORDEN";
            this.btnInOrden.UseVisualStyleBackColor = true;
            this.btnInOrden.Click += new System.EventHandler(this.btnInOrden_Click);
            // 
            // lstRecorridos
            // 
            this.lstRecorridos.FormattingEnabled = true;
            this.lstRecorridos.Location = new System.Drawing.Point(393, 541);
            this.lstRecorridos.Name = "lstRecorridos";
            this.lstRecorridos.Size = new System.Drawing.Size(128, 147);
            this.lstRecorridos.TabIndex = 29;
            // 
            // lblRecorridos
            // 
            this.lblRecorridos.AutoSize = true;
            this.lblRecorridos.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRecorridos.Font = new System.Drawing.Font("Microsoft Tai Le", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecorridos.ForeColor = System.Drawing.Color.Black;
            this.lblRecorridos.Location = new System.Drawing.Point(390, 508);
            this.lblRecorridos.Name = "lblRecorridos";
            this.lblRecorridos.Size = new System.Drawing.Size(66, 16);
            this.lblRecorridos.TabIndex = 30;
            this.lblRecorridos.Text = "Recorrido";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btncontinuar);
            this.groupBox1.Controls.Add(this.txtcantidad);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(475, 74);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inicio";
            // 
            // btncontinuar
            // 
            this.btncontinuar.Location = new System.Drawing.Point(278, 24);
            this.btncontinuar.Name = "btncontinuar";
            this.btncontinuar.Size = new System.Drawing.Size(75, 23);
            this.btncontinuar.TabIndex = 2;
            this.btncontinuar.Text = "Continuar";
            this.btncontinuar.UseVisualStyleBackColor = true;
            this.btncontinuar.Click += new System.EventHandler(this.btncontinuar_Click);
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(118, 26);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cantidad";
            // 
            // Arboles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1293, 709);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblRecorridos);
            this.Controls.Add(this.gbRecorridos);
            this.Controls.Add(this.lstRecorridos);
            this.Controls.Add(this.gbEliminar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Name = "Arboles";
            this.Text = "Arboles";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Arboles_Paint);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gbEliminar.ResumeLayout(false);
            this.gbEliminar.PerformLayout();
            this.gbRecorridos.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.GroupBox gbEliminar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TextBox txteliminar;
        private System.Windows.Forms.GroupBox gbRecorridos;
        private System.Windows.Forms.Button btnPreOrden;
        private System.Windows.Forms.Button btnPosOrden;
        private System.Windows.Forms.Button btnInOrden;
        private System.Windows.Forms.ListBox lstRecorridos;
        private System.Windows.Forms.Label lblRecorridos;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btncontinuar;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Label label1;
    }
}