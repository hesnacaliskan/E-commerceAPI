using Microsoft.AspNetCore.Identity;
using SimpraFinalProject.Application.Abstractions.Services;
using SimpraFinalProject.Application.DTOs.User;
using SimpraFinalProject.Domain.Entities.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpraFinalProject.Persistence.Services
{
    public class UserService : IUserService
    {
        readonly UserManager<AppUser> _userManager;
        //readonly IEndpointReadRepository _endpointReadRepository;

        public UserService(UserManager<AppUser> userManager
            /*IEndpointReadRepository endpointReadRepository*/)
        {
            _userManager = userManager;
            //_endpointReadRepository = endpointReadRepository;
        }

        public async Task<CreateUserResponse> CreateAsync(CreateUser model)
        {
            IdentityResult result = await _userManager.CreateAsync(new()
            {
                Id = Guid.NewGuid().ToString(),
                UserName = model.Username,
                Email = model.Email,
                NameSurname = model.NameSurname,
            }, model.Password);

            CreateUserResponse response = new() { Succeeded = result.Succeeded };

            if (result.Succeeded)
                response.Message = "Kullanıcı başarıyla oluşturulmuştur.";
            else
                foreach (var error in result.Errors)
                    response.Message += $"{error.Code} - {error.Description}\n";

            return response;
        }
    }
}
