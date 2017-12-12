using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace arvestus_Sten_linn
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
        int loginfail = 0;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string kasutajanimi = "user";
            string parool = "SecretPassword";
            if (loginfail < 3)
            {
                if (passwordbox1.Password == parool && textbox1.Text == kasutajanimi)
                {
                    textblock1.Text = "Sisselogimine õnnestus!";
                    this.Frame.Navigate(typeof(content));
                }
                else
                {
                    textblock1.Text = "Sisselogimine ebaõnnestus!";
                    loginfail++;
                }
            }
            else
            {
                textblock1.Text = "Sisestasid 3 korda vale parooli, enam logimiseks katseid ei ole!";
            }

        }
    }
}
