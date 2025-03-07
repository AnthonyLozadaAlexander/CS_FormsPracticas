namespace Forms_Calculadora;

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
        nud_Op1 = new System.Windows.Forms.NumericUpDown();
        nud_Op2 = new System.Windows.Forms.NumericUpDown();
        btn_suma = new System.Windows.Forms.Button();
        btn_resta = new System.Windows.Forms.Button();
        btn_Multiplicacion = new System.Windows.Forms.Button();
        btn_division = new System.Windows.Forms.Button();
        label1 = new System.Windows.Forms.Label();
        label2 = new System.Windows.Forms.Label();
        txt_Resultado = new System.Windows.Forms.TextBox();
        label3 = new System.Windows.Forms.Label();
        btn_Salir = new System.Windows.Forms.Button();
        ((System.ComponentModel.ISupportInitialize)nud_Op1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)nud_Op2).BeginInit();
        SuspendLayout();
        // 
        // nud_Op1
        // 
        nud_Op1.Location = new System.Drawing.Point(77, 141);
        nud_Op1.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nud_Op1.Name = "nud_Op1";
        nud_Op1.Size = new System.Drawing.Size(184, 23);
        nud_Op1.TabIndex = 0;
        // 
        // nud_Op2
        // 
        nud_Op2.Location = new System.Drawing.Point(321, 141);
        nud_Op2.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
        nud_Op2.Name = "nud_Op2";
        nud_Op2.Size = new System.Drawing.Size(184, 23);
        nud_Op2.TabIndex = 1;
        // 
        // btn_suma
        // 
        btn_suma.Font = new System.Drawing.Font("Miracode", 12F);
        btn_suma.Location = new System.Drawing.Point(77, 200);
        btn_suma.Name = "btn_suma";
        btn_suma.Size = new System.Drawing.Size(75, 36);
        btn_suma.TabIndex = 2;
        btn_suma.Text = "+";
        btn_suma.UseVisualStyleBackColor = true;
        btn_suma.Click += btn_suma_Click;
        // 
        // btn_resta
        // 
        btn_resta.Font = new System.Drawing.Font("Miracode", 12F);
        btn_resta.Location = new System.Drawing.Point(186, 200);
        btn_resta.Name = "btn_resta";
        btn_resta.Size = new System.Drawing.Size(75, 36);
        btn_resta.TabIndex = 3;
        btn_resta.Text = "-";
        btn_resta.UseVisualStyleBackColor = true;
        btn_resta.Click += btn_resta_Click;
        // 
        // btn_Multiplicacion
        // 
        btn_Multiplicacion.Font = new System.Drawing.Font("Miracode", 12F);
        btn_Multiplicacion.Location = new System.Drawing.Point(295, 200);
        btn_Multiplicacion.Name = "btn_Multiplicacion";
        btn_Multiplicacion.Size = new System.Drawing.Size(100, 36);
        btn_Multiplicacion.TabIndex = 4;
        btn_Multiplicacion.Text = "*";
        btn_Multiplicacion.UseVisualStyleBackColor = true;
        btn_Multiplicacion.Click += btn_Multiplicacion_Click;
        // 
        // btn_division
        // 
        btn_division.Font = new System.Drawing.Font("Miracode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_division.Location = new System.Drawing.Point(430, 200);
        btn_division.Name = "btn_division";
        btn_division.Size = new System.Drawing.Size(75, 36);
        btn_division.TabIndex = 5;
        btn_division.Text = "/";
        btn_division.UseVisualStyleBackColor = true;
        btn_division.Click += btn_division_Click;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Miracode", 12F);
        label1.Location = new System.Drawing.Point(99, 115);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(143, 23);
        label1.TabIndex = 6;
        label1.Text = "Operando 1";
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Miracode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label2.Location = new System.Drawing.Point(346, 115);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(143, 23);
        label2.TabIndex = 7;
        label2.Text = "Operando 2";
        // 
        // txt_Resultado
        // 
        txt_Resultado.Font = new System.Drawing.Font("Miracode", 12F);
        txt_Resultado.Location = new System.Drawing.Point(77, 268);
        txt_Resultado.Multiline = true;
        txt_Resultado.Name = "txt_Resultado";
        txt_Resultado.ReadOnly = true;
        txt_Resultado.Size = new System.Drawing.Size(428, 44);
        txt_Resultado.TabIndex = 8;
        txt_Resultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        txt_Resultado.TextChanged += txt_Resultado_TextChanged;
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Miracode", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label3.Location = new System.Drawing.Point(167, 41);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(257, 38);
        label3.TabIndex = 9;
        label3.Text = "Calculadora Basica";
        // 
        // btn_Salir
        // 
        btn_Salir.Font = new System.Drawing.Font("Miracode", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btn_Salir.Location = new System.Drawing.Point(484, 17);
        btn_Salir.Name = "btn_Salir";
        btn_Salir.Size = new System.Drawing.Size(75, 37);
        btn_Salir.TabIndex = 11;
        btn_Salir.Text = "Salir";
        btn_Salir.UseVisualStyleBackColor = true;
        btn_Salir.Click += btn_Salir_Click;
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(573, 450);
        Controls.Add(btn_Salir);
        Controls.Add(label3);
        Controls.Add(txt_Resultado);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(btn_division);
        Controls.Add(btn_Multiplicacion);
        Controls.Add(btn_resta);
        Controls.Add(btn_suma);
        Controls.Add(nud_Op2);
        Controls.Add(nud_Op1);
        FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
        StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        Text = "Form_Calculadora";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)nud_Op1).EndInit();
        ((System.ComponentModel.ISupportInitialize)nud_Op2).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Button btn_Salir;

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txt_Resultado;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.Button btn_resta;
    private System.Windows.Forms.Button btn_Multiplicacion;
    private System.Windows.Forms.Button btn_division;

    private System.Windows.Forms.NumericUpDown nud_Op2;
    private System.Windows.Forms.Button btn_suma;

    private System.Windows.Forms.NumericUpDown nud_Op1;

    #endregion
}