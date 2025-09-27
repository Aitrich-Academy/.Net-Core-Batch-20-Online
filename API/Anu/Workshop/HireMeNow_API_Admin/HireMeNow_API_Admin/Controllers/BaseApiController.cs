using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HireMeNow_API_Admin.Controllers
{
    [Route("api/v1")]
    public abstract class BaseApiController<T> : ControllerBase
    {

    }
}
