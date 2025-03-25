namespace Forms_CalculoDeSalario;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
        groupBox1 = new System.Windows.Forms.GroupBox();
        label4 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        txtHorasExtras = new System.Windows.Forms.TextBox();
        txtHorasTrabajadas = new System.Windows.Forms.TextBox();
        txtSalarioxHora = new System.Windows.Forms.TextBox();
        label2 = new System.Windows.Forms.Label();
        txtNombre = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        groupBox2 = new System.Windows.Forms.GroupBox();
        txtSalarioNeto = new System.Windows.Forms.TextBox();
        txtSalarioBase = new System.Windows.Forms.TextBox();
        txtImpuesto15 = new System.Windows.Forms.TextBox();
        btnSalir = new System.Windows.Forms.Button();
        btnLimpiar = new System.Windows.Forms.Button();
        btnCalcular = new System.Windows.Forms.Button();
        label7 = new System.Windows.Forms.Label();
        label6 = new System.Windows.Forms.Label();
        label5 = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        groupBox2.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(label4);
        groupBox1.Controls.Add(label3);
        groupBox1.Controls.Add(txtHorasExtras);
        groupBox1.Controls.Add(txtHorasTrabajadas);
        groupBox1.Controls.Add(txtSalarioxHora);
        groupBox1.Controls.Add(label2);
        groupBox1.Controls.Add(txtNombre);
        groupBox1.Controls.Add(label1);
        groupBox1.Location = new System.Drawing.Point(48, 28);
        groupBox1.Name = "groupBox1";
        groupBox1.Size = new System.Drawing.Size(396, 220);
        groupBox1.TabIndex = 0;
        groupBox1.TabStop = false;
        groupBox1.Text = "Datos";
        // 
        // label4
        // 
        label4.Location = new System.Drawing.Point(12, 180);
        label4.Name = "label4";
        label4.Size = new System.Drawing.Size(114, 23);
        label4.TabIndex = 7;
        label4.Text = "Horas Extras:";
        // 
        // label3
        // 
        label3.Location = new System.Drawing.Point(12, 133);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(114, 23);
        label3.TabIndex = 6;
        label3.Text = "Horas Trabajas:";
        // 
        // txtHorasExtras
        // 
        txtHorasExtras.Location = new System.Drawing.Point(132, 180);
        txtHorasExtras.Name = "txtHorasExtras";
        txtHorasExtras.Size = new System.Drawing.Size(100, 23);
        txtHorasExtras.TabIndex = 5;
        txtHorasExtras.KeyPress += ValidarNumero;
        // 
        // txtHorasTrabajadas
        // 
        txtHorasTrabajadas.Location = new System.Drawing.Point(132, 133);
        txtHorasTrabajadas.Name = "txtHorasTrabajadas";
        txtHorasTrabajadas.Size = new System.Drawing.Size(100, 23);
        txtHorasTrabajadas.TabIndex = 4;
        txtHorasTrabajadas.KeyPress += ValidarNumero;
        // 
        // txtSalarioxHora
        // 
        txtSalarioxHora.Location = new System.Drawing.Point(132, 80);
        txtSalarioxHora.Name = "txtSalarioxHora";
        txtSalarioxHora.Size = new System.Drawing.Size(100, 23);
        txtSalarioxHora.TabIndex = 3;
        txtSalarioxHora.KeyPress += ValidarNumero;
        // 
        // label2
        // 
        label2.Location = new System.Drawing.Point(12, 80);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(114, 23);
        label2.TabIndex = 2;
        label2.Text = "Salario x Hora:";
        // 
        // txtNombre
        // 
        txtNombre.Location = new System.Drawing.Point(132, 33);
        txtNombre.Name = "txtNombre";
        txtNombre.Size = new System.Drawing.Size(222, 23);
        txtNombre.TabIndex = 1;
        txtNombre.KeyPress += ValidarTexto;
        // 
        // label1
        // 
        label1.Location = new System.Drawing.Point(12, 33);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(114, 23);
        label1.TabIndex = 0;
        label1.Text = "Nombre Completo:";
        // 
        // groupBox2
        // 
        groupBox2.Controls.Add(txtSalarioNeto);
        groupBox2.Controls.Add(txtSalarioBase);
        groupBox2.Controls.Add(txtImpuesto15);
        groupBox2.Controls.Add(btnSalir);
        groupBox2.Controls.Add(btnLimpiar);
        groupBox2.Controls.Add(btnCalcular);
        groupBox2.Controls.Add(label7);
        groupBox2.Controls.Add(label6);
        groupBox2.Controls.Add(label5);
        groupBox2.Location = new System.Drawing.Point(51, 266);
        groupBox2.Name = "groupBox2";
        groupBox2.Size = new System.Drawing.Size(393, 182);
        groupBox2.TabIndex = 1;
        groupBox2.TabStop = false;
        groupBox2.Text = "Resultados";
        // 
        // txtSalarioNeto
        // 
        txtSalarioNeto.Location = new System.Drawing.Point(129, 132);
        txtSalarioNeto.Name = "txtSalarioNeto";
        txtSalarioNeto.ReadOnly = true;
        txtSalarioNeto.Size = new System.Drawing.Size(100, 23);
        txtSalarioNeto.TabIndex = 14;
        // 
        // txtSalarioBase
        // 
        txtSalarioBase.Location = new System.Drawing.Point(129, 45);
        txtSalarioBase.Name = "txtSalarioBase";
        txtSalarioBase.ReadOnly = true;
        txtSalarioBase.Size = new System.Drawing.Size(100, 23);
        txtSalarioBase.TabIndex = 13;
        // 
        // txtImpuesto15
        // 
        txtImpuesto15.Location = new System.Drawing.Point(129, 88);
        txtImpuesto15.Name = "txtImpuesto15";
        txtImpuesto15.ReadOnly = true;
        txtImpuesto15.Size = new System.Drawing.Size(100, 23);
        txtImpuesto15.TabIndex = 12;
        // 
        // btnSalir
        // 
        btnSalir.Location = new System.Drawing.Point(289, 132);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(75, 23);
        btnSalir.TabIndex = 11;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // btnLimpiar
        // 
        btnLimpiar.Location = new System.Drawing.Point(289, 88);
        btnLimpiar.Name = "btnLimpiar";
        btnLimpiar.Size = new System.Drawing.Size(75, 23);
        btnLimpiar.TabIndex = 10;
        btnLimpiar.Text = "Limpiar";
        btnLimpiar.UseVisualStyleBackColor = true;
        btnLimpiar.Click += btnLimpiar_Click;
        // 
        // btnCalcular
        // 
        btnCalcular.Location = new System.Drawing.Point(289, 45);
        btnCalcular.Name = "btnCalcular";
        btnCalcular.Size = new System.Drawing.Size(75, 23);
        btnCalcular.TabIndex = 9;
        btnCalcular.Text = "Calcular";
        btnCalcular.UseVisualStyleBackColor = true;
        btnCalcular.Click += btnCalcular_Click;
        // 
        // label7
        // 
        label7.Location = new System.Drawing.Point(9, 132);
        label7.Name = "label7";
        label7.Size = new System.Drawing.Size(114, 23);
        label7.TabIndex = 5;
        label7.Text = "Salario Neto: C$";
        // 
        // label6
        // 
        label6.Location = new System.Drawing.Point(9, 88);
        label6.Name = "label6";
        label6.Size = new System.Drawing.Size(114, 23);
        label6.TabIndex = 4;
        label6.Text = "Impuesto (15%):  C$";
        // 
        // label5
        // 
        label5.Location = new System.Drawing.Point(9, 45);
        label5.Name = "label5";
        label5.Size = new System.Drawing.Size(114, 23);
        label5.TabIndex = 3;
        label5.Text = "Salario Base:  C$";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(491, 463);
        Controls.Add(groupBox2);
        Controls.Add(groupBox1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form_CalculoSalario";
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        groupBox2.ResumeLayout(false);
        groupBox2.PerformLayout();
        ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtImpuesto15;
    private System.Windows.Forms.TextBox txtSalarioBase;
    private System.Windows.Forms.TextBox txtSalarioNeto;

    private System.Windows.Forms.Button btnCalcular;
    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Button btnLimpiar;

    private System.Windows.Forms.Label label7;

    private System.Windows.Forms.Label label6;

    private System.Windows.Forms.Label label5;

    private System.Windows.Forms.GroupBox groupBox2;

    private System.Windows.Forms.TextBox txtHorasTrabajadas;
    private System.Windows.Forms.TextBox txtHorasExtras;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;

    private System.Windows.Forms.TextBox txtNombre;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtSalarioxHora;

    private System.Windows.Forms.GroupBox groupBox1;

    #endregion
}