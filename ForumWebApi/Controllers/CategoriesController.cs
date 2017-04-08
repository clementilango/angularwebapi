using ForumWebApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace ForumWebApi.Controllers
{
    //[Authorize]
    public class CategoriesController : ApiController
    {
        // GET api/values
        public List<Category> Get()
        {
            var Category = new List<Category>();
            return Category;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post(Category category)
        {
            return "Book record added successfully";
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
