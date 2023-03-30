using UnityEngine.Pool;

namespace System.Collections.Generic
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class IListExtension
	{
		public static T FirstOfList<T>(this IList<T> list) => list[0];

		public static T LastOfList<T>(this IList<T> list) => list[^1];

		public static bool TryGetMedian<T>(this IList<T> list, Func<T, T, T> avgFunction, out T result)
		where T : IComparable
		{
			result = default;

			if (list == null) return false;

			if (avgFunction == null) return false;

			if (list.Count == 0) return false;

			switch (list.Count)
			{
				case 1:
					result = list[0];

					return true;
				case 2:
					result = avgFunction(list[0], list[1]);

					return true;
			}

			List<T> copy = ListPool<T>.Get();
			list.AppendTo(copy);
			copy.Sort();

			if (copy.Count.IsOdd())
			{
				int centralIndex = copy.LastIndex() >> 1;
				result = copy[centralIndex];
			}
			else
			{
				int rightCentralIndex = copy.Count >> 1;
				int leftCentralIndex = rightCentralIndex - 1;
				result = avgFunction(copy[leftCentralIndex], copy[rightCentralIndex]);
			}

			ListPool<T>.Release(copy);

			return true;
		}

		public static void AppendTo<T>(this IList<T> list, IList<T> toAppendTo)
		{
			for (int i = 0; i < list.Count; ++i) { toAppendTo.Add(list[i]); }
		}
	}
}
