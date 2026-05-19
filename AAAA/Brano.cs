// Aggiunge la classe Brano che rappresenta un brano musicale con titolo, autore e durata.
// Metodi: costruttore, getTitolo, getAutore, getDurata, setTitolo, setAutore, setDurata, ToString, shortSong

namespace AAAA
{
    public class Brano
    {
        // Durata espressa in secondi (double). Si può usare anche minuti se preferito, basta essere coerenti.
        private string titolo;
        private string autore;
        private double durata;

        // Costruttore che riceve titolo, autore e durata
        public Brano(string titolo, string autore, double durata)
        {
            this.titolo = titolo ?? string.Empty;
            this.autore = autore ?? string.Empty;
            this.durata = durata;
        }

        // Metodi getter
        public string getTitolo()
        {
            return titolo;
        }

        public string getAutore()
        {
            return autore;
        }

        public double getDurata()
        {
            return durata;
        }

        // Metodi setter
        public void setTitolo(string titolo)
        {
            this.titolo = titolo;
        }

        public void setAutore(string autore)
        {
            this.autore = autore;
        }

        public void setDurata(double durata)
        {
            this.durata = durata;
        }

        // Restituisce una stringa con tutti i dati dell'oggetto
        public override string ToString()
        {
            return $"Titolo: {titolo}, Autore: {autore}, Durata (s): {durata}";
        }

        // Restituisce true se la durata del brano è inferiore a durataLimite
        public bool shortSong(double durataLimite)
        {
            return this.durata < durataLimite;
        }
    }
}
