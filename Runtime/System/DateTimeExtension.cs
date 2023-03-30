namespace System
{
	public static class DateTimeExtension
	{
		public static DateTime Clamp(this DateTime date, DateTime min, DateTime max)
		{
			if (date < min) return min;

			return date > max ? max : date;
		}

		public static DateTime SameTimeTomorrow(this DateTime date) => date.AddTicks(TimeSpan.TicksPerDay);
	}
}
