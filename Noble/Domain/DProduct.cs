using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
namespace Domain
{
    public class DProduct
    {
        DaoProduct daoProduct = new DaoProduct();
        public DataTable MostrarDatosProducto()
        {
            return daoProduct.MostrarDatosProducto();
        }
    }
}
