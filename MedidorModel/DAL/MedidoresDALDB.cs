using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedidorModel.DAL
{
    public class MedidoresDALDB : IMedidorDAL
    {
        private MedidorDBEntities1 medidorDB = new MedidorDBEntities1();

        public List<Medidor> ObtenerMedidores()
        {
            return this.medidorDB.Medidors.ToList();
        }
    }
}
