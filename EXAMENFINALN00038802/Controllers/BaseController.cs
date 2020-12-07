using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EXAMENFINALN00038802.Models;
using Microsoft.AspNetCore.Mvc;

namespace EXAMENFINALN00038802.Controllers
{
    public class BaseController : Controller
    {
        private readonly ExamenFinalContext context;
        public BaseController(ExamenFinalContext context)
        {
            this.context = context;
        }
        protected User LoggedUser()
        {
            var claim = HttpContext.User.Claims.FirstOrDefault();
            var user = context.Users.Where(o => o.Username == claim.Value).FirstOrDefault();
            return user;
        }
    }
}
