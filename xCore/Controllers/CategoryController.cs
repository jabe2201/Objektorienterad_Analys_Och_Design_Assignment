using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using xCore.Models.DTOs;
using xCore.Repositories;

namespace xCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly CategoryRepo _categoryRepo;

        public CategoryController(CategoryRepo categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryRequest categoryRequest)
        {
            if(ModelState.IsValid)
            {
                var response = await _categoryRepo.CreateAsync(categoryRequest);
                if (response != null)
                {
                    return Created("", response);
                }
                return BadRequest("Could not Create");
            }
            return BadRequest("Please enter all mandatory fields");
        }

    }
}
