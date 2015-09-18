using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.Domain
{
    public class ExplorerImage : ExplorerItem
    {
        public string Extension { get; private set; }

        public ExplorerImage(string name, string extension) : base(name)
        {
            this.Extension = extension;
        }
    }
}
