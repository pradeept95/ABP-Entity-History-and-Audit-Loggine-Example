using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Domain.Repositories;
using Abp.EntityHistory;
using Abp.Extensions;
using Abp.IdentityFramework;
using Abp.Linq.Extensions;
using AuditDemo.AuditTest.Dto;
using AuditDemo.Authorization;
using AuditDemo.Authorization.Roles;
using AuditDemo.Authorization.Users;
using AuditDemo.Models;
using AuditDemo.Roles.Dto;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AuditDemo.AuditTest
{
   // [AbpAuthorize(PermissionNames.Pages_Roles)]
    public class AuditTestAppService : AsyncCrudAppService<AuditTestModel, MyAuditTestDto, Guid, PagedResultRequestDto, MyAuditTestDto, MyAuditTestDto>, IAuditTestAppService
    {
        private readonly IRepository<AuditTestModel, Guid> _repository;
        private readonly IEntityChangeSetReasonProvider _reasonProvider;

        public AuditTestAppService(IRepository<AuditTestModel, Guid> repository, IEntityChangeSetReasonProvider reasonProvider)
            : base(repository)
        {
            _repository = repository;
            _reasonProvider = reasonProvider;
        }


        [UseCase(Description = "New Audit test is created by user ")]
        public override Task<MyAuditTestDto> Create(MyAuditTestDto input)
        {
            return base.Create(input);
        }

        [UseCase(Description = "Test Audit is updated by user ")]
        public override Task<MyAuditTestDto> Update(MyAuditTestDto input)
        {
            return base.Update(input);
        }

        [UseCase(Description = "Test Audit is Deleted by user ")]
        public override Task Delete(EntityDto<Guid> input)
        {
            return base.Delete(input);
        }


        public virtual async Task DoSomething(MyAuditTestDto input)
        {
            var reason = "Using Reason Provider by User form DoSomething: " + AbpSession.UserId;
            using (_reasonProvider.Use(reason))
            {
                await base.Update(input);
                //await CurrentUnitOfWork.SaveChangesAsync();
            }

            reason = "Entity with same value is created from Do Something Method";
            using (_reasonProvider.Use(reason))
            {
                input.Id = new Guid();
                await base.Create(input); 
            }

            await CurrentUnitOfWork.SaveChangesAsync();
        }
    }
}

