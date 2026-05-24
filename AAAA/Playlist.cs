using System;

namespace AAAA
{
    public class Playlist
    {
        private string nome;
        private List<Brano> brani;

        public Playlist(string nome)
        {
            this.nome = nome;
            this.brani = new List<Brano>();
        }

        public string GetNome() => nome;
        public void SetNome(string nome) => this.nome = nome;
        public List<Brano> GetBrani() => brani;

        public void AggiungiBrano(Brano b)
        {
            if (!brani.Contains(b))
            {
                brani.Add(b);
                Console.WriteLine($"Brano \"{b.GetTitolo()}\" aggiunto alla playlist.");
            }
            else
            {
                Console.WriteLine($"Il brano \"{b.GetTitolo()}\" è già nella playlist.");
            }
        }

        public bool RimuoviBrano(string titolo)
        {
            Brano? trovato = brani.FirstOrDefault(b =>
                b.GetTitolo().Equals(titolo, StringComparison.OrdinalIgnoreCase));

            if (trovato != null)
            {
                brani.Remove(trovato);
                Console.WriteLine($"Brano \"{titolo}\" rimosso dalla playlist.");
                return true;
            }

            Console.WriteLine($"Brano \"{titolo}\" non trovato nella playlist.");
            return false;
        }

        public int DurataTotale()
        {
            int totale = 0;
            foreach (Brano b in brani)
                totale += b.GetDurata();
            return totale;
        }

        public List<Brano> BraniCorti(int durataLimite)
        {
            return brani.Where(b => b.ShortSong(durataLimite)).ToList();
        }

        public int NumeroBrani() => brani.Count;

        public override string ToString()
        {
            if (brani.Count == 0)
                return $"Playlist \"{nome}\" è vuota.";

            var sb = new System.Text.StringBuilder();
            sb.AppendLine($"=== Playlist: {nome} ===");
            for (int i = 0; i < brani.Count; i++)
                sb.AppendLine($"{i + 1}. {brani[i]}");

            int min = DurataTotale() / 60;
            int sec = DurataTotale() % 60;
            sb.Append($"Durata totale: {min}:{sec:D2}");
            return sb.ToString();
        }
    }
}
