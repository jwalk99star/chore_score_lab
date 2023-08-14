using chores_api_csharp.Models;
using chores_api_csharp.Services;
using Microsoft.AspNetCore.SignalR.Protocol;

namespace chores_api_csharp.Controllers;

[ApiController]

[Route("api/[controller]")]

public class ChoresController : ControllerBase
{
  // [HttpGet]
  // public string ChoreTest()
  // {
  //   return ("ChoreTest worked!");
  // }

  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }


  [HttpGet]
  public ActionResult<List<Chore>> GetChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetChores();
      return Ok(chores);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpGet("{choreName}")]
  public ActionResult<Chore> GetChoreByName(string choreName)
  {
    try
    {
      Chore chore = _choresService.GetChoreByName(choreName);
      return Ok(chore);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> CreateChore([FromBody] Chore choreData)
  {
    try
    {
      Chore chore = _choresService.CreateChore(choreData);
      return Ok(chore);
    }
    catch (Exception error)
    {
      return BadRequest(error.Message);
    }
  }

  [HttpDelete("{choreName}")]
  public ActionResult<string> RemoveChore(string choreName)
  {
    try
    {
      Chore chore = _choresService.RemoveChore(choreName);
      return Ok($"{chore.Name} has been removed.");
    }
    catch (Exception error)
    {
        return BadRequest(error.Message);
    }
  }

  [HttpPut("{choreName}")]
  public ActionResult<string> UpdateChore(string choreName);
  {
    try
    {
      Chore chore = _choresService.UpdateChore(choreName);
    }
    catch (Exception error)
    {
        return BadRequest
    }
  }

}