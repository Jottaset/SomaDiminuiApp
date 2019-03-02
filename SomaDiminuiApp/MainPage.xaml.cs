using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SomaDiminuiApp
{
    public partial class MainPage : ContentPage
    {
        int N = 0;

        void Button_Soma(object sender, System.EventArgs e)
        {

            N++;
            label_valor.Text = N.ToString();
        }


        void Button_Subtrai(object sender, System.EventArgs e)
        {

            N--;
            label_valor.Text = N.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
