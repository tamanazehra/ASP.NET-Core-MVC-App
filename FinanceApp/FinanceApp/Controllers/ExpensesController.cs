using FinanceApp.Data;
using FinanceApp.Data.Service;
using FinanceApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace FinanceApp.Controllers
{
    public class ExpensesController : Controller
    {
        private readonly IExpensesService _expensesServices;
        public ExpensesController(IExpensesService expensesServices)
        {
            _expensesServices = expensesServices;
        }
        public async Task<IActionResult> Index()
        {
            var expenses = await _expensesServices.GetAll();
            return View(expenses);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(Expense expense)
        {
            if (ModelState.IsValid) 
            { 
               await _expensesServices.Add(expense);
                return RedirectToAction("Index");
            }
            return View(expense);
        }
    }
}
