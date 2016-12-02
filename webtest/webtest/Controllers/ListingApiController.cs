using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webtest.Controllers
{
    [RoutePrefix("api/listing")]
    public class ListingApiController : ApiController
    {
        private Dictionary<int, List<ListingItem>> Lists = new Dictionary<int, List<ListingItem>>();

        public ListingApiController() : base()
        {
            PopulateLists();
        }

        [HttpGet]
        [Route("list/{id}")]
        public IHttpActionResult GetList(int id)
        {
            return Ok(Lists[id]);
        }

        #region List Seeding
        private void PopulateLists()
        {
            var List1 = new List<ListingItem>();
            List1.Add(new ListingItem()
            {
                Id = 1,
                Name = "Item1 List1",
                Active = true
            });
            List1.Add(new ListingItem()
            {
                Id = 2,
                Name = "Item2 List1",
                Active = true
            });
            List1.Add(new ListingItem()
            {
                Id = 3,
                Name = "Item3 List1",
                Active = true
            });
            List1.Add(new ListingItem()
            {
                Id = 4,
                Name = "Item4 List1",
                Active = true
            });

            var List2 = new List<ListingItem>();
            List2.Add(new ListingItem()
            {
                Id = 5,
                Name = "Item1 List2",
                Active = true
            });
            List2.Add(new ListingItem()
            {
                Id = 6,
                Name = "Item2 List2",
                Active = true
            });
            List2.Add(new ListingItem()
            {
                Id = 7,
                Name = "Item3 List2",
                Active = false
            });
            List2.Add(new ListingItem()
            {
                Id = 8,
                Name = "Item4 List2",
                Active = true
            });

            var List3 = new List<ListingItem>();

            Lists.Add(1, List1);
            Lists.Add(2, List2);
            Lists.Add(3, List3);
        }
        #endregion
    }

    public class ListingItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
    }
}
