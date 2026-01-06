using Asp.Versioning;
using IDP.Api.Controllers.BaseController;
using IDP.Application.Command.User;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace IDP.Api.Controllers.V1
{

    [ApiController]

    [ApiVersion(1)]
    [ApiVersion(2)]
    [Route("api/v{v:apiVersion}/[controller]")]
    public class UserController : IBaseController
    {
        private readonly IMediator _mediator;
        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }
        /// <summary>
        /// افزودن کاربر
        /// </summary>
        /// <returns></returns>
        [HttpPost("Insert")]
        [MapToApiVersion(1)]
        public async Task<IActionResult> Insert([FromBody] UserCommand userCommand)
        {
            var res = await _mediator.Send(userCommand);
            return Ok();
        }
    }
}
