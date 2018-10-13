using System;
using Blackbird.Application.Services;
using Blackbird.Application.TO;

namespace Blackbird.WebUI.Controllers
{
    public class PersonController 
        : CrudControllerBase<IPersonService, Guid, PersonTO>, ICrudController<Guid, PersonTO>
    {
        public PersonController(IPersonService service) 
            : base(service)
        {

        }
    }
}
