using LoadTracking.Core.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadTracking.Core
{
    public interface IWorkContext
    {
        User CurrentUser { get; set; }
    }
}
