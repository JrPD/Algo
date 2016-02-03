using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
	class Program
	{
		public static int BinarySearch(int[] values, int key)
		{
			int l0 = 0;
			int hi = values.Length - 1;

			while (l0<=hi)
			{
				var mid = (l0+hi)/2;
				if (key < values[mid])
					hi = mid-1;
				else if (key > mid)
					l0 = mid+1;
				else
					return mid;
			}
			return -1;
		}
		static void Main(string[] args)
		{
			int[] val = new[] {1, 4,8,16,18,27,34,58,79,84,85,88,89,91};
			int key = 98;

			BinarySearch(val, key);
		}
	}
}
