using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimplePictureViewer.Domain
{
    public class ExplorerImage : ExplorerItem
    {
        public string Extension { get; private set; }

        public override ImageSource ImageSource
        {
            get 
            {
                return (ImageSource)new ImageSourceConverter().ConvertFromString(Path);
            }
        }

        public ExplorerImage(string name, string path, string extension) : base(name, path)
        {
            this.Extension = extension;
        }
    }
}
