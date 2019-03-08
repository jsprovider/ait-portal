using Ait.UnitsCloud.PortalApi.Data;
using Ait.UnitsCloud.PortalApi.Data.Repositories;

namespace Ait.UnitsCloud.PortalApi.Data
{
    public interface IPortalUnitOfWork
    {
        CompanyRepository CompanyRepository { get;}
    }
}