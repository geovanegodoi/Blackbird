using System;
using System.Collections.Generic;
using Blackbird.Application.Services;
using Blackbird.Application.TO;
using Microsoft.AspNetCore.Mvc;

namespace Blackbird.Presentation.Controllers
{
    public abstract class CrudControllerBase<TService, TKey, TDto> : Controller, ICrudController<TKey, TDto>
        where TService : ICrudAppService<TKey, TDto>
        where TDto : ITO
    {
        private readonly TService _service;

        protected CrudControllerBase(TService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_service.GetAll());
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
