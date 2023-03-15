using System.Xml.Serialization;
using static modul4_1302210124.kodeBuah;

namespace modul4_1302210124 {
    internal class program { 
        public static void Main(string[] args) {
            kodeBuah namaBuah = new kodeBuah();       
          
            string kode = getKodeBuah.getkodeBuah(kodeBuah.buah.Semangka);
            Console.WriteLine("Nama Buah: " + kodeBuah.buah.Semangka + " Kode Buah: " + kode);
            string kode1 = getKodeBuah.getkodeBuah(kodeBuah.buah.Pisang);
            Console.WriteLine("Nama Buah: " + kodeBuah.buah.Pisang + " Kode Buah: " + kode);
        }
    }

}