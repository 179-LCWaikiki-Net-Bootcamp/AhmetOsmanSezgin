using AutoMapper;
using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using ProductAPI.Application.ProductOperations;
using ProductAPI.Application.ProductOperations.Validators;
using ProductAPI.DbOperations;
using ProductAPI.Models;

namespace ProductAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductDbContext _context;
        private readonly IMapper _mapper;

        public ProductsController(IProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            GetProductsQuery query = new(_context, _mapper);

            var result = query.Handle();

            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }

        [HttpGet("{id}")]
        public IActionResult GetProductById(int id)
        {
            GetProductDetailQuery query = new(_context, _mapper);
            GetProductDetailQueryValidator validator = new();

            query.ProductId = id;

            var validationResult = validator.Validate(query);

            if(validationResult.IsValid)
            {
                var result = query.Handle();

                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest(validationResult.Errors[0].ErrorMessage);
        }

        [HttpGet("name")]
        public IActionResult GetProductByName([FromQuery] string value)
        {
            GetProductByNameQuery query = new(_context, _mapper);
            GetProductByNameQueryValidator validator = new();

            query.ProductName = value;

            var validationResult = validator.Validate(query);

            if (validationResult.IsValid)
            {
                var result = query.Handle();

                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest(validationResult.Errors[0].ErrorMessage);
        }

        [HttpPost]
        public IActionResult AddProduct([FromBody] CreateProductModel newProduct)
        {
            CreateProductCommand command = new(_context, _mapper);
            CreateProductCommandValidator validator = new();

            command.Model = newProduct;

            var validationResult = validator.Validate(command);

            if (validationResult.IsValid)
            {
                var result = command.Handle();

                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest(validationResult.Errors[0].ErrorMessage);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateProduct(int id, [FromBody] UpdateProductModel updatedProduct)
        {
            UpdateProductCommand command = new(_context);
            UpdateProductCommandValidator validator = new();

            command.ProductId = id;
            command.Model = updatedProduct;

            var validationResult = validator.Validate(command);

            if (validationResult.IsValid)
            {
                var result = command.Handle();

                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest(validationResult.Errors[0].ErrorMessage);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteProduct(int id)
        {
            DeleteProductCommand command = new(_context);
            DeleteProductCommandValidator validator = new();

            command.ProductId = id;

            var validationResult = validator.Validate(command);

            if (validationResult.IsValid)
            {
                var result = command.Handle();

                if (result.Success)
                {
                    return Ok(result);
                }

                return BadRequest(result);
            }

            return BadRequest(validationResult.Errors[0].ErrorMessage);

        }
    }
}
