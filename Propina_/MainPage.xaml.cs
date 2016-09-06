﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Propina_
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        

       
        
        private void textBox_Monto_PointerPressed(object sender, PointerRoutedEventArgs e)
        {

        }

        private void textBox_Monto_PointerPressed_1(object sender, PointerRoutedEventArgs e)
        {

        }
       

     private void button_Click(object sender, RoutedEventArgs e)
        {
           
            double Monto = Convert.ToDouble(TextBox_Monto.Text);
            string Str_Num_Personas = Convert.ToString(comboBox_Personas.SelectionBoxItem);
            string Str_Porc_Propina = Convert.ToString(comboBox_Propina.SelectionBoxItem);

            int Num_Personas = int.Parse(Str_Num_Personas.ToString());
            double Porc_Propina = double.Parse(Str_Porc_Propina.ToString());

            double Monto_Persona = (Monto*(1+(Porc_Propina/100)))/Num_Personas;

            Etiqueta_Resultado.Text = "Cada persona pagara:  " + Monto_Persona.ToString("###,###.00");
                       

        }
    }
}
