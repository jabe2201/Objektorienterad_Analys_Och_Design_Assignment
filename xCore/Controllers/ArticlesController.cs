using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using xCore.Context;
using xCore.Models.DTOs;
using xCore.Models.Entities;
using xCore.Repositories;
using xCore.Services;

namespace xCore.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleService _articleService;
        private readonly ArticleRepo _articleRepo;

        public ArticlesController(ArticleService articleService, ArticleRepo articleRepo)
        {
            _articleService = articleService;
            _articleRepo = articleRepo;
        }
        [HttpPost]
        public async Task<IActionResult> Create(ArticleRequest request)
        {
            if(ModelState.IsValid)
            {
                var response = await _articleService.CreateAsync(request);

                if (response != null)
                {
                    return Created("Success", response);
                }
                return BadRequest("Please enter all mandatory fields");
            }
            
            return BadRequest("Article was not added");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _articleService.DeleteAsync(id);
            if(result != null)
            {
                return Ok("The article was succesfully removed!");
            }

            return BadRequest("Could not remove the article.");
        }

        [HttpGet]
        public async Task<IActionResult> Get(int id)
        {
            var response = await _articleService.GetAsync(id);
            if(response != null)
            {
                return Ok(response);
            }
            return NotFound("There is no user with that Id");
        }
        

        [HttpGet("GETALL")]
        public async Task<IEnumerable<ArticleResponse>> GetAllAsync()
        {
            var list = await _articleService.GetAllAsync();  
            return list;

        }

        [HttpPut("UPDATE")]
        public async Task<IActionResult> UpdateAsync(int id, ArticleRequest request)
        {
            if (ModelState.IsValid)
            {
                var response = await _articleService.UpdateAsync(id, request);
                if (response != null)
                {
                    return Ok(response);
                }
                return BadRequest("Please enter all the mandatory fields");
            }
            
            return BadRequest("Could not update Article");
        }

    }
}
