using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassEntidades;
using ClassDatos;
using System.Data;

namespace ClassNegocio
{
    public class Classnegocio
    {
        ClassDato ejecutor = new ClassDato();
        public void Create(ClassEn estudi)
        {
            ejecutor.Create(estudi);
        }
        public DataTable Read()
        {
            return ejecutor.Read();
        }

        public void modificar(ClassEn estudi)
        {
            ejecutor.Update(estudi);
        }

        public void Delete(ClassEn estudi)
        {
            ejecutor.Delete(estudi);
        }

        public DataTable FiltrarManzana(string valor)
        {
            return ejecutor.FiltrarManzana(valor);
        }

        public DataTable FiltrarEdificio(string valor)
        {
            return ejecutor.FiltrarEdificio(valor);
        }

        public DataTable CargarManza()
        {
            return ejecutor.CargarMAN();
        }

        public DataTable CargarEdif()
        {
            return ejecutor.CargarEDI();
        }

    }
}
