using Microsoft.AspNetCore.Mvc;
using RandomNameIDK.Models;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using RandomNameIDK.Data;

public class HomeController : Controller
{
    private readonly ApplicationDbContext _context;

    public HomeController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(UserForm userForm)
    {
        if (ModelState.IsValid)
        {
            _context.UserForms.Add(userForm);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        return View(userForm);
    }


}

