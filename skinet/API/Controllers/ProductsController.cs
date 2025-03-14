using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this will be a list of products System.Environment.Version: " + System.Environment.Version 
            + "\n" + "System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription: " + System.Runtime.InteropServices.RuntimeInformation.FrameworkDescription;
        }

        [HttpGet("{id}")]
        public string GetProduct(int id)
        {
            return "single product heigh ho";
        }
    }
}