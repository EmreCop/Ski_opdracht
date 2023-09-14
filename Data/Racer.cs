// Ignore Spelling: Rugnummer Voornaam

namespace Ski.Data
{
    public class Racer
    {
        public int? Rugnummer { get; set; }
        public string Voornaam { get; set; }
        public string Achternaam { get; set; }
        public string Geslacht { get; set; }
        public DateOnly? Geboortejaar { get; set; }
        public string Categorie { get; set; }

        public TimeOnly Run1 { get; set; }
        public TimeOnly Run2 { get; set; }
        public TimeOnly Run3 { get; set; }
    }



}