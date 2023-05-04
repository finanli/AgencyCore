using AgencyCore.DATA;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using AgencyCore.Models;

namespace AgencyCore.Controllers
{
    public class CalisanlarController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CalisanlarController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var listele = _db.Calisanlars.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Calisanlar calisanlar)
        {
            _db.Add(calisanlar);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var yenile = _db.Calisanlars.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Calisanlar calisanlar)
        {
            _db.Update(calisanlar);
            _db.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult Delete(int id)
        {
            var del = _db.Calisanlars.Find(id);
            return View(del);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Calisanlars.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
