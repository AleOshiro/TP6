using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6.Models
{
    public class FacturasModels
    {
        public int _id;
        public DateTime _Fecha;
        public double _Precio;
        //public List<FacturaDetallesModels> _Detalle;

        public FacturasModels(int Id, DateTime Fecha, double Precio)
        {
            this._id = Id;
            this._Fecha = Fecha;
            this._Precio = Precio;
        }

        public int Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
            }
        }

        public DateTime Fecha
        {
            get
            {
                return _Fecha;
            }
            set
            {
                _Fecha = value;
            }
        }

        public double Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                _Precio = value;
            }
        }
    }
}