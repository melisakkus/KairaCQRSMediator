﻿namespace KairaCQRSMediator.Features.CQRS.Commands.ServiceCommands
{
    public class RemoveServiceCommand
    {
        public int Id { get; set; }
        public RemoveServiceCommand(int id)
        {
            Id = id;
        }
    }
}
