using AgencyCore.DATA;
using AgencyCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgencyCore.Controllers
{
    public class MusterilerController : Controller
    {
        public readonly ApplicationDbContext _db;
        public MusterilerController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            var listele = _db.Musterlers.ToList();

            return View(listele);
        }
        public IActionResult Create()
        {
            return View();

        }
        [HttpPost]
        public IActionResult Create(Musteriler musteriler)
        {
            _db.Add(musteriler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var yenile = _db.Musterlers.Find();
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Musteriler musteriler)
        {
            _db.Update(musteriler);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var del = _db.Musterlers.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Musterlers.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
