using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api_rest_run.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class friendController : ControllerBase
    {
        // GET: api/Friend
        [HttpGet]
        public List<Friend> GetAll()
        {
            List<Friend> friends = new List<Friend>();
            friends.Add(new Friend("Kindson", "Munonye", "Budapest", DateTime.Today));
            friends.Add(new Friend("Oleander", "Yuba", "Nigeria", DateTime.Today));
            friends.Add(new Friend("Saffron", "Lawrence", "Lagos", DateTime.Today));
            friends.Add(new Friend("Jadon", "Munonye", "Asaba", DateTime.Today));
            friends.Add(new Friend("Solace", "Okeke", "Oko", DateTime.Today));

            return friends;
        }
    }
}
