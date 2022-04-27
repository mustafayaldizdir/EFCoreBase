using EFCoreBase.Application.ControllerBases;
using EFCoreBase.Application.Dto;
using EFCoreBase.Application.Dto.Category;
using EFCoreBase.Application.Interfaces.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EFCoreBase.API.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var categories =await  _categoryService.GetAllAsync();

            return CreateActionResultInstance(categories);
        }

        [HttpGet]
        public async Task<IActionResult> GetById(string id)
        {
            var category = await _categoryService.GetByIdAsync(id);
            return CreateActionResultInstance(category);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CategoryDto categoryDto)
        {
            var response = new Response<CategoryDto>();
            try
            {
                response = _categoryService.CreateAllAsync(categoryDto).Result;
            }
            catch (Exception ex)
            {

            }
            return CreateActionResultInstance(response);
        }
    }
}
