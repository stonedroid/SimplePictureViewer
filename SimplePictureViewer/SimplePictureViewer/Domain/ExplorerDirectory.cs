using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace SimplePictureViewer.Domain
{
    public class ExplorerDirectory : ExplorerItem
    {
        private readonly List<ExplorerItem> children;

        public IEnumerable<ExplorerItem> Children
        {
            get
            {
                return children.AsReadOnly();
            }
        }

        public override ImageSource ImageSource
        {
            get
            {
                return null;
            }
        }

        public ExplorerDirectory(string name, string path) : base(name, path)
        {
            this.children = new List<ExplorerItem>();
        }

        public void AddChild(ExplorerItem child)
        {
            child.Parent = this;
            children.Add(child);
        }

        public void AddChildren(IEnumerable<ExplorerItem> children)
        {
            foreach (ExplorerItem child in children)
            {
                child.Parent = this;
            }
            this.children.AddRange(children);
        }
    }
}
