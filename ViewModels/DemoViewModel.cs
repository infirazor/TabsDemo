using MvvmDialogs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace TabsDemo.ViewModels
{
    public class DemoViewModel
    {
        private readonly IDialogService dialogService;
        public DemoViewModel()
        {

        }
        public void ShowSaveDialog()
        {
            //you can code here to show any dialog.
            MessageBox.Show("Here I want to show save file dialog box for example !");
        }
    }
}
