﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CodeFest1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        

        // GET api/values/5
        [HttpGet("{celsius}")]
        public ActionResult<string> Get(double celsius)
        {
            double f;  
            f = celsius * 9 / 5 + 32;  
            return (celsius + "°C in Farenheit is: " + f + "°F");  
        }

        
    }
}
