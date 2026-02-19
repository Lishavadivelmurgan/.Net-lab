using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Models;

namespace WebApplication1.Pages
{
    public class RegisterModel : PageModel
    {
        public Student student {  get; set; }   

        public string Message { get; set; }
        public void OnGet()
        {
        }

        public void OnPost() 
        {
            if (ModelState.IsValid)
            {
                Message = "Student Registered Successfully";
            }
        
        }
    }
}
