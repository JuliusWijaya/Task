using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BiodataCRUD.Controllers
{
    public class HomeController : Controller
    {
        BIODATADBContext _context = new BIODATADBContext();
        public ActionResult Index()
        {
            var listOfData = _context.BIODATAs.ToList();

            return View(listOfData);
        }

        [HttpGet]
        public ActionResult Create()
        {   

            return View();
        }
        [HttpPost]
        public ActionResult Create(BIODATA model)
        {
            _context.BIODATAs.Add(model);
            _context.SaveChanges();
            ViewBag.Message = "Data berhasil ditambahkan";
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var data = _context.BIODATAs.Where(x => x.id == id).FirstOrDefault();

            return View(data);
        }


        [HttpPost]
        public ActionResult Edit(BIODATA Model)
        {
            var data = _context.BIODATAs.Where(x => x.id == Model.id).FirstOrDefault();
            if(data != null)
            {
                data.name = Model.name;
                data.gender = Model.gender;
                data.birth = Model.birth;
                data.hometown = Model.hometown;
                _context.SaveChanges();
            }

            return RedirectToAction("Index");
        }

        public ActionResult Detail(int id)
        {
            var data = _context.BIODATAs.Where(x => x.id == id).FirstOrDefault();

            return View(data);
        }

        public ActionResult Delete(int id)
        {
            var data = _context.BIODATAs.Where(x => x.id == id).FirstOrDefault();

            _context.BIODATAs.Remove(data);
            _context.SaveChanges();
            ViewBag.Message = "Data berhasil dihapus!";
            return RedirectToAction("Index");
        }
    }
}