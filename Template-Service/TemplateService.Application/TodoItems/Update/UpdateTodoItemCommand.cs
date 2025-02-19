﻿using VH.MiniService.Common.Application.Abstractions;
using FluentResults;
using MediatR;
using TemplateService.Data.Domain.Entities;

namespace TemplateService.Application.TodoItems.Update
{
    public class UpdateTodoItemCommand : TodoItem, IRequest<Result>, IRequireUser { }
}
