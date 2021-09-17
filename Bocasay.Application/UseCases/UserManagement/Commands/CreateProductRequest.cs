using MediatR;
using System.ComponentModel.DataAnnotations;

namespace Bocasay.Application.UseCases.UserManagement.Commands
{
    public class CreateUserRequest : IRequest
    {
        [Display(Name = "First name")]
        [Required(ErrorMessage = "{0} field is required")]
        public string FirstName { get; set; }

        [Display(Name = "Last name")]
        [Required(ErrorMessage = "{0}  field is required")]
        public string LastName { get; set; }
    }
}
