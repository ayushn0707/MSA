using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Prac4.Models;

namespace Prac4.Controllers;

public class HomeController : Controller
{
  public async Task <IActionResult>Index()
  {
    var model= new StockQuote{ Symbol="Nike", Price=3200};
    await Task.Delay(0);
    return View(model);
  }
}
