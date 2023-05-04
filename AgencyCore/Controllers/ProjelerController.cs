using AgencyCore.DATA;
using AgencyCore.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace AgencyCore.Controllers
{
    public class ProjelerController : Controller
    {
        public readonly ApplicationDbContext _db;
        public ProjelerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var listele = _db.Projelers.ToList();
            return View(listele);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Projeler projeler)
        {
            _db.Add(projeler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            var yenile = _db.Projelers.Find(id);
            return View(yenile);
        }
        [HttpPost]
        public IActionResult Edit(int id, Projeler projeler)
        {
            
            _db.Update(projeler);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            var del = _db.Projelers.Find(id);
            return View(del);
        }
        [HttpPost,ActionName("Delete")]
        public IActionResult Sil(int id)
        {
            var del = _db.Projelers.Find(id);
            _db.Remove(del);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
