using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IDP.Application.Command.User
{
    public class UserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "نام الزامی است")]
        [MinLength(5)]
        public required string Name { get; set; }
    }
}
