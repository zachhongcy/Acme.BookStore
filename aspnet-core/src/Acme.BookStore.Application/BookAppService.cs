using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp;
using Volo.Abp.Application.Services;

namespace Acme.BookStore
{
    public class BookAppService : ApplicationService, IBookAppService
    {
        public Task<string> GetAsync()
        {
            throw new UserFriendlyException("Unable to find book.");
        }
    }
}
