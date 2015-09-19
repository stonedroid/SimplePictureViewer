using SimplePictureViewer.ViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SimplePictureViewer.View
{
    public partial class Explorer : UserControl
    {
        public IExplorerViewModel ViewModel {get;set;}

        public Explorer()
        {
            ViewModel = ViewModelLocator.ExplorerViewModel;
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}
