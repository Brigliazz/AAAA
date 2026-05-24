using System;

namespace AAAA
{
    public class Genere
    {
        public const string Pop = "Pop";
        public const string Rock = "Rock";
        public const string Jazz = "Jazz";
        public const string Classica = "Classica";
        public const string HipHop = "Hip-Hop";
        public const string Elettronica = "Elettronica";

        private string nome;
        private string descrizione;

        public Genere(string nome, string descrizione)
        {
            this.nome = nome;
            this.descrizione = descrizione;
        }

        public Genere(string nome)
        {
            this.nome = nome;
            this.descrizione = "Nessuna descrizione disponibile";
        }

        public string GetNome() => nome;
        public void SetNome(string nome) => this.nome = nome;

        public string GetDescrizione() => descrizione;
        public void SetDescrizione(string descrizione) => this.descrizione = descrizione;

        public bool IsGenere(string genere)
        {
            return nome.Equals(genere, StringComparison.OrdinalIgnoreCase);
        }

        public override string ToString()
        {
            return $"Genere: {nome} | Descrizione: {descrizione}";
        }
    }
}
