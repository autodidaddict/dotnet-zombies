using System;

namespace SampleMicroservice 
{
	public interface IGlobalCounter 
	{
		int Count { get; }
		void Increment();
	}
	
	public class GlobalCounter : IGlobalCounter
	{
		private int count;
		
		public GlobalCounter() {
			count = 0;
		}
		
		public int Count {
			get {
				return count;
			}
		}
		
		public void Increment() {
			count += 1;
		}
		
	}
}