using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

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
