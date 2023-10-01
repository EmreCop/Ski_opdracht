
namespace Ski.Data
{
  public class Racer
  {
    public int? Rugnummer { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Geslacht { get; set; }
    public string CurrentYear = DateTime.Now.Year.ToString();
    public string ClubCode = "HOO";
    public string Club = "Skiteam Hoofddorp";

    public DateOnly? Geboortejaar { get; set; }
    public string? Categorie { get; set; }

    public SkiTime? Run1 { get; set; }
    public SkiTime? Run2 { get; set; }
    public SkiTime? Run3 { get; set; }

    public SkiTime? FinalTime { get; set; }

  }




}

