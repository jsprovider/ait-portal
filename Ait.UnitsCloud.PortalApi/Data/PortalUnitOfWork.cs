using Ait.UnitsCloud.PortalApi.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Ait.UnitsCloud.PortalApi.Data
{
    public class PortalUnitOfWork : IPortalUnitOfWork
    {
        IOptions<PortalOptions> _portalOptions = null;
        PortalContext _portalContext = null;

        //CompanyRepository companyRepo = null;
        public PortalUnitOfWork(IOptions<PortalOptions> portalOptions)
        {
            _portalOptions = portalOptions;
            _portalContext = CreatePoralContext();
            //CreateRepos();
        }
        public CompanyRepository CompanyRepository
        {
            get => new CompanyRepository(_portalContext);
            //set => throw new System.NotImplementedException();
        }

        private PortalContext CreatePoralContext()
        {
            string connectionString =_portalOptions.Value.ConnectionString;
            var dbOptionBuilder = new DbContextOptionsBuilder<PortalContext>();
            return new PortalContext(dbOptionBuilder.UseSqlServer(connectionString).Options);
        }
        // private R CreateRepo<R>() where R:class ,new()
        // {
        //    var dbContext =  CreatePoralContext(_portalOptions.Value.ConnectionString);
        //    return new R();
        // }
    }
}