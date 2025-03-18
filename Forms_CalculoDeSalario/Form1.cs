namespace Forms_CalculoDeSalario;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.MaximizeBox = false;
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
       Application.Exit();
    }

    // evento para el txtNombre
    public void ValidarTexto(object sender, KeyPressEventArgs e)
    {
        if (Char.IsNumber(e.KeyChar))
        {
            e.Handled = true; // No permite que se escriban números
        }
        else
        {
            e.Handled = false; // Permite que se escriban letras
        }
    }

    // evento para los txt que requieren el ingreso de numeros
    public void ValidarNumero(Object sender, KeyPressEventArgs e)
    {
        if (Char.IsLetter(e.KeyChar))
        {
            e.Handled = true; // no permite que se escriban letras
        }
        else
        {
            e.Handled = false; // permite que se escriban numeros
        }
    }
    
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        txtNombre.Clear();
        txtImpuesto15.Clear();
        txtHorasExtras.Clear();
        txtSalarioBase.Clear();
        txtSalarioNeto.Clear();
        txtHorasTrabajadas.Clear();
        txtSalarioxHora.Clear();
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    {
        String nombre = txtNombre.Text;
        float SalarioxHora = float.Parse(txtSalarioxHora.Text);
        float SalarioBase = float.Parse(txtSalarioBase.Text);
        float SalarioNeto = float.Parse(txtSalarioNeto.Text);
        float HorasExtra = float.Parse(txtHorasExtras.Text);
        float HorasTrabajadas = float.Parse(txtHorasTrabajadas.Text);
        float Impuesto15 = float.Parse(txtImpuesto15.Text);
    }
}