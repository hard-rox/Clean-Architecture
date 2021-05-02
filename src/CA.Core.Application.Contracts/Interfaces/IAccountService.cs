﻿using CA.Core.Application.Contracts.DataTransferObjects;
using CA.Core.Application.Contracts.Response;
using System.Collections.Generic;
using System.Security.Claims;
using System.Threading.Tasks;

namespace CA.Core.Application.Contracts.Interfaces
{
    public interface IAccountService
    {
        Task<Response<UserIdentityDto>> RegisterUserAsync(RegisterUserDto registerUserDto);
        Task<Response<UserIdentityDto>> CookieSignInAsync(LoginUserDto loginUserDto);
        Task<Response<IList<Claim>>> GetAllClaims(ClaimsPrincipal claimsPrincipal);
        Task<Response<IList<string>>> GetRolesAsync(ClaimsPrincipal claimsPrincipal);
        Task CookieSignOutAsync();


    }
}
