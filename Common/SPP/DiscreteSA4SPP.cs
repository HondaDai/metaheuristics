using System;

namespace Metaheuristics
{
	public class DiscreteSA4SPP : DiscreteSA
	{
		public SPPInstance Instance { get; protected set; }
		
		public DiscreteSA4SPP(SPPInstance instance)
			: base(instance.NumberSubsets - 1, 0.95)
		{
			Instance = instance;
		}
		
		protected override double Fitness(int[] solution)
		{
			return SPPUtils.Fitness(Instance, solution);
		}
		
		protected override int[] InitialSolution()
		{
			return SPPUtils.RandomSolution(Instance);
		}
		
		protected override int[] GetNeighbor(int[] solution)
		{
			return SPPUtils.GetNeighbor(Instance, solution);
		}
	}
}