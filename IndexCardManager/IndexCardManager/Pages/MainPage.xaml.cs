using IndexCardManager.Models;
using IndexCardManager.ViewModel;
using Xamarin.Forms;

namespace IndexCardManager.Pages
{
    public partial class MainPage
    {
        public ModuleViewModel viewModel { get; set; }
        public MainPage()
        {
            InitializeComponent();
        }

        private void MoudleListView_ItemTapped(object sender, ItemTappedEventArgs e)
        {

        }

        private void EditItem_Clicked(object sender, System.EventArgs e)
        {
            Module module = ((MenuItem) sender).CommandParameter as Module;
            App.Navigation.PushAsync(new EditModulePage(module));
        }

        private void DeleteItem_Clicked(object sender, System.EventArgs e)
        {
            Module module = ((MenuItem)sender).CommandParameter as Module;
            ((ModuleViewModel)this.BindingContext).Modules.Remove(module);
        }
    }
}
