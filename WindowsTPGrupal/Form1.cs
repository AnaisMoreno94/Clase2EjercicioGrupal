using Clase2EjercicioGrupal.Terrestres.Autos;
using Clase2EjercicioGrupal.Terrestres.Manuales;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsTPGrupal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void btnCreateAutoF1_Click(object sender, EventArgs e)
        {
            AutoFormula1 w13 = new AutoFormula1("Mercedes-W13", "W13", "V6", "Plateado", 352, 1026);
            MessageBox.Show("Auto de Formula 1 Creado = Nombre: " + w13.Nombre + ", Modelo: " + w13.Modelo + ", Motor: " + w13.TipoMotor + ", Color: " + w13.Color + ", Velocidad Maxima: " + w13.Velocidad+", Caballos de Fuerza:" +w13.CaballosPotencia);
        }

        private void btnCrearBicicleta_Click(object sender, EventArgs e)
        {
            Bicicleta epic = new Bicicleta("Epic", "Epic Pro", "DT Swiss 350", "760 mm", "FACT 11m Full Carbon", "SRAM Level TLM");
            MessageBox.Show("Bicicleta Creada = Nombre: " + epic.Nombre + ", Modelo: " + epic.Modelo + ", Ruedas: " + epic.Ruedas + ", Tamaño Marco: " + epic.Tamaño + ", Tipo Marco: " + epic.TipoMarco + ", Tipo de Frenos:" + epic.TipoFreno);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
