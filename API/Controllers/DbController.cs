﻿using API.Data;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DbController : ControllerBase
    {
        private readonly APIContext _context;

        public DbController(APIContext context)
        {
            _context = context;
        }

        [HttpGet("create")]
        public ActionResult Create()
        {
            return Ok(_context.Database.EnsureCreated());
        }

        [HttpGet("delete")]
        public ActionResult Delete()
        {
            return Ok(_context.Database.EnsureDeleted());
        }

        [HttpGet("fillcustomers")]
        public ActionResult FillCustomers()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.Customer.Add(new()
                {
                    name = "Customer " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Customers inserted.");
        }

        [HttpGet("fillEmployers")]
        public ActionResult FillEmployers()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.Employers.Add(new()
                {
                    name = "Employers " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("Employers inserted.");
        }

        [HttpGet("fillUser")]
        public ActionResult FillUser()
        {
            for (int i = 1; i < 100; i++)
            {
                _context.User.Add(new()
                {
                    name = "User " + i,
                    Age = i
                });
            }
            _context.SaveChanges();
            return Ok("User inserted.");
        }
    }
}