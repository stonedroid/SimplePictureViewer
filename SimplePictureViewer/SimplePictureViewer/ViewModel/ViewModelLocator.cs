using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.ViewModel
{
    public static class ViewModelLocator
    {
        private static CompositionContainer container;

        public static IExplorerViewModel ExplorerViewModel { get { return container.GetExportedValue<IExplorerViewModel>(); } }

        static ViewModelLocator()
        {
            container = new CompositionContainer(new AssemblyCatalog(typeof(App).Assembly));
        }
    }
}
