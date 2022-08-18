using applogin.Model;
using applogin.View;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace applogin
{
    public partial class App : Application
    {
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email ="Aluno@etec",
                Nome ="Aluno",
                Senha ="123"
            },
            new DadosUsuario()
            {
                Email="prof@etec",
                Nome ="professor",
                Senha = "456"
            }
        };

        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }

        private class Login : Page
        {
        }
    }
}
