using chores_api_csharp.Models;
using chores_api_csharp.Repositories;

namespace chores_api_csharp.Services;

public class ChoresService
{
  private readonly ChoresRepository _choresRepository;

  public ChoresService(ChoresRepository choresRepository)
  {
    _choresRepository = choresRepository;
  }

  internal Chore CreateChore(Chore choreData)
  {
    Chore chore = _choresRepository.CreateChore(choreData);
    return chore;
  }

  internal Chore GetChoreByName(string choreName)
  {
    Chore chore = _choresRepository.GetChoreByName(choreName);

    if (chore == null)
    {
      throw new Exception($"There is no chore named {choreName}");
    }

    return chore;
  }

  internal List<Chore> GetChores()
  {
      List<Chore> chores = _choresRepository.GetChores();
      return chores;
  }

  internal Chore RemoveChore(string choreName)
  {
      Chore chore = _choresRepository.RemoveChore(choreName);
      return chore;
  }
}