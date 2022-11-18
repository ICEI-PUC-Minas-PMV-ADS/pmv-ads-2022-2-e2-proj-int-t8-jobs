using Jobs.Areas.Identity.Data;
using Jobs.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace Jobs.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public UserController(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult ProfileUpdate()
        {
            var user = _userManager.Users.First(x => x.Email == User.Identity.Name);
            return View(new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.PhoneNumber,
                UserBio = user.UserBio,
                AddressLine = user.AddressLine,
                AdditionalAddress = user.AdditionalAddress,
                ZipCode = user.ZipCode,
                City = user.City,
                Estate = user.Estate,
                AreaCode = user.AreaCode
            });
        }

        [HttpPost]
        public async Task<IActionResult> ProfileUpdate(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.Users.First(x => x.Email == User.Identity.Name);
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Email = model.Email;
                user.NormalizedEmail = model.Email.ToUpper();
                user.UserName = model.Email;
                user.NormalizedUserName = model.Email.ToUpper();
                user.PhoneNumber = model.Phone;
                user.UserBio = model.UserBio;
                user.AddressLine = model.AddressLine;
                user.AdditionalAddress = model.AdditionalAddress;
                user.ZipCode = model.ZipCode;
                user.City = model.City;
                user.Estate = model.Estate;
                user.AreaCode = model.AreaCode;

                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    ViewData["message"] = "Sucesso";
                }
                else
                {
                    ViewData["message"] = "Erro";
                }
            }
            return RedirectToAction(nameof (Profile));
        }
        [HttpGet]
        public IActionResult Profile()
        {
            var user = _userManager.Users.First(x => x.Email == User.Identity.Name);
            return View(new UserViewModel
            {
                Id = user.Id,
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Phone = user.PhoneNumber,
                UserBio = user.UserBio,
                AddressLine = user.AddressLine,
                AdditionalAddress = user.AdditionalAddress,
                ZipCode = user.ZipCode,
                City = user.City,
                Estate = user.Estate,
                AreaCode = user.AreaCode
            });
        }
    }
}
