using EFCoreBase.Application.Dto;
using EFCoreBase.Application.Dto.Category;
using EFCoreBase.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCoreBase.Application.Interfaces.Service
{
    public interface ICategoryService
    {
        public Task<Response<List<CategoryDto>>> GetAllAsync();
        public Task<Response<CategoryDto>> CreateAllAsync(CategoryDto categoryDto);
        public Task<Response<CategoryDto>> GetByIdAsync(string id);
    }
}
