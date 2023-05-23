using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio1_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ResultPage : ContentPage
    {
        public ResultPage(){
            InitializeComponent();
        }

        public ResultPage(float resul, string msg){
            InitializeComponent();
            lblResult.Text = Convert.ToString(resul);
            lblMsg.Text = msg;
        }
    }
}