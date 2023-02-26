using Microsoft.AspNetCore.Mvc;

namespace App.WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DbController : ControllerBase
{
    private readonly ApiDbContext _db;

    public DbController(ApiDbContext db)
    {
        _db = db;
    }

    [HttpGet("Info")]
    public string Info()
    {

        var teams = _db.Teams;

        return $"Teams.Count:{teams.Count()}";
    }

    [HttpPost("AddTeam")]
    public string AddTeam()
    {

        var guid = Guid.NewGuid();
        _db.Teams.Add(new Team { Id = guid  , Name = "Team-" + guid.ToString().Substring(0,4) });
        _db.SaveChanges();

        var teams = _db.Teams;

        return $"Teams.Count:{teams.Count()}";
    }
}
