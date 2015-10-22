using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SecurityApi.Dtos;

namespace SecurityApi.Services.Contracts
{
    public interface ISecurityService
    {
        void TryToUpdateUser(UserDto dto);

        void TryToAddUser(UserDto dto);

        void TryToChangePassword(ChangePasswordDto dto);
    }
}
