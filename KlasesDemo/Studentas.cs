using System;

namespace KlasesDemo
{
    internal class Studentas : Zmogus
    {
        internal int studentoPazymejimoNr;
        internal string aukstojiMokykla;

        internal Studentas(string vardas, double ugis, int amzius, int studentoPazymejimoNr, string aukstojiMokykla) : base(vardas, ugis, amzius)
        {
            this.studentoPazymejimoNr = studentoPazymejimoNr;
            this.aukstojiMokykla = aukstojiMokykla;
        }

        internal Studentas(int studentoPazymejimoNr, string aukstojiMokykla) : base()
        {
            this.studentoPazymejimoNr = studentoPazymejimoNr;
            this.aukstojiMokykla = aukstojiMokykla;
        }

        internal override void PasakojaApieSave()
        {
            base.PasakojaApieSave();
            Console.WriteLine($"Aš esu studentas {aukstojiMokykla} aukstojoje mokykloje");
        }
    }
}
