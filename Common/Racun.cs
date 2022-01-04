using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    [DataContract]
    public class Racun
    {
        long brRacuna;
        double iznos;
        double dozvoljeniMinus;
        double blokiran;
        DateTime poslednjaTransakcija;
        string imeKorisnika;

        public Racun(long brRacuna, double iznos, double dozvoljeniMinus, double blokiran, DateTime poslednjaTransakcija, string imeKorisnika)
        {
            this.BrRacuna = brRacuna;
            this.Iznos = iznos;
            this.DozvoljeniMinus = dozvoljeniMinus;
            this.Blokiran = blokiran;
            this.PoslednjaTransakcija = poslednjaTransakcija;
            this.ImeKorisnika = imeKorisnika;
        }
        [DataMember]
        public long BrRacuna { get => brRacuna; set => brRacuna = value; }
        [DataMember]
        public double Iznos { get => iznos; set => iznos = value; }
        [DataMember]
        public double DozvoljeniMinus { get => dozvoljeniMinus; set => dozvoljeniMinus = value; }
        [DataMember]
        public double Blokiran { get => blokiran; set => blokiran = value; }
        [DataMember]
        public DateTime PoslednjaTransakcija { get => poslednjaTransakcija; set => poslednjaTransakcija = value; }
        [DataMember]
        public string ImeKorisnika { get => imeKorisnika; set => imeKorisnika = value; }
    }
}
