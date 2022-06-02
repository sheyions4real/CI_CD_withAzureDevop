using Microsoft.AspNetCore.Mvc;
using SimpleAPI.Models;

namespace SimpleAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PlatformController : ControllerBase
{
    [HttpGet]
    public List<Platform> GetPlatforms()
    {
        List<Platform> platforms = new List<Platform>();

        platforms.Add(new Platform{
            Id=1,
            Name="Linux"
        });
        
        return platforms;
    }
}

