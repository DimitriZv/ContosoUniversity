using ContosoUniversity.Models;
using ContosoUniversity.ViewModels;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Pages.Courses
{
    public class IndexModel : PageModel
    {
        private readonly ContosoUniversity.Data.SchoolContext _context;

        public IndexModel(ContosoUniversity.Data.SchoolContext context)
        {
            _context = context;
        }

        //public IList<Course> Courses { get; set; }
        public IList<CourseViewModel> CourseVM { get; set; }

        public async Task OnGetAsync()
        {

            CourseVM = await _context.Courses
            .Select(p => new CourseViewModel
               {
                   CourseID = p.CourseID,
                   Title = p.Title,
                   Credits = p.Credits,
                    DepartmentName = p.Department.Name
                }).ToListAsync();

            /*Courses = await _context.Courses
                .Include(c => c.Department)
                .AsNoTracking() //improves performance because the entities returned are not tracked. The entities don't need to be tracked because they're not updated in the current context.
                .ToListAsync();*/
        }
    }
}