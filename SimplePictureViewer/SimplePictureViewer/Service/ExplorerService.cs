using SimplePictureViewer.Domain;
using SimplePictureViewer.FileSystem;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.Service
{
    public class ExplorerService
    {
        FileSystemHelper fileSystemHelper;

        public ExplorerService()
        {
            //TODO consider using dependency injection
            this.fileSystemHelper = new FileSystemHelper();
        }

        public ExplorerDirectory GetHomeDirectory()
        {
            return fileSystemHelper.GetHomeDirectory();
        }
    }
}
