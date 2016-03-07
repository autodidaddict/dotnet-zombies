using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.OptionsModel;

namespace SampleMicroservice.Controllers
{		
	[Route("api/zombies")]
	public class ZombieController 
	{
		private IZombieRepository repository;
		private IGlobalCounter counter;
		private ZombieOptions options;
		
		public ZombieController(IZombieRepository zombieRepository, 
								IGlobalCounter globalCounter,
								IOptions<ZombieOptions> zombieOptionsAccessor) {
			repository = zombieRepository;	
			counter = globalCounter;
			options = zombieOptionsAccessor.Value;
		}		
		
		[HttpGet]
        public IEnumerable<Zombie> Get()
        {
			counter.Increment();
			Console.WriteLine("count: " + counter.Count + 
				", advanced zombie tracking: " + options.EnableAdvancedZombieTracking + 
				", zombie name: '" + options.ZombiesDescription + "', tag count: " + options.ZombieTags.Count);			
            return repository.ListAll();
        }                
	}
}
	