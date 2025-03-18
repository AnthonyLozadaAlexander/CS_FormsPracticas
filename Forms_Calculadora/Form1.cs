namespace Forms_Calculadora;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.MaximizeBox = false;
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }

    private void btn_Salir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }

    private void btn_suma_Click(object sender, EventArgs e)
    {
        decimal v1 = this.nud_Op1.Value;
        decimal v2 = this.nud_Op2.Value;
        
        decimal total = v1 + v2;

        this.txt_Resultado.Text = total + "";
    }

    private void btn_resta_Click(object sender, EventArgs e)
    {
        decimal Valor1 = this.nud_Op1.Value;
        decimal Valor2 = this.nud_Op2.Value;

        if (Valor1 < Valor2)
        {
            MessageBox.Show("El primer valor debe ser mayor al segundo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        else if (Valor2 == 0)
        {
            this.txt_Resultado.Text = Valor1 + "";
        }
        else
        {
            decimal total = Valor1 - Valor2;
            this.txt_Resultado.Text = total + "";
        }
    }

    private void btn_Multiplicacion_Click(object sender, EventArgs e)
    {
        decimal v1 = this.nud_Op1.Value;
        decimal v2 = this.nud_Op2.Value;

        decimal total = v1 * v2;
        this.txt_Resultado.Text = total + "";
    }

    private void btn_division_Click(object sender, EventArgs e)
    {
        decimal v1 = this.nud_Op1.Value;
        decimal v2 = this.nud_Op2.Value;
        
        if(v2 == 0)
        {
            MessageBox.Show("No se puede dividir por 0", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
        }
        else
        {
            decimal total = v1 / v2;
            this.txt_Resultado.Text = total + "";
        }
    }
    
    private void txt_Resultado_TextChanged(object sender, EventArgs e)
    {
        
    }
}
    