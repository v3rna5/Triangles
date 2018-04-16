using Microsoft.AspNetCore.Mvc;
using Triangles.Models;
using System;

namespace Triangles.Controllers
{
    public class HomeController : Controller
    {
      [Route("/")]
      public ActionResult Form()
      {
        return View();
      }

      [Route("/onSubmit")]
       public ActionResult OnSubmit()
       {
            TrianglesVariable myTrianglesVariable = new TrianglesVariable();
            myTrianglesVariable.SetSideOne(Request.Query["length"]);
            myTrianglesVariable.SetSideTwo(Request.Query["width"]);
            myTrianglesVariable.SetSideThree(Request.Query["height"]);
            return View("Results", myTrianglesVariable);
       }
    }
}
