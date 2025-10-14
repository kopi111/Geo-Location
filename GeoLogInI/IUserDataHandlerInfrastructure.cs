using GeoLogInDomain.DTOs.Request;
using GeoLogInDomain.DTOs.Responce;
using GeoLogInDomain.Interface.Infrastructure;
using GeoLogInDomain.Interface.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeoLogInInfrastructure
{
    public class UserDataHandlerInfrastructure : IUserDataHandlerInfrastructure

    {
        public Task<Error> checkEmail(Register register)
        {
            throw new NotImplementedException();
        }

        public Task<Error> checkEmailInDataBase(Register register)
        {
            throw new NotImplementedException();
        }

        public Task<Error> checkPassword(Register register)
        {
            throw new NotImplementedException();
        }

        public Task<Error> checkTelephoneNumber(Register register)
        {
            throw new NotImplementedException();
        }

        public Task<Error> checkUserText(Register register)
        {
            throw new NotImplementedException();
        }
    }


}

