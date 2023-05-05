using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using StudentManagerSteps.Data;
using StudentManagerSteps.Model;

namespace StudentManagerSteps.Pages
{
    [Authorize(Roles ="User, Admin")]
    public class OrderModel : PageModel
    {
        private readonly AuthDbContext _db;
        public OrderModel(AuthDbContext db)
        {
            _db = db;
        }

        public IList<Pizza> Pizza { get; set; }

        public async Task OnGetAsync()
        {
            if (_db.Pizzas != null) 
            {
                Pizza = await _db.Pizzas.ToListAsync();
            }
        }
    }
}
