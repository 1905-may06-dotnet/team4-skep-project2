﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Domain;
namespace webapi.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly IRepo db;
        public ValuesController(IRepo db)
        {
            this.db = db;
        }

        //login 
        [HttpPost]
        public ActionResult LookUpUser([FromBody] string userID)
        {
            if (db.UsernameExist(userID))
            {
                return Accepted();

            }
            return Conflict();
        }
        public ActionResult CreateAccount ([FromBody]string userName, [FromBody]string password,[FromBody]string Email)
        {
            Domain.BGUser t = new Domain.BGUser(userName, password, Email);
            try
            {
                
                db.AddUser(t);
                Guid u = Guid.NewGuid();
                return Created(userName,u);
            }
            catch
            {
                return BadRequest();
            }

        }

            
            
            
        [HttpPost]
        public ActionResult UserLogin([FromBody] string userID,[FromBody]string password)
        {
            if (db.UsernameExist(userID))
            {
                if (db.PasswordMatched(userID, password))
                {
                    /// can't work on API need store locally TempData["UserID"] = userID;
                    /// 
                    Guid u = Guid.NewGuid();

                    return Accepted(u);
                }
                else
                {
                    return Unauthorized();
                }
            }
            return NotFound();
        }
        //Log Out
        [HttpGet]
        public ActionResult Get()
        {
            //fix link and remove cookie?
            return RedirectPermanent("/home");
        }
        
        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
