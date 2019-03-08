// using System;
// using System.Collections.Generic;
// using System.Linq;
// using System.Net;
// using System.Net.Http;
// using System.Web.Http;
// using Ait.UnitsCloud.PortalApi.Data;
// using Ait.UnitsCloud.PortalApi.Data.Models;
// using Ait.UnitsCloud.PortalApi.ViewModel;
// using Microsoft.AspNetCore.Mvc;

// namespace ActiveCrm.PortalApi.Controllers
// {
//     [Route("api/company")]
//     [ApiController]
//     public class CompanyController : ControllerBase
//     {
//         IPortalUnitOfWork _portalUnitOfWork = null;
//         public CompanyController(IPortalUnitOfWork  unitOfWork)
//         {
//             _portalUnitOfWork = unitOfWork;
//         }

//         [Route("v1/summary")]
//         public ActionResult  GetCompaniesList()
//         {
//             try
//             {
//                 List<CompanyInfo> cvmList = new List<CompanyInfo>();
                
//                 cvmList = _portalUnitOfWork.CompanyRepository.GetAll().Select(r => new CompanyInfo
//                 {
//                     Id = r.Id,
//                     Number = r.Number,
//                     Code = r.Code,
//                     Name1 = r.Name1,
//                     Name2 = r.Name1,
//                     StatusId = r.CompanyStatusId
//                 }).ToList();

//                 foreach (var company in cvmList)
//                 {
//                     company.GatewayList = GetGatewaysListByCompanyId(company.Id);
//                 }

//                 return Ok(cvmList);
//             }
//             catch (Exception ex)
//             {

//                 return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
//             }
            
//         }

//         [Route("{companyId}/v1/details")]
//         public List<ServersGateway> GetGatewaysListByCompanyId(int companyId)
//         {
//             List<ServersGateway> sgvmList = new List<ServersGateway>();
//             var ctx = new PortalDbContext();
//             var serversGatewayList = ctx.gateways.Where(r => r.company_id == companyId).Select(r=> new ServersGateway {
//                 CompanyId = r.company_id  ,
//                 GatewayId=r.id ,
//                 GatewayDescription=r.description,
//                 GatewayIpAddress=r.ip_address,
//             }).ToList();

//             return (serversGatewayList);
//          }

//         [Route("v2/summary")]
//         public IHttpActionResult GetCompanyPageList(ODataQueryOptions<Company> options)
//         {
//             try
//             {
//                var ctx = new PortalDbContext();
//                var  companyList = ctx.companies.Select(r => new Company
//                {
//                     Id = r.id,
//                     Number = r.number,
//                     Code = r.code,
//                     Name1 = r.name_1,
//                     Name2 = r.name_2,
//                     StatusId = r.company_status_id
//                 });

//                 ODataQuerySettings settings = new ODataQuerySettings()
//                 {
//                     PageSize = Constants.PageSize 
//                 };
                
//                 var pageResult = options.ApplyTo(companyList, settings);
//                 IEnumerable<Company> returnList = pageResult as IEnumerable<Company>;
//                 return Ok(new PageResult<Company>(returnList, Request.ODataProperties().NextLink, Request.ODataProperties().TotalCount));
//             }
//             catch (Exception ex)
//             {

//                 return ResponseMessage(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message));
//             }

//         }

//     }
//     }
