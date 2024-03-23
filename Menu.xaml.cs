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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Ingresos_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción de Ingresos
            MessageBox.Show("Realizando operación de Ingresos");
        }

        private void Salida_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción de Salida
            MessageBox.Show("Realizando operación de Salida");
        }

        private void Conductores_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción de Conductores
            MessageBox.Show("Mantenimiento de Conductores");
        }

        private void Transportistas_Click(object sender, RoutedEventArgs e)
        {
            // Lógica para la opción de Transportistas
            MessageBox.Show("Mantenimiento de Transportistas");
        }

        // Otros métodos para manejar eventos de menú...

    }
}