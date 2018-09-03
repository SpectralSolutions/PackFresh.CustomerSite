using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PackFresh.CustomerSite.Models;
using System.Net.Mail;

namespace PackFresh.CustomerSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {

            return View();
        }

        public IActionResult Product()
        {

            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }


        [HttpPost]
        public IActionResult Contact(Contact model)
        {

            try
            {
                Contact contact = new ContactViewModelFactory().generateContactFromCreateContactViewModel(model);

                MailMessage msz = new MailMessage();
                msz.From = new MailAddress(contact.Email); 

                msz.To.Add("silwal.anurag@gmail.com"); //Where mail will be sent (Pack Fresh Customer Team)
                msz.Subject = contact.Subject;
                msz.Body = "From: " + contact.Name + " Company: " + contact.Company + "Phone: " + contact.Phone + " Message: " + contact.Message;
                SmtpClient smtp = new SmtpClient();

                smtp.Host = "smtp.gmail.com";

                smtp.Port = 587;

                smtp.Credentials = new System.Net.NetworkCredential
                ("teamauk124@gmail.com", "CPPTeam124");

                smtp.EnableSsl = true;

                smtp.Send(msz);

                ModelState.Clear();
                ViewBag.Message = "Thank you for Contacting us ";
            }
            catch (Exception ex)
            {
                ModelState.Clear();
                ViewBag.Message = $" Sorry we are facing Problem here {ex.Message}";
            }


            return RedirectToAction("Index");
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
