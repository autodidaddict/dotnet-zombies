using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace SampleMicroservice.Controllers
{		
	[Route("api/fail")]
	public class FailController
    {
        [HttpGet]
        public void Get()
        {
			Environment.FailFast("death");
        }    
    } 
}