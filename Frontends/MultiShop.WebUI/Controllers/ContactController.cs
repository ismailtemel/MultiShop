﻿using Microsoft.AspNetCore.Mvc;
using MultiShop.DtoLayer.CatalogDtos.ContactDtos;

namespace MultiShop.WebUI.Controllers
{
    public class ContactController : Controller
    {
        //private readonly IContactService _contactService;

        public ContactController(/*IContactService*/ /*contactService*/)
        {
            // _contactService = contactService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.directory1 = "Multi Shop";
            ViewBag.directory2 = "İletişim";
            ViewBag.directory3 = "Mesaj Gönder";
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Index(CreateContactDto createContactDto)
        {
            createContactDto.IsRead = false;
            createContactDto.SendDate = DateTime.Now;
            //await _contactService.CreateContactAsync(createContactDto);
            return RedirectToAction("Index", "Default");
        }
    }
}
