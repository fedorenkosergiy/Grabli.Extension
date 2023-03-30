namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class IListIntExtension
	{
		public static bool TryGetMedian(this IList<int> list, out int result) => list.TryGetMedian(GetAvg, out result);

		private static int GetAvg(int a, int b)
		{
			if (a == b) return a;

			bool sumIsOdd = a.IsOdd() && b.IsEven() || a.IsEven() && b.IsOdd();
			bool avgWillBeLess = a.IsOdd() && b.IsOdd();

			int result = (a >> 1) + (b >> 1);

			if (sumIsOdd && result.IsOdd() || avgWillBeLess) { ++result; }

			return result;
		}
	}
}
