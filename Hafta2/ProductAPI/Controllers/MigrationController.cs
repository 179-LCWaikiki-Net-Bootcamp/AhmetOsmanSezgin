using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Linq;
using AutoMapper;
using ProductAPI.Application.ProductOperations;
using ProductAPI.Models;
using ProductAPI.DbOperations;

namespace WebApi.Controllers
{
    [ApiController]
    [Route("[controller]s")]
    public class MigrationController : ControllerBase
    {

        private readonly ProductDbContext _context;
        private readonly IMapper _mapper;

        public MigrationController(ProductDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpPost("migrating")]
        public IActionResult Migrating([FromQuery] string value)
        {
            if (value.Equals("migrate"))
            {
                var migrator = _context.Database.GetService<IMigrator>();

                migrator.Migrate();

                return Ok("Successful");
            }
            else
            {
                return BadRequest("Invalid value");
            }
        }

        [HttpPost("fakedata")]
        public IActionResult FakeData([FromQuery] string value)
        {
            if(value.Equals("fakedata"))
            {
                CreateProductCommand command = new CreateProductCommand(_context, _mapper);

                int n = 10;

                for (int i = 0; i < n; i++)
                {
                    var newProduct = CreateProductModel.FakeData.Generate(1).First();
                    command.Model = newProduct;
                    var result = command.Handle();
                    if (result.Success == false)
                    {
                        return BadRequest(result);
                    }
                }
                return Ok("success");
            }
            else
            {
                return BadRequest("Invalid value");
            }
        }
    }
}