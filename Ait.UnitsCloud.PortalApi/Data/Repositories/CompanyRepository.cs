using System;
using System.Linq;
using System.Linq.Expressions;
using Ait.UnitsCloud.PortalApi.Data;
using Ait.UnitsCloud.PortalApi.Data.Models;
using Ait.UnitsCloud.PortalApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;

namespace Ait.UnitsCloud.PortalApi.Data.Repositories
{
    public class CompanyRepository : GenericRepository<PortalContext, Company>, ICompanyRepository
    {
        public CompanyRepository(PortalContext ctx) : base(ctx)
        {
        }

    }
}