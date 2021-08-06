using System.Threading.Tasks;
using API.Entities;
using API.Helpers;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
     [ServiceFilter(typeof(LogUserActivity))]
     [ApiController]
     [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {
        
    }

}