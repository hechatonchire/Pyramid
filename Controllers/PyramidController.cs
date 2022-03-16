using System.Text;
using System;
using System.Threading;
using Microsoft.AspNetCore.Mvc;

namespace ApiPyramid.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PyramidController : ControllerBase
{
    private readonly ILogger<PyramidController> _logger;

    public PyramidController(ILogger<PyramidController> logger)
    {
        _logger = logger;
    }

    // GET: api/Pyramid
    [HttpGet]
    public String Get()
    {
        return "Welcome to Pyramid API. Check Swagger for documentation.";
    }

    // GET: api/Pyramid
    [HttpPost]
    public String GetUser([FromQuery] int id, [FromQuery] String password)
    {
        var user = new User();
        user.WelcomeMessage = $"Hello user {id} with {password}";
        return user.WelcomeMessage;
    }

}
