namespace MusicStoreEF.Helpers
{
    public static class DateHelper
    {
        public static int GetSeconds(int minutes, int seconds)
        {
            return minutes * 60 + seconds;
        }

        public static string ToMinutesAndSeconds(this int number)
        {
            return number / 60 + ":" + (number % 60).ToString("00");
        }
    }
}