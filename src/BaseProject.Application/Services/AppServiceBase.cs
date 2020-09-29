using AutoMapper;
using BaseProject.Application.Interfaces;
using BaseProject.Application.Validation;
using BaseProject.Infra.Data.Interfaces;
using FluentValidation.Results;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace BaseProject.Application.Services
{
    public class AppServiceBase<TContext> : IAppServiceBase<TContext> where TContext : IDbContext
    {
        protected readonly IServiceProvider _serviceProvider;
        protected readonly IMapper _mapper;
        private readonly IUnitOfWork<TContext> _uow;

        public AppServiceBase(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
            _uow = _serviceProvider.GetService<IUnitOfWork<TContext>>();
            _mapper = _serviceProvider.GetService<IMapper>();
        }

        public void BeginTransaction()
        {
            _uow.BeginTransaction();
        }

        public void Commit()
        {
            _uow.SaveChanges();
        }

        protected ValidationAppResult DomainToApplicationResult(ValidationResult validationResult)
        {
            var validationAppResult = new ValidationAppResult();

            foreach (var validationError in validationResult.Errors)
                validationAppResult.Erros.Add(new ValidationAppError(validationError.ErrorMessage));

            validationAppResult.IsValid = validationResult.IsValid;

            return validationAppResult;
        }
    }
}
