using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Shop.Models;

namespace Shop.Controllers
{
    [Authorize(Users = "Administrator")]
    public class StoreManagerController : Controller
    {
        private ShopEntities db = new ShopEntities();

        // GET: StoreManager
        public ActionResult Index()
        {
            var clothes = db.Clothes.Include(a => a.Category);
            return View(clothes.ToList());
        }

        // GET: StoreManager/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Clothing clothing = db.Clothes.Find(id);
            if (clothing == null)
            {
                return HttpNotFound();
            }
            return View(clothing);
        }

        // GET: StoreManager/Create
        public ActionResult Create()
        {
            ViewBag.ID_category = new SelectList(db.Categories, "ID_category", "Name");
            return View();
        }

        // POST: StoreManager/Create
        [HttpPost]
        public ActionResult Create(Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                db.Clothes.Add(clothing);
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_category = new SelectList(db.Categories, "ID_category", "Name", clothing.ID_category);
            return View(clothing);
        }

        // GET: StoreManager/Edit/5
        public ActionResult Edit(int id)
        {
            Clothing clothing = db.Clothes.Find(id);
            ViewBag.ID_category = new SelectList(db.Categories, "ID_category", "Name", clothing.ID_category);
            return View(clothing);
        }

        //
        // POST: /StoreManager/Edit/5
        [HttpPost]
        public ActionResult Edit(Clothing clothing)
        {
            if (ModelState.IsValid)
            {
                db.Entry(clothing).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ID_category = new SelectList(db.Categories, "ID_category", "Name", clothing.ID_category);
            return View(clothing);
        }

        // GET: StoreManager/Delete/5
        public ActionResult Delete(int id)
        {
            Clothing clothing = db.Clothes.Find(id);
            return View(clothing);
        }

        // POST: StoreManager/Delete/5
        [ValidateAntiForgeryToken]
        [HttpPost, ActionName("Delete")]        
        public ActionResult DeleteConfirmed(int id)
        {            
            Clothing clothing = db.Clothes.Find(id);
            db.Clothes.Remove(clothing);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}
