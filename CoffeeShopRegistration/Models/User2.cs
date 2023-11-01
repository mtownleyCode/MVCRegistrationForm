using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;


namespace CoffeeShopRegistration.Models
{
    public class User2 : Controller
    {
        [BindProperty]
        [Required(ErrorMessage ="The first name is required.")]
        public string? FirstName { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage = "The last name is required.")]
        public string? LastName { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage = "The email is required.")]
        public string? Email { get; set; }
        
        [BindProperty]
        [Required(ErrorMessage = "The password is required.")]
        public string? Password { get; set; }

        public string success = "";
        public string error = "";

        public void OnPost()
        {
            if (ModelState.IsValid)
            {
                success = "You have been added. Thank you for signing up.";

            }
            else
            {
                error = "Data validation failed.";
            }
        }

    }
    
}
