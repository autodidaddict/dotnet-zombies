using System.Collections.Generic;

namespace SampleMicroservice
{
	public interface IZombieRepository 
	{
		IEnumerable<Zombie> ListAll();
		void Add(Zombie zombie);
	}
	
	public class ZombieRepository : IZombieRepository
	{			
		public ZombieRepository() {
			 	
		}	
		
		public IEnumerable<Zombie> ListAll() {
			return new Zombie[] { new Zombie() { Name = "Bob", Age = 21},
								  new Zombie() { Name = "Alfred", Age = 52}
								 };
		}
		
		public void Add(Zombie zombie) {
			// this does nothing.
		}
	}
}