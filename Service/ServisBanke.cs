using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class ServisBanke : IRacun
    {
        Dictionary<long, Racun> racuni = new Dictionary<long, Racun>();
        public void Isplata(long brRacuna)
        {
            throw new NotImplementedException();
        }

        public void OtvoriRacun(Racun racun)
        {
            if (racuni.ContainsKey(racun.BrRacuna))
            {
                Izuzetak iz = new Izuzetak("Racun vec postoji.");
                throw new FaultException<Izuzetak>(iz);
            }
            racuni.Add(racun.BrRacuna, racun);
        }

        public void ProveriStanje(long brRacuna)
        {
            throw new NotImplementedException();
        }

        public void Uplata(Racun uplata)
        {
            Console.WriteLine("Unesite iznos za uplatu.");
            string zaUplatu = Console.ReadLine();

            // uplata.Iznos += (double)zaUplatu; https://www.educba.com/convert-string-to-double-in-c-sharp/


        }

        public void ZatvoriRacun(long brRacuna)
        {
            if (!racuni.ContainsKey(brRacuna))
            {
                Izuzetak iz = new Izuzetak("Racun ne postoji.");
                throw new FaultException<Izuzetak>(iz);
            }
            racuni.Remove(brRacuna);
        }
    }
}
