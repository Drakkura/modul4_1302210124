using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modul4_1302210124
{
    public class posisiKarakterGame
    {
        public enum posisiKArakter { 
            Berdiri,
            Terbang,
            Jongkok,
            Tengkurap
        }
        public enum tombol { 
            TombolW,
            TombolS,
            TombolX
        }
        posisiKArakter defaultstate = posisiKArakter.Berdiri;
        public class Transition {
            tombol Tombol;
            posisiKArakter posisiAwal;
            posisiKArakter posisiAkhir;
            public Transition(tombol tombol, posisiKArakter posisiAwal, posisiKArakter posisiAkhir) { 
                this.Tombol = tombol;
                this.posisiAkhir= posisiAkhir;
                this.posisiAwal = posisiAwal;
            }
        }

        Transition[] posisii = {
            new Transition(tombol.TombolS, posisiKArakter.Berdiri, posisiKArakter.Jongkok),
            new Transition(tombol.TombolW, posisiKArakter.Berdiri, posisiKArakter.Terbang),
            new Transition(tombol.TombolS, posisiKArakter.Jongkok, posisiKArakter.Tengkurap),
            new Transition(tombol.TombolW, posisiKArakter.Jongkok, posisiKArakter.Berdiri),
            new Transition(tombol.TombolS, posisiKArakter.Terbang, posisiKArakter.Berdiri),
            new Transition(tombol.TombolX, posisiKArakter.Terbang, posisiKArakter.Jongkok),
            new Transition(tombol.TombolW, posisiKArakter.Tengkurap, posisiKArakter.Jongkok)
        };

    }
}
