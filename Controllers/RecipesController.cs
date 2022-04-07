using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace RamenRecipes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipesController : ControllerBase
    {
        /*[HttpGet]
        public string[] GetDishes()
        {
            string[] dishes = { "Chicken Ramen", "Pork Ramen", "Beef Ramen", "Traditional Ramin", "Miso Ramen" };
            return dishes;
        }*/

        [HttpGet]
        public ActionResult GetRecipes()
        {
            string[] recipes = { "Chicken Ramen", "Pork Ramen", "Beef Ramen", "Traditional Ramin", "Miso Ramen", "Seafood Ramen" };

            if(!recipes.Any())
            {
                return NotFound();
            }
            return Ok(recipes);
        }

        [HttpPost]
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

        [HttpDelete]
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
