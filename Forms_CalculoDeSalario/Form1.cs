using System.Runtime.InteropServices.JavaScript;

namespace Forms_CalculoDeSalario;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.MaximizeBox = false;
        txtSalarioBase.ReadOnly = true;
        txtImpuesto15.ReadOnly = true;
        txtSalarioNeto.ReadOnly = true;
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
        else if(Char.IsSeparator(e.KeyChar))
        {
            e.Handled = true; // no permite que se escriban espacios
        }
        else
        {
            e.Handled = false; // permite que se escriban números
        }
    }
    
    private void btnLimpiar_Click(object sender, EventArgs e)
    {
        /*txtNombre.Clear();
        txtImpuesto15.Clear();
        txtHorasExtras.Clear();
        txtSalarioBase.Clear();
        txtSalarioNeto.Clear();
        txtHorasTrabajadas.Clear();
        txtSalarioxHora.Clear();*/
        
        foreach(Control datos in this.groupBox1.Controls) // por cada control en el groupBox1.Controls
        {
            if(datos is TextBox) // si datos es un TextBox
            {
                datos.Text = string.Empty; // limpiara cada textBox del group1
            }
        }

        foreach (Control datosR in this.groupBox2.Controls) // por cada control en el groupBox2.Controls
        {
            if (datosR is TextBox) // si datos es un TextBox
            {
                datosR.Text = ""; // limpiara cada textBox del group2
            }
        }
    }

    private void btnCalcular_Click(object sender, EventArgs e)
    { 
        float SalarioxHora, SalarioBase, SalarioNeto, HorasExtra, HorasTrabajadas, Impuesto15;
        try
        { 
            
         SalarioxHora = float.Parse(txtSalarioxHora.Text);
         HorasExtra = float.Parse(txtHorasExtras.Text);
         HorasTrabajadas = float.Parse(txtHorasTrabajadas.Text);

         SalarioBase = (SalarioxHora * HorasTrabajadas) + (2f * (SalarioxHora * HorasExtra));
         Impuesto15 = (SalarioBase * 0.15f);
         SalarioNeto = SalarioBase - Impuesto15;

         txtSalarioBase.Text = SalarioBase.ToString();
         txtImpuesto15.Text = Impuesto15.ToString();
         txtSalarioNeto.Text = SalarioNeto.ToString();
         
        }
        catch (Exception error) // error es el nombre de la variable que se le asigna al catch (Exception "error")
        {
            MessageBox.Show("Error:\n" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        
    }
}