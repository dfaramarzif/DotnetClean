using IDP.Application.Command.User;
using IDP.Domain.IRepository.Command;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Application.Handler.Command.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {
        private readonly IUserRepository _userRepository;
        public UserHandler(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            var r = await _userRepository.Insert(new Domain.Entities.User { FulleName = request.FulleName, NationalCode = request.NationalCode });
            return r;
        }
    }
}
