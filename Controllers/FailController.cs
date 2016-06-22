using System;
using Microsoft.AspNetCore.Mvc;

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
