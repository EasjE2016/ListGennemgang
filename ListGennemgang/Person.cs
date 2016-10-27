using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListGennemgang
{
    class Person
    {

        public string Navn { get; private set; }
        public int IQ { get; private set; }
        public string Klassenavn { get; private set; }

        public void Print()
        {
            Console.WriteLine($"navn er : {this.Navn} og IQ er: {this.IQ} klassenavn : {this.Klassenavn}");
        }

        public Person(string navn, int iq, string klassenavn)
        {
            this.Navn = navn;
            this.IQ = iq;
            this.Klassenavn = klassenavn;
        }

        public void SetIq(int nyIQ)
        {
            this.IQ = nyIQ;
        }

    }
   

}
