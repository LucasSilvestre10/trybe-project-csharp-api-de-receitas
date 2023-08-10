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
[Route("recipe")]
public class RecipesController : ControllerBase
{
    public readonly IRecipeService _service;

    public RecipesController(IRecipeService service)
    {
        this._service = service;
    }


    [HttpGet]
    public IActionResult Get()
    {
        var result = _service.GetRecipes();

        return Ok(result);
    }


    [HttpGet("{name}", Name = "GetRecipe")]
    public IActionResult Get(string name)
    {
        var result = _service.GetRecipe(name);

        if (result == null)
        {
            return NotFound();
        }

        return Ok(result);
    }

    // 3 - Sua aplicação deve ter o endpoint POST /recipe
    [HttpPost]
    public IActionResult Create([FromBody] Recipe recipe)
    {
        if (recipe == null)
        {
            return BadRequest();
        }

        _service.AddRecipe(recipe);

        return Created("", recipe);
    }


    // 4 - Sua aplicação deve ter o endpoint PUT /recipe
    [HttpPut("{name}")]
    public IActionResult Update([FromBody] Recipe recipe)
    {

        var recipeExists = _service.RecipeExists(recipe.Name);
        if (recipeExists)
        {
            _service.UpdateRecipe(recipe);
            return NoContent();
        }

        return BadRequest();

    }



    // 5 - Sua aplicação deve ter o endpoint DEL /recipe

    [HttpDelete("{name}")]
    public IActionResult Delete(string name)
    {
        var existingRecipe = _service.GetRecipe(name);

        if (existingRecipe == null)
        {
            return NotFound();
        }

        _service.DeleteRecipe(name);

        return NoContent();
    }
}
