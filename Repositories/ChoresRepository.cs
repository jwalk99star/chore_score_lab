using chores_api_csharp.Models;

namespace chores_api_csharp.Repositories;

public class ChoresRepository
{
  private List<Chore> dbChores;

  public ChoresRepository()
  {
    dbChores = new List<Chore>();
    dbChores.Add(new Chore("Lawn", 1, false));
    dbChores.Add(new Chore("Laundry", 2, false));
    dbChores.Add(new Chore("Dishes", 5, true));
  }

  internal Chore CreateChore(Chore choreData)
  {
    dbChores.Add(choreData);
    return choreData;
  }

  internal Chore GetChoreByName(string choreName)
  {
    Chore foundChore = dbChores.Find(chore => chore.Name.ToLower() == choreName.ToLower());
    return foundChore;
  }

  internal List<Chore> GetChores()
  {
    return dbChores;
  }

  internal Chore RemoveChore(string choreName)
  {
    Chore choreToBeRemoved = GetChoreByName(choreName);
    dbChores.Remove(choreToBeRemoved);
    return choreToBeRemoved;
  }

  internal Chore UpdateChore(string choreName)
  {
    Chore choreToUpdate = GetChoreByName(choreName);
    dbChores.
  }

}