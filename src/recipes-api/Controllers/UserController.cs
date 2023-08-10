using Microsoft.AspNetCore.Mvc;
using recipes_api.Services;
using recipes_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace recipes_api.Controllers;

[ApiController]
[Route("user")]
public class UserController : ControllerBase
{
    public readonly IUserService _service;

    public UserController(IUserService service)
    {
        this._service = service;
    }

    [HttpGet("{email}", Name = "GetUser")]
    public IActionResult Get(string email)
    {
        var user = _service.GetUser(email);

        if (user == null)
        {
            return NotFound();
        }

        return Ok(user);
    }

    
    [HttpPost]
    public IActionResult Create([FromBody] User user)
    {
        if (user == null)
        {
            return BadRequest();
        }

        _service.AddUser(user);

        return Created("", user);
    }

    
    [HttpPut("{email}")]
    public IActionResult Update(string email, [FromBody] User user)
    {
        var userExists = _service.UserExists(email);

        if (userExists)
        {
            var userUpdate = _service.GetUser(email);

            if (userUpdate.Email != user.Email)
            {
                return BadRequest();
            }
            _service.UpdateUser(user);
            return Ok();
        }

        return NotFound();
    }

    
    [HttpDelete("{email}")]
    public IActionResult Delete(string email)
    {
        var emailExists = _service.UserExists(email);
        if (!emailExists)
        {
            return NotFound();
        }

        _service.DeleteUser(email);

        return NoContent();
    }
}