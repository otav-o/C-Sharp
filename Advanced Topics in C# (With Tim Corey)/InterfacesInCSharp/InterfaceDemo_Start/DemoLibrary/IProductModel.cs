using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public interface IProductModel
    {
        // things any class that implement this contract will have (at least these)
        // everything in a interface is public

        string Title { get; set; }
        bool HasOrderBeenCompleted { get; }
        void ShipItem(CustomerModel customer);

        // properties and methods signature


    }
}
