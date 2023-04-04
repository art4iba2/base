using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using WebApplication7.Models;

public class SkiResortController : Controller
{
    private static List<SkiResortModel> skiResorts = new List<SkiResortModel>()
    {
        new SkiResortModel { Id = 1, Name = "Роза Хутор", City = "Сочи", OpenDate = new DateTime(2011, 11, 24), NumberOfSkiSlopes = 102, AverageSlopeLength = 1350, AnnualRevenue = 2100000000 },
        new SkiResortModel { Id = 2, Name = "Гора Аибга", City = "Красная поляна", OpenDate = new DateTime(2014, 1, 4), NumberOfSkiSlopes = 75, AverageSlopeLength = 1590, AnnualRevenue = 1700000000 },
        new SkiResortModel { Id = 3, Name = "Эльбрус", City = "Терек", OpenDate = new DateTime(1958, 12, 28), NumberOfSkiSlopes = 11, AverageSlopeLength = 4400, AnnualRevenue = 600000000 }
    };

    private void AddSkiResortToList(SkiResortModel skiResort)
    {
        skiResort.Id = skiResorts.Count + 1;
        skiResorts.Add(skiResort);
    }


    public ActionResult Index()
    {
        return View(skiResorts.ToList());
    }

    [HttpGet]
    public ActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public ActionResult Create(SkiResortModel skiResort)
    {
        if (ModelState.IsValid)
        {
            AddSkiResortToList(skiResort);
            return RedirectToAction("Index");
        }
        return View(skiResort);
    }

}

