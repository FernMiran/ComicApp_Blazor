using ComicApp.Application.Common;
using ComicApp.Application.User.Commands;
using ComicApp.Application.User.Validations;
using ComicApp.Domain.Repositories.Commands;
using ComicApp.Domain.Repositories.Queries;
using ComicApp.Domain.Transaction;
using FluentValidation.Results;
using MediatR;
using MediatR.Wrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicApp.Application.User.CommandHandlers
{
    public class CreateUserCommandHandler : IRequestHandler<CreateUser, OperationResult>
    {
        private IUserCommandRepository _userCommandRepository;
        private IUserQueryRepository _userQueryRepository;
        private IUnitOfWork _unitOfWork;

        public CreateUserCommandHandler(IUserCommandRepository userCommandRepository, IUserQueryRepository userQueryRepository, IUnitOfWork unitOfWork)
        {
            _userCommandRepository = userCommandRepository;
            _userQueryRepository = userQueryRepository;

            _unitOfWork = unitOfWork;
        }

        public async Task<OperationResult> Handle(CreateUser request, CancellationToken cancellationToken)
        {
            Domain.Entities.User user = await _userQueryRepository.GetByUsername(request.Username);

            if (user != null)
            {
                return new OperationResult()
                {
                    Success = false,
                    ErrorMessages = new List<string> { "User already exists." }
                };
            }

            user = new Domain.Entities.User()
            {
                Username = request.Username,
                Password = request.Password
            };

            await _userCommandRepository.Insert(user);

            // Validar antes de commitear (integridad)
            await _unitOfWork.SaveChangesAsync();

            return new OperationResult()
            {
                Success = true
            };
        }
    }
}
