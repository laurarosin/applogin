using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace applogin.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Protegida : ContentView
    {
        public Protegida()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

        }

        public static implicit operator Page(Protegida v)
        {
            throw new NotImplementedException();
        }
    }
}