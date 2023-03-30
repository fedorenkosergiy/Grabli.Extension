namespace System
{
	[JetBrains.Annotations.PublicAPIAttribute]
	public static class DayOfWeekExtension
	{
		public static bool IsWeekDay(this DayOfWeek day) => day < DayOfWeek.Saturday;

		public static bool IsWeekEnd(this DayOfWeek day) => day > DayOfWeek.Friday;
	}
}
