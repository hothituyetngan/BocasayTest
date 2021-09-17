using AutoMapper;
using Bocasay.Domain.Models;

namespace Bocasay.Application.UseCases.UserManagement.Commands
{
    public class CreateUserProfile : Profile
    {
        public CreateUserProfile()
        {
            CreateMap<CreateUserRequest, User>();
        }
    }
}
