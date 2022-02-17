using IndexCardManager.Models;
using IndexCardManager.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IndexCardManager.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditModulePage : ContentPage
    {
        EditModuleViewModel viewModel;
        public EditModulePage()
        {
            InitializeComponent();
            viewModel = (EditModuleViewModel)this.BindingContext;
            viewModel.Module = new Module();

        }

        public EditModulePage(Module module)
        {
            InitializeComponent();
            viewModel = (EditModuleViewModel)this.BindingContext;
            viewModel.Module = module;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            ((ModuleViewModel)App.Navigation.RootPage.BindingContext).Modules.Add(viewModel.Module);
            App.Navigation.PopToRootAsync();
        }
    }
}