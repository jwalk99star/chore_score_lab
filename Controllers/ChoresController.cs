namespace chores_api_csharp.Controllers;

[ApiController]

[Route("api/[controller]")]

public class ChoresController : ControllerBase
{
  [HttpGet]
  public string ChoreTest()
  {
    return "ChoreTest worked!"
  }
}