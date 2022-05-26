using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EF_Code.Models;

namespace EF_Code.Controllers
{
    public class YazarlarsController : Controller
    {
        private readonly KutuphaneAksamContext _context;
        public YazarlarsController(KutuphaneAksamContext context)
        {
            _context=context;
        }
        //GET-listeleme
        public IActionResult Index()
        {
            return View(_context.Yazarlars.ToList());//List tipinde değerler gönderiliyor
        }
        //GET-detay gösterme
        public IActionResult Details(int id)
        {
            var yazar = _context.Yazarlars.Find(id);
            return View(yazar);
        }
        //GET-düzeltme sayfası
        public IActionResult Edit(int id)
        {
            var yazar = _context.Yazarlars.Find(id);
            return View(yazar);
        }
        //POST-düzeltme işlemi
        [HttpPost]
        public IActionResult Edit(int id, Yazarlar yazar)
        {
            _context.Update(yazar);//Bu satır contexti güncelledi.
            _context.SaveChanges();//Bu satır databasei güncelledi.
            return RedirectToAction("Index");
            //return View(yazar);
        }
        public IActionResult Delete(int id)
        {
            var silinecekKitapTuru = _context.Yazarlars.Find(id);
            return View(silinecekKitapTuru);
        }
        [HttpPost,ActionName("DeleteConfirmed")]
        public IActionResult DeleteConfirmed(int id)
        {
            var silinecekKitapTuru = _context.Yazarlars.Find(id);
            _context.Yazarlars.Remove(silinecekKitapTuru);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Yazarlar yazar)
        {
            _context.Add(yazar);
            _context.SaveChanges();
            return RedirectToAction("Index");   
        }
    }
}