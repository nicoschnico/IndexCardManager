using IndexCardManager.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace IndexCardManager.ViewModel
{
    public class ModuleViewModel
    {
        public ObservableCollection<Module> Modules { get; set; } = new ObservableCollection<Module> { new Module { Name = "MyModule" } };


    }
}
