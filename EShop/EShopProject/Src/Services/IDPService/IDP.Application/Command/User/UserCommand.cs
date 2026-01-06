using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace IDP.Application.Command.User
{
    public record UserCommand : IRequest<bool>
    {
        [Required(ErrorMessage = "نام الزامی است")]
        [MinLength(5)]
        public required string FulleName { get; set; }
        public required string NationalCode { get; set; }
    }
}
