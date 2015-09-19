using SimplePictureViewer.Domain;
using SimplePictureViewer.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.ViewModel
{
    [Export(typeof(IExplorerViewModel))]
    public class ExplorerViewModel : IExplorerViewModel
    {
        private IExplorerService explorerService;

        public ExplorerDirectory Current { get; set; }

        [ImportingConstructor]
        public ExplorerViewModel(IExplorerService explorerService)
        {
            this.explorerService = explorerService;
            this.Current = explorerService.GetHomeDirectory();
        }
    }
}
