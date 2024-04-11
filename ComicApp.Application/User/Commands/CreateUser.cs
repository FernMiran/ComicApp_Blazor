using ComicApp.Application.Common;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ComicApp.Application.User.Commands
{
    public class CreateUser : IRequest<OperationResult>
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
