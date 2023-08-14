namespace chores_api_csharp.Models;

public class Chore
{
  public string Name { get; set; }
  public int Repetition { get; set; }
  public bool Complete { get; set; }

  public Chore(string name, int repetition, bool complete)
  {
    Name = name;
    Repetition = repetition;
    Complete = complete;
  }
}