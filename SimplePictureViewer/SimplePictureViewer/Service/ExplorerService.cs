using SimplePictureViewer.Domain;
using SimplePictureViewer.FileSystem;
using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.Service
{
    [Export(typeof(IExplorerService))]
    public class ExplorerService : IExplorerService
    {
        private IFileSystemHelper fileSystemHelper;

        [ImportingConstructor]
        public ExplorerService(IFileSystemHelper fileSystemHelper)
        {
            this.fileSystemHelper = fileSystemHelper;
        }

        public ExplorerDirectory GetHomeDirectory()
        {
            return fileSystemHelper.GetHomeDirectory();
        }
    }
}
