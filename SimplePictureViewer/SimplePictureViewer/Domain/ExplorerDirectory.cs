using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public ExplorerDirectory(string name) : base(name)
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
