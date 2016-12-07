using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Steeltoe.Extensions.Configuration.CloudFoundry;

namespace SampleMicroservice.Controllers
{
    [Route("api/zombies")]
	public class ZombieController
	{
		private IZombieRepository repository;
		private IGlobalCounter counter;
		private ZombieOptions options;

		private CloudFoundryServicesOptions serviceOptions;
		private CloudFoundryApplicationOptions appOptions;
	
		public ZombieController(IZombieRepository zombieRepository,
								IGlobalCounter globalCounter,
								IOptions<ZombieOptions> zombieOptionsAccessor,
								IOptions<CloudFoundryApplicationOptions> appOptionsAccessor,
								IOptions<CloudFoundryServicesOptions> serviceOptionsAccessor) {
			repository = zombieRepository;
			counter = globalCounter;
			options = zombieOptionsAccessor.Value;
			appOptions = appOptionsAccessor.Value;
			serviceOptions = serviceOptionsAccessor.Value;

			DumpBoundServices();
		}

		[HttpGet]
    	public IEnumerable<Zombie> Get()
    	{
			counter.Increment();
			Console.WriteLine("count:" + counter.Count);
			Console.WriteLine("options:\n" +
				"\tAdvanced zombie tracking: " + options.EnableAdvancedZombieTracking +
				", zombie name: '" + options.ZombiesDescription + "', tag count: " + options.ZombieTags.Count);
        	return repository.ListAll();
    	}

		private void DumpBoundServices() {
			foreach (var svc in serviceOptions.Services) {
				Console.WriteLine(svc.Name + "/" + svc.Label);
				Console.WriteLine("\t" + svc.Credentials.ToString());
			}
		}
	}
}
