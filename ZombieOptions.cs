using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace SampleMicroservice
{
	public class ZombieTag {
		public String Name { get; set; }
		public int Weight { get; set; }
	}
	
	public class ZombieOptions
	{
		public String ZombiesDescription { get; set; }
		public int MaxZombieCount { get; set; }
		public bool EnableAdvancedZombieTracking { get; set; }
		public Collection<ZombieTag> ZombieTags { get; set; } 
	}
}