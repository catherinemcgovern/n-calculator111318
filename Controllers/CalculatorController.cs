using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyWebCalculator.Models;
using MathLibrary;

namespace MyWebCalculator.Controllers
{
    public class CalculatorController : Controller
    {

        public IActionResult Add(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["AddResult"] = $"{left} plus {right} is: {MyMathRoutines.Add(left, right)}";
            return View();
        }
   
    

        public IActionResult Subtract(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["SubtractResult"] = $"{left} minus {right} is: {MyMathRoutines.Subtract(left, right)}";
            return View();
        }

        public IActionResult Multiply(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["MultiplyResult"] = $"{left} times {right} is: {MyMathRoutines.Multiply(left, right)}";
            return View();
        }


        public IActionResult Divide(decimal left, decimal right)
        {
            ViewData["Left"] = left;
            ViewData["Right"] = right;
            ViewData["DivideResult"] = $"{left} divide {right} is: {MyMathRoutines.Divide(left, right)}";
            return View();
        }

        public IActionResult Ceiling(decimal number)
        {
            ViewData["Number"] = number;
            ViewData["CeilingResult"] = $"The floor of {number} is {MyMathRoutines.Ceiling(number)}";
            return View();
        }


        public IActionResult Floor(decimal number)
        {
            ViewData["Number"] = number;
            ViewData["FloorResult"] = $"The floor of {number} is {MyMathRoutines.Floor(number)}";
            return View();
        }

    //    public string Ceiling(decimal number)
    //    {
    //        return $"The ceiling of {number} is {MyMathRoutines.Ceiling(number)}";
     //   }   
    }
}
