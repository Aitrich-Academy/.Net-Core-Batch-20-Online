using Microsoft.AspNetCore.Mvc.Rendering;

namespace LibrarySystem.Model
{
    public class RoleSelectionViewModel
    {
        public string SelectedRole { get; set; }
        public List<SelectListItem> Roles { get; set; }
    }
}
