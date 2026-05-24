using System;

namespace AAAA
{
    public class Brano
    {
        private string titolo;
        private string autore;
        private int durata; 

        public Brano(string titolo, string autore, int durata)
        {
            this.titolo = titolo;
            this.autore = autore;
            this.durata = durata;
        }

        public string GetTitolo() => titolo;
        public string GetAutore() => autore;
        public int GetDurata() => durata;

        public void SetTitolo(string titolo) => this.titolo = titolo;
        public void SetAutore(string autore) => this.autore = autore;
        public void SetDurata(int durata) => this.durata = durata;

        public override string ToString()
        {
            int minuti = durata / 60;
            int secondi = durata % 60;
            return $"Titolo: {titolo} | Autore: {autore} | Durata: {minuti}:{secondi:D2}";
        }

        public bool ShortSong(int durataLimite)
        {
            return this.durata < durataLimite;
        }

        public override bool Equals(object? obj)
        {
            if (obj is Brano altro)
                return titolo.Equals(altro.titolo, StringComparison.OrdinalIgnoreCase) &&
                       autore.Equals(altro.autore, StringComparison.OrdinalIgnoreCase);
            return false;
        }

        public override int GetHashCode() => HashCode.Combine(titolo.ToLower(), autore.ToLower());
    }
}
