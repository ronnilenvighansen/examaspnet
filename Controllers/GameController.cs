using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ExamAspDotNet.Models;
using ExamAspDotNet.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Runtime.Serialization;

namespace ExamAspDotNet.Controllers
{
    public class GameController : Controller
    {

     GameDbContext db = new GameDbContext();

        public IActionResult Index()
        {
            ViewBag.stud = db.Games;       
            return View();
        }

        public IActionResult Search(int id = 1)
        {
            ViewBag.number = id;

            ViewBag.stud = db.Games.ToList();

            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Game gm)
        {
            db.Games.Add(gm);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Delete()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            Game gm = new Game(){GameId = id};
            db.Games.Remove(gm);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public IActionResult Edit()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Edit(Game gm)
        {
            db.Update(gm);
            db.SaveChanges();
            return View();
        }
    }   
}

   