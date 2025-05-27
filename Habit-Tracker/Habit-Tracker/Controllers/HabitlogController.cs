using HabitTracker.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

public class HabitLogController : Controller
{
    private readonly AppDbContext _context;

    public HabitLogController(AppDbContext context)
    {
        _context = context;
    }

    public async Task<IActionResult> Index()
    {
        return View(await _context.HabitLogs.ToListAsync());
    }

    // Add Create, Edit, Delete, and Details actions as needed
}

