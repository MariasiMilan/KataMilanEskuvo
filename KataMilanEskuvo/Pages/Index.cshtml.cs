using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Emit;
using System.Timers;

namespace KataMilanEskuvo.Pages
{
    public class IndexModel : PageModel
    {
        //public static System.Timers.Timer timer;
        //int count = 0;

        private readonly ILogger<IndexModel> _logger;
        public string day = string.Empty, time = string.Empty;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;

            CalculateDaysUntil();

            time = "17:16:55";

            //timer = new(1000);
            //timer.Elapsed += TimerTick;
            //timer.AutoReset = true;
            //timer.Enabled = true;
        }

        //public void TimerTick(Object sender, ElapsedEventArgs e)
        //{
        //    count++;
        //    time = count.ToString();
        //}

        private void CalculateDaysUntil()
        {
            DateTime theBigDay = new(2023, 9, 23);

            if (theBigDay < DateTime.Today)
                theBigDay = theBigDay.AddYears(1);

            day = (theBigDay - DateTime.Today).Days.ToString() + " nap";
        }
    }
}