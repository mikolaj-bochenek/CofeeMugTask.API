using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using CoffeeMugTask.API.Core;
using CoffeeMugTask.API.DTOs;
using CoffeeMugTask.API.Helpers;
using CoffeeMugTask.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoffeeMugTask.API.Controllers
{
    // localhost:5000/api/v1/product
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;
        public ProductController(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _mapper = mapper;
            _unitOfWork = unitOfWork;
        }

        [HttpGet("{productId}")]
        public async Task<IActionResult> GetOneAsync(int productId)
        {
            var product = await _unitOfWork.Products.GetOneAsync(productId);

            if (product == null)
                return BadRequest("BadRequest: The product cannot be found");
            
            return Ok(product);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllAsync([FromQuery]ProductParams planParams)
        {
            var products = await _unitOfWork.Products.GetAllAsync(planParams);

            if (products.Count == 0)
                return BadRequest("BadRequest: Products cannot be found");

            Response.AddPagination(products.CurrentPage, products.PageSize, products.TotalItemsCount, products.TotalPagesCount);

            return Ok(products);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAsync(ProductForCreateDTO productForCreateDTO)
        {
            var productToCreate = _mapper.Map<ProductModel>(productForCreateDTO);

            _unitOfWork.Products.CrateProduct(productToCreate);


            if (await _unitOfWork.SaveAllAsync())
                return Ok(productToCreate.Id);
            
            throw new Exception("Exception: An error occured trying to save a new product to database");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAsync(ProductFroUpdateDTO productFroUpdateDTO)
        {
            var productToUpdate = await _unitOfWork.Products.GetOneAsync(productFroUpdateDTO.Id);

            if (productToUpdate == null)
                return BadRequest("BadRequest: The product cannot be found");
            
            var productToEqual = _mapper.Map<ProductModel>(productFroUpdateDTO);

            var updatedProduct = _mapper.Map(productFroUpdateDTO, productToUpdate);

            if (productToUpdate == productToEqual)
                return StatusCode(304);

            if (await _unitOfWork.SaveAllAsync())
                return Ok($"Info: The product of id {productFroUpdateDTO.Id} has been updated successfully");
            
            throw new Exception("Exception: An error occured trying to save an updated product to database");
        }

        [HttpDelete("{productId}")]
        public async Task<IActionResult> RemoveAsync(int productId)
        {
            var productToRemove = await _unitOfWork.Products.GetOneAsync(productId);

            if (productToRemove == null)
                return BadRequest("BadRequest: The product cannot be found");
            
            _unitOfWork.Products.RemoveProduct(productToRemove);

            if (await _unitOfWork.SaveAllAsync())
                return Ok($"Info: The product of id {productId} has been removed successfully");
            
            throw new Exception("Exception: An error occured trying to remove a product from database");
        }
    }
}