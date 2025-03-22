using MyApp.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp.Core.Interface
{
    public interface IExternalVendorRepository
    {
        Task<CoindeskData> GetDate();
    }
}
