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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Operando1.Text = "0";
            Operando2.Text = "0";
            Resultado.Text = "0";
            Suma.IsChecked = true;
        }

        
        
        private void Suma_RadioButton(object sender, RoutedEventArgs e)
        {
            Operaciones();
            
        }

        private void Resta_RabioButton(object sender, RoutedEventArgs e)
        {
            Operaciones();
        }

        private void Multiplicacion_RadioButton(object sender, RoutedEventArgs e)
        {
            Operaciones();
        }

        private void Division_RadioButton(object sender, RoutedEventArgs e)
        {
            Operaciones();
         
        }

        private void Limpiar_Button(object sender, RoutedEventArgs e)
        {
            Operando1.Text = "0";
            Operando2.Text = "0";
            Resultado.Text = "0";
            Suma.IsChecked = true;
        }

        private void Operaciones_TextBox(object sender, TextChangedEventArgs e)
        {
            Operaciones();
        }
        public void Operaciones()
        {
            if (Operando1.Text != "" && Operando2.Text!="") 
            {
                if (Suma.IsChecked == true)
                {
                    int resultado = int.Parse(Operando1.Text) + int.Parse(Operando2.Text);

                    Resultado.Text = resultado.ToString();
                }
                else if (Resta.IsChecked == true)
                {
                    int resultado = int.Parse(Operando1.Text) - int.Parse(Operando2.Text);

                    Resultado.Text = resultado.ToString();
                }
                else if (Multiplicación.IsChecked == true)
                {
                    int resultado = int.Parse(Operando1.Text) * int.Parse(Operando2.Text);

                    Resultado.Text = resultado.ToString();
                }
                else if (Division.IsChecked == true)
                {
                    if (Operando2.Text == "0")
                    {
                        Resultado.Text = "Error";
                    }
                    else
                    {
                        float resultado = float.Parse(Operando1.Text) / float.Parse(Operando2.Text);

                        Resultado.Text = resultado.ToString();
                    }
                   
                }
            }
            
        }

       
    }
}
