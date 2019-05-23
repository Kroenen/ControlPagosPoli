using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPagos.Domain
{
    public class PagosControlContext:DbContext
    {
        public PagosControlContext():base("DefaultConnection")
        {

        }

        public DbSet<ControlPagos.Common.Models.Temas> Temas { set; get; }
    }
}
