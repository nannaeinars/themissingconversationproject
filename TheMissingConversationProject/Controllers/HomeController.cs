using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TheMissingConversationProject.Models;

namespace TheMissingConversationProject.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult History()
        {
            List<Conversation> conversations = ConversationRepository.GetConversations();

            return View(conversations);
        }

        [HttpPost]
        public JsonResult AddConversation(string pPerson1, string pPerson2)
        {
            try
            {
                if (pPerson1 == null || pPerson1.Trim() == "" || pPerson2 == null || pPerson2.Trim() == "")
                {
                    return Json(new { status = "error", message = "Please fill in both names." });
                }

                ConversationRepository.AddConversation(pPerson1, pPerson2);

                return Json(new { status = "success", message = "Conversation successfully added." });
            }
            catch (Exception ex)
            {
                return Json(new { status = "error", message = "Error occured adding conversation." });
            }
        }

        public ActionResult GetConversations()
        {
            try
            {
                List<Conversation> conversations = ConversationRepository.GetConversations();

                return Json(new { status = "ok", conv = conversations });
            }
            catch (Exception)
            {
                return Json(new { status = "error", message = "Something went wrong getting the conversations." });
            }
        }
    }
}