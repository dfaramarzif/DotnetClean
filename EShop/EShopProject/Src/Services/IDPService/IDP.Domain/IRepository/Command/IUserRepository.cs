using IDP.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace IDP.Domain.IRepository.Command
{
    public interface IUserRepository
    {
        public Task<bool> Insert(User user);
    }
}
