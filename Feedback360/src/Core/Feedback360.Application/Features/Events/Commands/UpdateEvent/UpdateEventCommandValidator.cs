﻿using FluentValidation;
using Feedback360.Application.Contracts.Persistence;
using Feedback360.Application.Helper;

namespace Feedback360.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandValidator : AbstractValidator<UpdateEventCommand>
    {
        private readonly IMessageRepository _messageRepository;
        public UpdateEventCommandValidator(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage(GetMessage("1", ApplicationConstants.LANG_ENG))
                .NotNull()
                .MaximumLength(50).WithMessage(GetMessage("2", ApplicationConstants.LANG_ENG));

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage(GetMessage("1", ApplicationConstants.LANG_ENG))
                .GreaterThan(0);
        }

        private string GetMessage(string Code, string Lang)
        {
            return _messageRepository.GetMessage(Code, Lang).Result.MessageContent.ToString();
        }
    }
}
