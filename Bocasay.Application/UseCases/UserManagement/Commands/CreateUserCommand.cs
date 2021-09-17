using AutoMapper;
using Bocasay.Domain.IRepositories;
using Bocasay.Domain.Models;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Bocasay.Application.UseCases.UserManagement.Commands
{
    public class CreateUserCommand : IRequestHandler<CreateUserRequest>
    {
        private readonly IMapper _mapper;

        private readonly IUserRepository _userRepository;

        public CreateUserCommand(IMapper mapper, IUserRepository userRepository)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public Task<Unit> Handle(CreateUserRequest request, CancellationToken cancellationToken)
        {
            var user = _mapper.Map<User>(request);

            _userRepository.Create(user);

            return Unit.Task;
        }
    }
}
