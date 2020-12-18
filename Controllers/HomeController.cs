using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SportsORM.Models;


namespace SportsORM.Controllers
{
    public class HomeController : Controller
    {

        private static Context _context;

        public HomeController(Context DBContext)
        {
            _context = DBContext;
        }

        [HttpGet("")]
        public IActionResult Index()
        {
            ViewBag.BaseballLeagues = _context.Leagues
                .Where(l => l.Sport.Contains("Baseball"))
                .ToList();
            return View();
        }

        [HttpGet("level_1")]
        public IActionResult Level1()
        {
            //#1
            ViewBag.Women = _context.Leagues.Where(i => i.Name.Contains("Women")).ToList();

            //#2
            ViewBag.Hockey = _context.Leagues.Where(i => i.Sport.Contains("Hockey")).ToList();

            //#3
            ViewBag.Football = _context.Leagues.Where(i => i.Sport!="Football").ToList();

            //#4
            ViewBag.Conference = _context.Leagues.Where(i => i.Name.Contains("Conference")).ToList();

            //#5
            ViewBag.Atlantic = _context.Leagues.Where(i => i.Name.Contains("Atlantic")).ToList();

            //#6
            ViewBag.Dallas = _context.Teams.Where(i=>i.Location.Contains("Dallas")).ToList();

            //#7
            ViewBag.Raptors = _context.Teams.Where(i => i.TeamName.Contains("Raptors")).ToList();

            //#8
            ViewBag.City = _context.Teams.Where(i => i.Location.Contains("City")).ToList();

            //#9
            ViewBag.T = _context.Teams.Where(i => i.TeamName.Contains("T")).ToList();

            //#10
            ViewBag.AlphaLocal = _context.Teams.OrderBy(i => i.Location).ToList();

            //#11
            ViewBag.AlphaNameReverse = _context.Teams.OrderByDescending(i => i.TeamName).ToList();

            //#12
            ViewBag.Cooper = _context.Players.Where(i => i.LastName.Contains("Cooper")).ToList();

            //#13
            ViewBag.Joshua = _context.Players.Where(i => i.FirstName.Contains("Joshua")).ToList();

            //#14
            ViewBag.CooperNoJoshua = _context.Players.Where(i => i.LastName.Contains("Cooper") && i.FirstName != "Joshua").ToList();

            //#15
            ViewBag.AlexOrWyatt = _context.Players.Where(i => i.FirstName.Contains("Alexander")|| i.FirstName.Contains("Wyatt")).ToList();

            return View();
        }

        [HttpGet("level_2")]
        public IActionResult Level2()
        {
            return View();
        }

        [HttpGet("level_3")]
        public IActionResult Level3()
        {
            return View();
        }

    }
}