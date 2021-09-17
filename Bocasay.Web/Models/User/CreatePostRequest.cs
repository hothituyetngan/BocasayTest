using Bocasay.Application.UseCases.UserManagement.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Bocasay.Web.Models.User
{
    public class CreatePostRequest
    {
        [FromForm]
        public CreateUserRequest User { get; set; }
    }
}
