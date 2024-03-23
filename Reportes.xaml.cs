using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Semana2B
{

    public class Reportes
    {
        // Propiedades de la clase Reporte
        public string TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public double Peso { get; set; }
        public string TipoAuto { get; set; }
        public string NombreTransportista { get; set; }
        public DateTime FechaHora { get; set; }
        public double PesoIngreso { get; set; }
        public double PesoSalida { get; set; }

        // Constructor de la clase Reporte
        public Reportes()
        {
            // Inicializar propiedades si es necesario
        }

        // Método para generar el reporte
        public void GenerarReporte()
        {

            Console.WriteLine("Generando reporte...");
            Console.WriteLine("Tipo de Documento: " + TipoDocumento);
            Console.WriteLine("Numero Documento: " + NumeroDocumento);
            Console.WriteLine("Peso: " + Peso);

        }
    }
}