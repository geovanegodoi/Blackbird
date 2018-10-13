using System;
using Blackbird.Application.Services;
using Blackbird.Application.TO;

namespace Blackbird.WebUI.Controllers
{
    public class ProductController 
        : CrudControllerBase<IProductService, Guid, ProductTO>, ICrudController<Guid, ProductTO>
    {
        public ProductController(IProductService service) 
            : base(service)
        {

        }
    }
}
