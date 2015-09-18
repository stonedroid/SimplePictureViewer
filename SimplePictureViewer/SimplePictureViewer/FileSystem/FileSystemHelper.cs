using SimplePictureViewer.Domain;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.FileSystem
{
    public class FileSystemHelper
    {
        //TODO test code; this should be the path to the real home directory
        // it could be aquired by asking the user to choose a directory on startup
        // and then persist it, so we don't need to ask on every startup
        // or maybe just use C: as default and let user change in settings
        private string homeDirectoryPath = ".";

        public ExplorerDirectory GetHomeDirectory()
        {
            var homeDirectory = new ExplorerDirectory(string.Empty);
            AddChildren(homeDirectory);
            return homeDirectory;
        }

        private void AddChildren(ExplorerDirectory parent)
        {
            string path = GetPath(parent);
            foreach (string file in Directory.GetFiles(path))
            {
                parent.AddChild(GetImage(parent, Path.GetFileNameWithoutExtension(file), Path.GetExtension(file)));
            }
            foreach (var directory in Directory.GetDirectories(path))
            {
                parent.AddChild(GetDirectory(parent, Path.GetFileName(directory)));
            }
        }

        private ExplorerImage GetImage(ExplorerDirectory parent, string name, string extension)
        {
            if(File.Exists(string.Format("{0}{1}", name, extension))) 
            {
                //TODO add image file parsing
            }
            return new ExplorerImage("TestImage1", ".jpg");
        }

        private ExplorerDirectory GetDirectory(ExplorerDirectory parent, string name)
        {
            if (Directory.Exists(Path.Combine(GetPath(parent), name)))
            {
                return new ExplorerDirectory(name);
            }
            return null;
        }

        private string GetPath(ExplorerDirectory directory)
        {
            if(directory == null) {
                return homeDirectoryPath;
            }
            if (directory.Parent == null)
            {
                return Path.Combine(homeDirectoryPath, directory.Name);
            }
            return Path.Combine(GetPath(directory.Parent), directory.Name);
        }
    }
}
