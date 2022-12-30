using Microsoft.AspNetCore.Mvc;
using ReverseAPI.Services;

namespace ReverseAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReverseController : ControllerBase
    {
        private readonly ReverseService _reverseService;

        public ReverseController(ReverseService reverseService)
        {
            _reverseService = reverseService;
        }

        [HttpPost]
        public string? ReverseString([FromBody] ApiRequest request)
        {
            return request.Word != null ? _reverseService.ReverseString(request.Word) : null;
        }
    }
}