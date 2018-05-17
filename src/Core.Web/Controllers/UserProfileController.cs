using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Core.Business;

namespace Core.Web.Controllers
{
    public class UserProfileController : Controller
    {
        private IUserProfileBusiness _userprofileBusiness;
        public UserProfileController(IUserProfileBusiness userprofileBusiness)
        {
            _userprofileBusiness = userprofileBusiness;
        }
        public IActionResult Index()
        {
            var response = _userprofileBusiness.GetUserProfiles().ToList();
            return View(response);
        }
    }
}