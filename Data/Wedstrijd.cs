namespace Ski.Data
{
  public class Wedstrijd
  {
    public string? WedstrijdName { get; set; }
    public Dictionary<int, Racer> Racers { get; set; } = new();
    public int? WedsrijdType { get; set; }

  }
}

 