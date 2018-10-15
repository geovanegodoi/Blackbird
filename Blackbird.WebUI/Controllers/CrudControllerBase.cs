using System;
using System.Collections.Generic;
using Blackbird.Application.Services;
using Blackbird.Application.TO;
using Blackbird.Commom.ExtendedTypes;
using Blackbird.Commom.ServiceLocation;
using Microsoft.AspNetCore.Mvc;

namespace Blackbird.WebUI.Controllers
{
    public abstract class CrudControllerBase<TService, TKey, TDto> : Controller, ICrudController<TKey, TDto>
        where TService : ICrudAppService<TKey, TDto>
        where TDto : ITO
    {
        private readonly TService _service;

        protected TService DefaultService { get; private set; }

        protected CrudControllerBase(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index(int? pageIndex, int? pageSize)
        {
            var criteria = new PagingCriteria { PageIndex = pageIndex ?? 1, PageSize = pageSize ?? 5 };
            return View(_service.GetAll(criteria));
        }

        [HttpGet]
        public IActionResult Details(TKey id)
        {
            return View(_service.Get(id));
        }

        [HttpGet]
        public IActionResult Edit(TKey id)
        {
            return View(_service.Get(id));
        }

        [HttpPost]
        public IActionResult Edit(TKey id, TDto model)
        {
            _service.Update(id, model);
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(TDto model)
        {
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Delete(TKey id)
        {
            return View(_service.Get(id));
        }

        [HttpPost]
        public IActionResult DeleteConfirmed(TKey id)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
