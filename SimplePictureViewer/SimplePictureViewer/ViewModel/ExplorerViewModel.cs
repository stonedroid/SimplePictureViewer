using SimplePictureViewer.Domain;
using SimplePictureViewer.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.ViewModel
{
    public class ExplorerViewModel
    {
        private ExplorerService explorerService;

        public ExplorerDirectory Current { get; set; }

        public ExplorerViewModel()
        {
            //TODO consider using dependency injection
            this.explorerService = new ExplorerService();
            this.Current = explorerService.HomeDirectory;
        }
    }
}
