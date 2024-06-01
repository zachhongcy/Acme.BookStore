using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public interface IBookAppService : IApplicationService
    {
        Task<string> GetAsync();
    }
}
