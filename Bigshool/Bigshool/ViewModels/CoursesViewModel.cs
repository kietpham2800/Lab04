
using Bigshool.Models;
using System.Collections.Generic;

namespace Bigshool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}