using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio1_1
{
    public partial class MainPage : ContentPage
    {
        private float n1, n2, resul;
        private Operaciones op;
        private string msg = "";

        public MainPage(){
            InitializeComponent();
        }

        private void btnSum_Clicked(object sender, EventArgs e){
            try{
                getValues();
                resul = op.suma(n1, n2);
                msg = "Suma realizada correctamente";
                Navigation.PushAsync(new ResultPage(resul, msg));
            }
            catch (NullReferenceException ex){
                Console.WriteLine(ex.ToString());
                noValid();
            }
        }

        private void btnSub_Clicked(object sender, EventArgs e){
            try{
                if (n1 >= n2){
                    resul = op.resta(n1, n2);
                    msg = "Resta realizada correctamente";
                }
                else noValid();
                Navigation.PushAsync(new ResultPage(resul, msg));
            }
            catch (NullReferenceException ex){
                Console.WriteLine(ex.ToString());
                noValid();
            }
        }

        private void btnMul_Clicked(object sender, EventArgs e){
            try{
                resul = op.mult(n1, n2);
                msg = "Multiplicacion realizada correctamente";
                Navigation.PushAsync(new ResultPage(resul, msg));
            }
            catch (NullReferenceException ex){
                Console.WriteLine(ex.ToString());
                noValid();
            }
        }

        private void btnDiv_Clicked(object sender, EventArgs e){
            try{
                if (n1 >= n2){
                    resul = op.div(n1, n2);
                    msg = "Division realizada correctamente";
                }
                else noValid();
                Navigation.PushAsync(new ResultPage(resul, msg));
            }
            catch (NullReferenceException ex){
                Console.WriteLine(ex.ToString());
                noValid();
            }
        }

        private void getValues(){
            op = new Operaciones();
            n1 = (float)Convert.ToDouble(txtN1.Text);
            n2 = (float)Convert.ToDouble(txtN2.Text);
        }

        private void noValid(){
            resul = 0;
            msg = "No se puede realizar esta operacion";
        }
    }
}
