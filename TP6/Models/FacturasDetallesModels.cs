using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TP6.Models
{
    public class FacturasDetallesModels
    {
        public int _id, _facturaId, _articuloId, _cantidad;
        public double _total;

        public FacturasDetallesModels(int Id, int FacturaId, int ArticuloId, int Cantidad, double Total)
        {
            this._id = Id;
            this._facturaId = FacturaId;
            this._articuloId = ArticuloId;
            this._cantidad = Cantidad;
            this._total = Total; 
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

        public int FacturaId
        {
            get
            {
                return _facturaId;
            }
            set
            {
                _facturaId = value;
            }
        }

        public int ArtciulosId
        {
            get
            {
                return _articuloId;
            }
            set
            {
                _articuloId = value;
            }
        }

        public int Cantidad
        {
            get
            {
                return _cantidad;
            }
            set
            {
                _cantidad = value;
            }
        }



        public double Total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

    }
}