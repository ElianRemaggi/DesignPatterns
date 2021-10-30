using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    class CheckFacade
    {
        private AvionAPI avionapi;
        private HotelAPI hotelapi;

        public CheckFacade()
        {
            this.avionapi = new AvionAPI();
            this.hotelapi = new HotelAPI();
        }

        public void buscar(String fechaIda, String fechaVuelta, String origen, String destino)
        {
            this.avionapi.buscarVuelos(fechaIda,fechaVuelta,origen,destino);
            this.hotelapi.buscarHoteles(fechaIda, fechaVuelta);

        }
    }
}
