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
    private void Button_Click(object sender, RoutedEventArgs e)
    {
        string usuario = txtUsuario.Text;
        string contrasenia = txtContraseña.Password;

        if (usuario == "efrain" && contrasenia == "1234")
        {
            Menu menu = new Menu();

            menu.Show();
        }

        else
        {
            MessageBox.Show("Usuario o Contraseña incorrecta");
        }
    }

    private void CancelButton_Click(object sender, RoutedEventArgs e)
    {
        this.Close();
    }
}
