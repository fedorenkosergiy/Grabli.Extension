[JetBrains.Annotations.PublicAPIAttribute]
public static class BoolExtension
{
	public static int ToInt(this bool value) => value ? 1 : 0;

	public static uint ToUint(this bool value) => value ? 1u : uint.MinValue;

	public static long ToLong(this bool value) => value ? 1L : 0L;
}

