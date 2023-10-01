namespace Ski.Data
{
  public class SkiTime 
  { 
    public int Minutes { get; set; }
    public int Seconds { get; set; }
    public bool DNQ { get; set; }
    public int TotalSeconds => + (Minutes * 60) + Seconds;

    public SkiTime AddTime(SkiTime otherTime)
    {
      int totalSeconds = TotalSeconds + otherTime.TotalSeconds;

      int minutes = totalSeconds / 60;
      int seconds = totalSeconds % 60;

      return new SkiTime { Minutes = minutes, Seconds = seconds };
    }
  }
}
