using System;
using System.Collections.Generic;
using Blackbird.Application.Services;
using Blackbird.Commom.IoC;
using Microsoft.AspNetCore.Mvc;

namespace Blackbird.WebUI.Controllers
{
    public interface ICrudController<TKey, TDto> : IControllerLifestyle
    {
        [HttpGet]
        IActionResult Index();

        [HttpGet]
        IActionResult Details(TKey id);

        [HttpGet]
        IActionResult Edit(TKey id);

        [HttpPost]
        IActionResult Edit(TKey id, TDto model);

        [HttpGet]
        IActionResult Create();

        [HttpPost]
        IActionResult Create(TDto model);

        [HttpGet]
        IActionResult Delete(TKey id);

        [HttpPost, ActionName("Delete")]
        IActionResult DeleteConfirmed(TKey id);
    }
}
