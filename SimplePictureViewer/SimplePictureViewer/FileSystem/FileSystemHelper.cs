using SimplePictureViewer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.FileSystem
{
    public class FileSystemHelper
    {
        public ExplorerDirectory HomeDirectory
        {
            get
            {
                //TODO test code; add real code
                var homeDirectory = new ExplorerDirectory("HomeDirectory");
                homeDirectory.AddChild(new ExplorerImage("Image1", "jpg"));
                homeDirectory.AddChild(new ExplorerImage("Image1", "jpg"));
                homeDirectory.AddChild(new ExplorerImage("Image1", "jpg"));
                homeDirectory.AddChild(new ExplorerImage("Image1", "jpg"));
                homeDirectory.AddChild(new ExplorerImage("Image1", "jpg"));
                homeDirectory.AddChild(new ExplorerImage("Image1", "jpg"));
                return homeDirectory;
            }
        }
    }
}
