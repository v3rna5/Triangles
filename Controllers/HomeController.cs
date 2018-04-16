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
         string side1=Request.Query["length"];
         string side2=Request.Query["width"];
         string side3=Request.Query["height"];

         int num2;
         bool validSide1=int.TryParse(side1, out num2);
         bool validSide2=int.TryParse(side2, out num2);
         bool validSide3=int.TryParse(side3, out num2);
         if (validSide1==true && validSide2==true && validSide3==true)
         {
              TrianglesVariable myTrianglesVariable = new TrianglesVariable();
              myTrianglesVariable.SetSideOne(Request.Query["length"]);
              myTrianglesVariable.SetSideTwo(Request.Query["width"]);
              myTrianglesVariable.SetSideThree(Request.Query["height"]);
              return View("Results", myTrianglesVariable);
         }
         else {
           Console.WriteLine("SORRY THIS DOESNT WORK");
           return View("Form");
         }
       }
    }
}
