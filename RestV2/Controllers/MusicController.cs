using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PairProgramming;

namespace RestV2.Controllers
{
    
    public class MusicController : Controller
    {

        private static List<Music> musicList = new List<Music>()
        {
            new Music("Radio", "Rammstein", 4.40, 2019, "Universal", "New german Hard"),
            new Music("Kajsangen", "moppe", 10, 1970, "High", "Børnesang"),
            new Music("Bohemian Rhapsody", "Queen", 9.55, 1975, "Universal", "Rock"),
            new Music("DU ER DEN", "Monster", 0.45, 665, "Youtube", "sheismuel"),
            new Music("Hæng ud", "Curly Bois", 5.30, 1967, "Confederate", "country")
        };


        // GET: Music
        public ActionResult Index()
        {
            return View();
        }

        // GET: Music/Details/5
        public ActionResult Details(string id)
        {
            return View();
        }

        // GET: Music/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Music/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Music/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Music/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Music/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}