using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ADOExample;
using Microsoft.AspNetCore.Mvc;


namespace WebService.Controllers
{ 
    
    [ApiController]
    [Route("api/categories")]
    public class CategoriesController : ControllerBase
    {
        IDataService _dataService;

        public CategoriesController(IDataService dataService)
        {
            _dataService = dataService;
        }

        [HttpGet]
        public IActionResult GetCategories() 
        {
            var categories = _dataService.GetCategories();

            return Ok(categories);
            
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id) 
        {
            var category = _dataService.GetCategory(id);
            if (category== null) 
            {
                return NotFound();
            }
            return Ok(category);            
        }


    } 
}
