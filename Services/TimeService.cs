namespace lr3_1.Services
{
    public class TimeService
    {
        public string GetCurrentTimeOfDay()
        {
            var currentHour = DateTime.Now.Hour;

            if (currentHour >= 12 && currentHour < 18)
                return "Зараз ранок";
            else if (currentHour >= 18 && currentHour < 24)
                return "Зараз вечір";
            else if (currentHour >= 0 && currentHour < 6)
                return "Зараз нічка";
            else
                return "Зараз ранок";
        }
    }

}
