using Microsoft.AspNetCore.Mvc;

namespace backend.controllers;

public class UserController : Controller
{
    [HttpGet]

    public IActionResult GetAllUsers()
    {
        return Ok("users");
    }
}
