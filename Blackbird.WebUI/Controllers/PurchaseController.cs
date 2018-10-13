using System;
using Blackbird.Application.Services;
using Blackbird.Application.TO;

namespace Blackbird.WebUI.Controllers
{
    public class PurchaseController 
        : CrudControllerBase<IPurchaseService, Guid, PurchaseTO>, ICrudController<Guid, PurchaseTO>
    {
        public PurchaseController(IPurchaseService service) 
            : base(service)
        {

        }
    }
}
