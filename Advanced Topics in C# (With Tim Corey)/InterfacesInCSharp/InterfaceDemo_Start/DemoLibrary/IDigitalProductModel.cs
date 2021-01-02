using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IDigitalProductModel : IProductModel
    {
        // an interface that implements another interface
        // you can use only the more specific (see DigitalProductModel implements IDigitalProductModel and is implicity that IProductModel was signed too)
        int TotalDownloadsLeft { get; }

        // IDigitalProductModel receives all stuff form IProductModel
    }
}
