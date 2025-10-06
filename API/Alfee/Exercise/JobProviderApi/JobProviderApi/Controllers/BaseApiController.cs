using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobProviderApi.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public abstract class BaseApiController<T> : ControllerBase { }
}
