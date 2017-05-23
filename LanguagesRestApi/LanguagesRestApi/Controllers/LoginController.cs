using DataAccess;
using LanguagesRestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LanguagesRestApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class LoginController : ApiController
    {
        public IHttpActionResult Post(LoginModel model)
        {
            if (model != null && ModelState.IsValid)
            {
                using (var context = new LanguagesContext())
                {
                    var user = context.Students.SingleOrDefault(s => s.KorisnickoIme == model.Username && s.Sifra == model.Password);
                    if (user != null)
                    {
                        return Json(new {isSuccess = true, userType = "UCENIK", username= user.KorisnickoIme});
                    }
                    else
                    {
                        return Content(System.Net.HttpStatusCode.BadRequest, new { message = "Korisničko ime ili šifra nisu ispravni." });
                    }
                }
            }

            return Content(System.Net.HttpStatusCode.BadRequest, new { message = "Došlo je do greške prilikom logovanja." });
        }
    }
}
