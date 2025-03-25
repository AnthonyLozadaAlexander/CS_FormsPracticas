namespace Forms_MayorDiametro;

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
        trackBar1 = new System.Windows.Forms.TrackBar();
        trackBar2 = new System.Windows.Forms.TrackBar();
        pictureBox1 = new System.Windows.Forms.PictureBox();
        txtResultado = new System.Windows.Forms.TextBox();
        label1 = new System.Windows.Forms.Label();
        btnSalir = new System.Windows.Forms.Button();
        label2 = new System.Windows.Forms.Label();
        label3 = new System.Windows.Forms.Label();
        ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
        ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
        SuspendLayout();
        // 
        // trackBar1
        // 
        trackBar1.Location = new System.Drawing.Point(75, 92);
        trackBar1.Maximum = 200;
        trackBar1.Name = "trackBar1";
        trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
        trackBar1.Size = new System.Drawing.Size(45, 542);
        trackBar1.TabIndex = 0;
        trackBar1.Scroll += trackBar1_Scroll;
        // 
        // trackBar2
        // 
        trackBar2.Location = new System.Drawing.Point(728, 92);
        trackBar2.Maximum = 200;
        trackBar2.Name = "trackBar2";
        trackBar2.Orientation = System.Windows.Forms.Orientation.Vertical;
        trackBar2.Size = new System.Drawing.Size(45, 542);
        trackBar2.TabIndex = 1;
        trackBar2.Scroll += trackBar2_Scroll;
        // 
        // pictureBox1
        // 
        pictureBox1.BackColor = System.Drawing.Color.White;
        pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        pictureBox1.Location = new System.Drawing.Point(116, 121);
        pictureBox1.Name = "pictureBox1";
        pictureBox1.Size = new System.Drawing.Size(606, 438);
        pictureBox1.TabIndex = 2;
        pictureBox1.TabStop = false;
        // 
        // txtResultado
        // 
        txtResultado.Font = new System.Drawing.Font("Miracode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        txtResultado.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
        txtResultado.Location = new System.Drawing.Point(267, 609);
        txtResultado.Name = "txtResultado";
        txtResultado.Size = new System.Drawing.Size(314, 25);
        txtResultado.TabIndex = 3;
        txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
        txtResultado.TextChanged += txtResultado_TextChanged;
        // 
        // label1
        // 
        label1.Font = new System.Drawing.Font("Miracode", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        label1.Location = new System.Drawing.Point(230, 64);
        label1.Name = "label1";
        label1.Size = new System.Drawing.Size(402, 37);
        label1.TabIndex = 4;
        label1.Text = "Comparacion De Circulos";
        // 
        // btnSalir
        // 
        btnSalir.Font = new System.Drawing.Font("Miracode", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
        btnSalir.Location = new System.Drawing.Point(708, 24);
        btnSalir.Name = "btnSalir";
        btnSalir.Size = new System.Drawing.Size(112, 41);
        btnSalir.TabIndex = 5;
        btnSalir.Text = "Salir";
        btnSalir.UseVisualStyleBackColor = true;
        btnSalir.Click += btnSalir_Click;
        // 
        // label2
        // 
        label2.Font = new System.Drawing.Font("Miracode", 14F);
        label2.Location = new System.Drawing.Point(720, 637);
        label2.Name = "label2";
        label2.Size = new System.Drawing.Size(100, 23);
        label2.TabIndex = 6;
        label2.Text = "Azul";
        // 
        // label3
        // 
        label3.Font = new System.Drawing.Font("Miracode", 14F);
        label3.Location = new System.Drawing.Point(55, 632);
        label3.Name = "label3";
        label3.Size = new System.Drawing.Size(100, 31);
        label3.TabIndex = 7;
        label3.Text = "Rojo";
        // 
        // Form1
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(845, 691);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(btnSalir);
        Controls.Add(label1);
        Controls.Add(txtResultado);
        Controls.Add(pictureBox1);
        Controls.Add(trackBar2);
        Controls.Add(trackBar1);
        Text = "Form_MayorDiametro";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
        ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
        ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    private System.Windows.Forms.Label label3;

    private System.Windows.Forms.Label label2;

    private System.Windows.Forms.Button btnSalir;

    private System.Windows.Forms.Label label1;

    private System.Windows.Forms.TextBox txtResultado;

    private System.Windows.Forms.PictureBox pictureBox1;

    private System.Windows.Forms.TrackBar trackBar2;

    private System.Windows.Forms.TrackBar trackBar1;

    #endregion
}