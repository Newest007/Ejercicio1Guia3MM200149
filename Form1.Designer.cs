
namespace Ejercicio1___Guía3_MM200149
{
    partial class frmprincipal
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtmonto = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttercernumnit = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtsegundonumnit = new System.Windows.Forms.TextBox();
            this.txtcuartonumnit = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtsegundodigdui = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.txtnmcuenta = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtcuenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbcuenta = new System.Windows.Forms.ComboBox();
            this.txtprimernumnit = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtapellidos = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdui = new System.Windows.Forms.TextBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvfrm1 = new System.Windows.Forms.DataGridView();
            this.btnconsultar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.cmbsucursal = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrm1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(282, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(351, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Historial de movimientos bancarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(72, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "DUI";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbsucursal);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.txtmonto);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txttercernumnit);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtsegundonumnit);
            this.groupBox1.Controls.Add(this.txtcuartonumnit);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtsegundodigdui);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtnmcuenta);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtcuenta);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cmbcuenta);
            this.groupBox1.Controls.Add(this.txtprimernumnit);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtapellidos);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtdui);
            this.groupBox1.Controls.Add(this.btnguardar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(248, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(424, 424);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Inscripción de clientes";
            // 
            // txtmonto
            // 
            this.txtmonto.Location = new System.Drawing.Point(141, 328);
            this.txtmonto.MaxLength = 9;
            this.txtmonto.Multiline = true;
            this.txtmonto.Name = "txtmonto";
            this.txtmonto.Size = new System.Drawing.Size(81, 34);
            this.txtmonto.TabIndex = 29;
            this.txtmonto.TextChanged += new System.EventHandler(this.txtmonto_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(12, 333);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(123, 23);
            this.label13.TabIndex = 28;
            this.label13.Text = "Monto a guardar";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(282, 236);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 23);
            this.label12.TabIndex = 27;
            this.label12.Text = "-";
            // 
            // txttercernumnit
            // 
            this.txttercernumnit.Location = new System.Drawing.Point(235, 231);
            this.txttercernumnit.MaxLength = 3;
            this.txttercernumnit.Name = "txttercernumnit";
            this.txttercernumnit.Size = new System.Drawing.Size(45, 34);
            this.txttercernumnit.TabIndex = 26;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(219, 236);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 23);
            this.label11.TabIndex = 25;
            this.label11.Text = "-";
            // 
            // txtsegundonumnit
            // 
            this.txtsegundonumnit.Location = new System.Drawing.Point(144, 230);
            this.txtsegundonumnit.MaxLength = 6;
            this.txtsegundonumnit.Name = "txtsegundonumnit";
            this.txtsegundonumnit.Size = new System.Drawing.Size(74, 34);
            this.txtsegundonumnit.TabIndex = 24;
            // 
            // txtcuartonumnit
            // 
            this.txtcuartonumnit.Location = new System.Drawing.Point(303, 230);
            this.txtcuartonumnit.MaxLength = 1;
            this.txtcuartonumnit.Name = "txtcuartonumnit";
            this.txtcuartonumnit.Size = new System.Drawing.Size(38, 34);
            this.txtcuartonumnit.TabIndex = 23;
            this.txtcuartonumnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcuartonumnit.TextChanged += new System.EventHandler(this.txtcuartonumnit_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(126, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(18, 23);
            this.label10.TabIndex = 22;
            this.label10.Text = "-";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(223, 44);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(18, 23);
            this.label9.TabIndex = 21;
            this.label9.Text = "-";
            // 
            // txtsegundodigdui
            // 
            this.txtsegundodigdui.Location = new System.Drawing.Point(242, 37);
            this.txtsegundodigdui.MaxLength = 1;
            this.txtsegundodigdui.Name = "txtsegundodigdui";
            this.txtsegundodigdui.Size = new System.Drawing.Size(38, 34);
            this.txtsegundodigdui.TabIndex = 20;
            this.txtsegundodigdui.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(296, 82);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 41);
            this.button2.TabIndex = 19;
            this.button2.Text = "Consultar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtnmcuenta
            // 
            this.txtnmcuenta.Location = new System.Drawing.Point(141, 276);
            this.txtnmcuenta.Multiline = true;
            this.txtnmcuenta.Name = "txtnmcuenta";
            this.txtnmcuenta.Size = new System.Drawing.Size(54, 34);
            this.txtnmcuenta.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(201, 283);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 23);
            this.label8.TabIndex = 17;
            this.label8.Text = "-";
            // 
            // txtcuenta
            // 
            this.txtcuenta.Location = new System.Drawing.Point(223, 277);
            this.txtcuenta.MaxLength = 5;
            this.txtcuenta.Multiline = true;
            this.txtcuenta.Name = "txtcuenta";
            this.txtcuenta.Size = new System.Drawing.Size(86, 34);
            this.txtcuenta.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 281);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 23);
            this.label7.TabIndex = 14;
            this.label7.Text = "Número Cuenta";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(36, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "NIT";
            // 
            // cmbcuenta
            // 
            this.cmbcuenta.AllowDrop = true;
            this.cmbcuenta.FormattingEnabled = true;
            this.cmbcuenta.Location = new System.Drawing.Point(141, 181);
            this.cmbcuenta.Name = "cmbcuenta";
            this.cmbcuenta.Size = new System.Drawing.Size(128, 34);
            this.cmbcuenta.TabIndex = 12;
            this.cmbcuenta.SelectedIndexChanged += new System.EventHandler(this.cmbcuenta_SelectedIndexChanged);
            // 
            // txtprimernumnit
            // 
            this.txtprimernumnit.Location = new System.Drawing.Point(76, 231);
            this.txtprimernumnit.MaxLength = 4;
            this.txtprimernumnit.Name = "txtprimernumnit";
            this.txtprimernumnit.Size = new System.Drawing.Size(50, 34);
            this.txtprimernumnit.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tipo Cuenta";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(57, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 23);
            this.label4.TabIndex = 9;
            this.label4.Text = "Apellido";
            // 
            // txtapellidos
            // 
            this.txtapellidos.Location = new System.Drawing.Point(141, 133);
            this.txtapellidos.MaxLength = 10;
            this.txtapellidos.Name = "txtapellidos";
            this.txtapellidos.Size = new System.Drawing.Size(129, 34);
            this.txtapellidos.TabIndex = 8;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(141, 86);
            this.txtnombre.MaxLength = 10;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(129, 34);
            this.txtnombre.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Nombre";
            // 
            // txtdui
            // 
            this.txtdui.Location = new System.Drawing.Point(117, 37);
            this.txtdui.MaxLength = 8;
            this.txtdui.Name = "txtdui";
            this.txtdui.Size = new System.Drawing.Size(105, 34);
            this.txtdui.TabIndex = 5;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(296, 33);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(111, 41);
            this.btnguardar.TabIndex = 3;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dgvfrm1);
            this.groupBox2.Controls.Add(this.btnconsultar);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(46, 100);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(809, 376);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar historial de clientes";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Location = new System.Drawing.Point(360, 297);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 36);
            this.button3.TabIndex = 7;
            this.button3.Text = "Eliminar Cliente";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // dgvfrm1
            // 
            this.dgvfrm1.AllowUserToOrderColumns = true;
            this.dgvfrm1.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dgvfrm1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvfrm1.Location = new System.Drawing.Point(19, 35);
            this.dgvfrm1.Name = "dgvfrm1";
            this.dgvfrm1.ReadOnly = true;
            this.dgvfrm1.Size = new System.Drawing.Size(769, 214);
            this.dgvfrm1.TabIndex = 6;
            this.dgvfrm1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvfrm1_CellContentClick);
            this.dgvfrm1.DoubleClick += new System.EventHandler(this.dgvfrm1_DoubleClick);
            // 
            // btnconsultar
            // 
            this.btnconsultar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnconsultar.Location = new System.Drawing.Point(19, 283);
            this.btnconsultar.Name = "btnconsultar";
            this.btnconsultar.Size = new System.Drawing.Size(111, 64);
            this.btnconsultar.TabIndex = 4;
            this.btnconsultar.Text = "Regresar";
            this.btnconsultar.UseVisualStyleBackColor = false;
            this.btnconsultar.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(406, 515);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(111, 41);
            this.button1.TabIndex = 5;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe Print", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(12, 382);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(121, 23);
            this.label14.TabIndex = 30;
            this.label14.Text = "Sucursal Inscrito";
            // 
            // cmbsucursal
            // 
            this.cmbsucursal.FormattingEnabled = true;
            this.cmbsucursal.Location = new System.Drawing.Point(139, 377);
            this.cmbsucursal.Name = "cmbsucursal";
            this.cmbsucursal.Size = new System.Drawing.Size(141, 34);
            this.cmbsucursal.TabIndex = 31;
            this.cmbsucursal.SelectedIndexChanged += new System.EventHandler(this.cmbsucursal_SelectedIndexChanged);
            // 
            // frmprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(899, 568);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "frmprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 1 - Guía 3 MM200149";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvfrm1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbcuenta;
        private System.Windows.Forms.TextBox txtprimernumnit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtapellidos;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdui;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtcuenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtnmcuenta;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnconsultar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dgvfrm1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtsegundodigdui;
        private System.Windows.Forms.TextBox txtcuartonumnit;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttercernumnit;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtsegundonumnit;
        private System.Windows.Forms.TextBox txtmonto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cmbsucursal;
        private System.Windows.Forms.Label label14;
    }
}

