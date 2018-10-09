using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DataStructuresAssignment.Controllers
{
    public class StackController : Controller
    {
        // GET: Stack
        public static Stack<string> bob = new Stack<string>();

        public static int bobSize = 0;

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ShowStack()
        {
            ViewBag.Stack = bob;
            return View();
        }

        public ActionResult AddToStack()
        {
            bob.Push("Stack Item #" + (bobSize + 1));
            bobSize++;
            return RedirectToAction("Index");
        }

        public ActionResult AddHugeToStack()
        {
            for (int i = 0; i < 200; i++)
            {
                bob.Push("Stack Item #" + (bobSize + 1));
                bobSize++;
            }
            return RedirectToAction("Index");
        }

        public ActionResult DeleteFromStack()
        {
            bob.Pop();
            bobSize--;
            return View("Index");
        }

        public ActionResult ClearStack()
        {
            bob.Clear();
            bobSize = 0;
            return View("Index");
        }

        /*[HttpGet]
        public ActionResult SearchStack()
        {
            return View();
        }
        
        [HttpPost]*/
        public ActionResult SearchStack(/*string searchItem*/)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

            sw.Start();

            bool found = false;

            foreach (string str in bob)
            {
                if (str == /*searchItem*/"Stack Item #7")
                {
                    found = true;
                }
            }
            //loop to do all the work

            sw.Stop();

            if (found)
            {
                ViewBag.Found = /*searchItem + */"Stack Item #7 is in the stack!";
            }
            else
            {
                ViewBag.Found = /*searchItem + */"Stack Item #7 is not in the stack!";
            }

            TimeSpan ts = sw.Elapsed;

            ViewBag.StopWatch = ts;

            return View();
        }
    }
}