using AgencyCore.DATA;
using AgencyCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgencyCore.Controllers
{
    public class HizmetlerController : Controller
    {
        public readonly ApplicationDbContext _db;
        public HizmetlerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Hizmetlers.ToList();
            return View(listele);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Hizmetler hizmetler)
        {
            _db.Add(hizmetler);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Edit(int id)
        {
            var yenile = _db.Hizmetlers.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Hizmetler hizmetler)
        {
            _db.Update(hizmetler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var del = _db.Hizmetlers.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Hizmetlers.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
