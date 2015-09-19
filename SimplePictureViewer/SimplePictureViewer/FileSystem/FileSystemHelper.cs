using SimplePictureViewer.Domain;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.FileSystem
{
    public class FileSystemHelper
    {
        private string homeDirectoryPath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
        private List<string> imageExtensions;

        public FileSystemHelper()
        {
            imageExtensions = new List<string>();
            foreach (ImageCodecInfo imageCodec in ImageCodecInfo.GetImageEncoders())
            {
                imageExtensions.AddRange(imageCodec.FilenameExtension.ToLowerInvariant().Split(";".ToCharArray()).Select(x => x.ToLowerInvariant()));
            }
        }

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
                ExplorerImage child = GetImage(parent, Path.GetFileNameWithoutExtension(file), Path.GetExtension(file));
                if (child != null)
                {
                    parent.AddChild(child);
                }
            }
            foreach (var directory in Directory.GetDirectories(path))
            {
                ExplorerDirectory child = GetDirectory(parent, Path.GetFileName(directory));
                if (child != null)
                {
                    parent.AddChild(child);
                }
            }
        }

        private ExplorerImage GetImage(ExplorerDirectory parent, string name, string extension)
        {
            if(File.Exists(Path.Combine(GetPath(parent), string.Format(CultureInfo.InvariantCulture, "{0}{1}", name, extension))) && IsImageExtension(extension))
            {
                return new ExplorerImage(name, extension);
            }
            return null;
        }

        private bool IsImageExtension(string extension)
        {
            return imageExtensions.Contains(string.Format(CultureInfo.InvariantCulture, "*{0}", extension).ToLowerInvariant());
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
