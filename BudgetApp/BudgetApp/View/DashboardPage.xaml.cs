using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetApp.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {
        public DashboardPage()
        {
            InitializeComponent();
        }

        private void MenuTapped(object sender, EventArgs e)
        {
            OpenMenu();
        }
        private void OverlayTapped(object sender, EventArgs e)
        {
            CloseMenu();
        }
        
        private void OpenMenu()
        {
            MenuGrid.IsVisible = true;

            Action<double> callback = input =>
            {
                MenuView.TranslationX = input;
            };

            MenuView.Animate("anim", callback, -260, 0, 16, 300, Easing.CubicInOut);
        }

        private void CloseMenu()
        {
            Action<double> callback = input =>
            {
                MenuView.TranslationX = input;
            };

            MenuView.Animate("anim", callback, 0, -260, 16, 300, Easing.CubicInOut);

            MenuGrid.IsVisible = false;
        }
    }
}