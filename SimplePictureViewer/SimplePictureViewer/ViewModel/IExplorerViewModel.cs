using SimplePictureViewer.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePictureViewer.ViewModel
{
    public interface IExplorerViewModel
    {
        ExplorerDirectory Current { get; set; }
    }
}