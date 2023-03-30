[JetBrains.Annotations.PublicAPIAttribute]
public static class ArrayExtension
{
	public static int FirstIndex<T>(this T[] array) => 0;

	public static int LastIndex<T>(this T[] array) => array.Length - 1;

    public static bool IsEmptyArray<T>(this T[] array) => array.Length == 0;
}
