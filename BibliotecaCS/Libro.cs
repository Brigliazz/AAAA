using System;

namespace BibliotecaCS
{
    public class Libro
    {
        private string autore;
        private string titolo;
        private int annoPubblicazione;
        private string editore;
        private int numeroPagine;

        public Libro(string autore, string titolo, int annoPubblicazione, string editore, int numeroPagine)
        {
            this.autore = autore;
            this.titolo = titolo;
            this.annoPubblicazione = annoPubblicazione;
            this.editore = editore;
            this.numeroPagine = numeroPagine;
        }

        public string Autore
        {
            get { return autore; }
            set { autore = value; }
        }

        public string Titolo
        {
            get { return titolo; }
            set { titolo = value; }
        }

        public int AnnoPubblicazione
        {
            get { return annoPubblicazione; }
            set { annoPubblicazione = value; }
        }

        public string Editore
        {
            get { return editore; }
            set { editore = value; }
        }

        public int NumeroPagine
        {
            get { return numeroPagine; }
            set { numeroPagine = value; }
        }

        public override string ToString()
        {
            return $"Titolo: {titolo} | Autore: {autore} | Anno: {annoPubblicazione} | Editore: {editore} | Pagine: {numeroPagine}";
        }

        public string ReadingTime()
        {
            if (numeroPagine < 100)
                return "Tempo di lettura: 1h";
            else if (numeroPagine <= 200)
                return "Tempo di lettura: 2h";
            else
                return $"Tempo di lettura: più di 2h (circa {numeroPagine / 50}h)";
        }
    }
}
