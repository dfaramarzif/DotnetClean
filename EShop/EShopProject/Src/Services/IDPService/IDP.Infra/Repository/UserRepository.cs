using IDP.Domain.Entities;
using IDP.Domain.IRepository.Command;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Infra.Repository
{
    public class UserRepository : IUserRepository
    {
        public async Task<bool> Insert(User user)
        {
            return true;
        }
    }
}
