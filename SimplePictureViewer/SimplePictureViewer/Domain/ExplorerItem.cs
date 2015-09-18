using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.Domain
{
    public abstract class ExplorerItem
    {
        public ExplorerDirectory Parent { get; set; }
        public string Name { get; private set; }

        public ExplorerItem(string name)
        {
            this.Name = name;
        }
    }
}
