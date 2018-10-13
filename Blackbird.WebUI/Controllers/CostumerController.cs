using System;
using Blackbird.Application.Services;
using Blackbird.Application.TO;

namespace Blackbird.WebUI.Controllers
{
    public class CustomerController
        : CrudControllerBase<ICustomerService, Guid, CustomerTO>, ICrudController<Guid, CustomerTO>
    {
        public CustomerController(ICustomerService service) 
            : base(service)
        {

        }
    }
}
