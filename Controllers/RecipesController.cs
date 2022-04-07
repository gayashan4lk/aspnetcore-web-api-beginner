using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RamenRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        [HttpGet("dishes")] // /api/recipes/dishes
        public string[] GetDishes()
        {
            string[] dishes = { "Chicken Ramen", "Pork Ramen", "Beef Ramen", "Traditional Ramin", "Miso Ramen" };
            return dishes;
        }

        [HttpGet("dish/{id}")] // /api/recipes/dish/0 will return Chicken Ramen
        public string GetDish(string id)
        {
            int index = int.Parse(id);
            string[] dishes = { "Chicken Ramen", "Pork Ramen", "Beef Ramen", "Traditional Ramin", "Miso Ramen" };
            return dishes[index];
        }

        [HttpGet("recipes")] // /api/recipes/recipes
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Chicken Ramen", "Pork Ramen", "Beef Ramen", "Traditional Ramin", "Miso Ramen", "Seafood Ramen" };

            if(!recipes.Any())
            {
                return NotFound();
            }
            return Ok(recipes);
        }

        [HttpPost] // /api/recipes/
        public ActionResult CreateNewRecipes()
        {
            bool success = true;

            if (success)
            {
                return StatusCode(201);
            }
            else
            {
                return BadRequest();
            }
        }

        [HttpDelete("all")] // /api/recipes/all
        public ActionResult DeleteRecipes()
        {
            bool shitHappens = false;

            if(shitHappens)
            {
                return BadRequest();
            }
            return NoContent();
        }
    }
}
