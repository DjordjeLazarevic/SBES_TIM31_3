using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [ServiceContract]
    public interface IRacun
    {
        [OperationContract]
        [FaultContract(typeof(Izuzetak))]
        void OtvoriRacun(Racun racun);
        [OperationContract]
        [FaultContract(typeof(Izuzetak))]
        void ZatvoriRacun(long brRacuna);
        [OperationContract]
        void ProveriStanje(long brRacuna);
        [OperationContract]
        void Uplata(Racun uplata);
        [OperationContract]
        void Isplata(long brRacuna);

    }
}
