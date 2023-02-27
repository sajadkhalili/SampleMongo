using Microsoft.AspNetCore.Mvc;
using WebApplication1.Mit.Store.Catalog.Application.Contracts.Products;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UnitController : ControllerBase
    {
        //public UnitController(IUnitService unit)
        //{

        //}
        public IActionResult Get()
        {

            return new JsonResult("sdkjasj");
        }
    }
}
