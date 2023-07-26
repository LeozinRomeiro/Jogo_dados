using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Jogo_dados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page_dado : ContentPage
    {
        public Page_dado()
        {
            InitializeComponent();
            Random random = new Random();
            int sorteado = random.Next(1, 6);
            //imagem_dado.Source = "dado" + sorteado;

            switch(sorteado)
            {
                case 1:
                    imagem_dado.Source = "dado1";
                    break;
                case 2:
                    imagem_dado.Source = "dado2";
                    break;
                case 3:
                    imagem_dado.Source = "dado3";
                    break;
                case 4:
                    imagem_dado.Source = "dado4";
                    break;
                case 5:
                    imagem_dado.Source = "dado5";
                    break;
                case 6:
                    imagem_dado.Source = "dado6";
                    break;
            }

        }

        private async void imagem_voltar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}