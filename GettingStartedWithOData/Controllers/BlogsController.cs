using GettingStartedWithOData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.OData;

namespace GettingStartedWithOData.Controllers
{
    public class BlogsController : EntitySetController<Blog, int>
    {
        List<Blog> _blogs = new List<Blog>()
        {
            new Blog() { Id = 1, Title = "OData 1", Post = 
                "Lorem ipsum dolor sit amet", Views = 100, Author="Suprotim" },
            new Blog() { Id = 2, Title = "OData 2", Post = 
                "Quisque tristique imperdiet justo", Views = 203, Author="LazyBlogger" },
            new Blog() { Id = 3, Title = "OData 3", Post = 
                "Nam luctus metus sed dolor pretium", Views = 33, Author="LazyBlogger" },
            new Blog() { Id = 4, Title = "OData 4", Post = 
                "Phasellus ac elit urna, non pulvinar tortor.", Views = 955, Author="LazyBlogger" },
            new Blog() { Id = 5, Title = "OData 5", Post = 
                "Curabitur rhoncus erat odio, ut venenatis tortor.",Views = 300, Author="Suprotim" },
        };

        // GET api/values
        public override IQueryable<Blog> Get()
        {
            return _blogs.AsQueryable();
        }

        // GET api/values/5
        protected override Blog GetEntityByKey(int id)
        {
            Blog entity = _blogs.Find(bl => bl.Id == id);
            return entity;
        }

        //// POST api/values
        //public void Post([FromODataUri]Blog value)
        //{
        //}

        //// PUT api/values/5
        //public void Put(int id, [FromODataUri]Blog value)
        //{
        //}

        //// DELETE api/values/5
        //public void Delete(int id)
        //{
        //}
    }
}