using DataAccess;
using DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace LanguagesRestApi.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class RegistrationController : ApiController
    {
        public IHttpActionResult Post(Student student)
        {
            using (var context = new LanguagesContext())
            {
                context.Students.Add(student);
                context.SaveChanges();
                return Ok();
            }
        }
    }
}