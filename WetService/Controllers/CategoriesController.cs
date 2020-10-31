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
        [HttpGet("api/categories")]
        public JsonResult GetCategories() 
        {
            var ds = new DataService();
            var categories = ds.GetCategories();

            return new JsonResult(categories);
            
        }

    }
}
