using IDP.Application.Command.User;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Application.Handler.Command.User
{
    public class UserHandler : IRequestHandler<UserCommand, bool>
    {
        public async Task<bool> Handle(UserCommand request, CancellationToken cancellationToken)
        {
            return true;
        }
    }
}
