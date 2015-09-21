using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimplePictureViewer.Domain
{
    public abstract class ExplorerItem
    {
        public ExplorerDirectory Parent { get; set; }
        public string Name { get; private set; }
        public string Path { get; private set; }

        public abstract ImageSource ImageSource { get; }

        public ExplorerItem(string name, string path)
        {
            this.Name = name;
            this.Path = path;
        }
    }
}
