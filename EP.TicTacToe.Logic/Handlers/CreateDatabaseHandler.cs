﻿using System.Threading;
using System.Threading.Tasks;
using EP.TicTacToe.Data.Context;
using EP.TicTacToe.Logic.Commands;
using MediatR;

namespace EP.TicTacToe.Logic.Handlers
{
    public class CreateDatabaseHandler : AsyncRequestHandler<CreateDatabaseCommand>
    {
        private readonly TicTacDbContext _context;

        public CreateDatabaseHandler(TicTacDbContext context)
        {
            _context = context;
        }

        protected override async Task Handle(CreateDatabaseCommand request,
                                             CancellationToken cancellationToken)
        {
            await _context.Database.EnsureCreatedAsync(cancellationToken);
        }
    }
}