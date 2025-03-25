namespace Forms_MayorDiametro;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        this.MaximizeBox = false;
        this.CenterToScreen();
    }

    //Crear un metodo para comparar los valores
    private void CompararValores()
    {
        try
        {
            // Creando el area 
            Graphics papel;

            // Asignar el papel a mi pictureBox
            papel = pictureBox1.CreateGraphics();

            // Crear Brushes
            SolidBrush brushRed = new SolidBrush(Color.Red);
            SolidBrush brushBlue = new SolidBrush(Color.Blue);

            // Declarar dos variables
            int valorRed, valorBlue;

            // Asignar mis variables a los trackBar1 y 2
            valorRed = trackBar1.Value;
            valorBlue = trackBar2.Value;

            // Limpiar Papel
            papel.Clear(Color.White);

            //Crear Circulos
            papel.FillEllipse(brushRed, 10, 10, valorRed, valorRed);
            papel.FillEllipse(brushBlue, 10, 10, valorBlue, valorBlue);

            //Hacer las evaluciones correspondientes
            if (valorRed > valorBlue)
            {
                txtResultado.Text = "El Circulo Rojo Es Mayor";
            }
            else if (valorBlue > valorRed)
            {
                txtResultado.Text = "El Circulo Azul Es Mayor";
            }
            else if (valorRed == valorBlue)
            {
                txtResultado.Text = "Los Circulos son iguales";
            }
        }
        catch (Exception error)
        {
            MessageBox.Show(error.Message);
        }
    }
    private void Form1_Load(object sender, EventArgs e)
    {
        
    }

    private void trackBar2_Scroll(object sender, EventArgs e)
    {
        CompararValores();
    }

    private void trackBar1_Scroll(object sender, EventArgs e)
    {
        CompararValores();
    }

    private void txtResultado_TextChanged(object sender, EventArgs e)
    {
    }

    private void btnSalir_Click(object sender, EventArgs e)
    {
        Application.Exit();
    }
}