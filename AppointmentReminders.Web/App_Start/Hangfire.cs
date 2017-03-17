using Hangfire;
using Owin;

//Hangfire script provided by Twilio

namespace AppointmentReminders.Web
{
    public class Hangfire
    {
        public static void ConfigureHangfire(IAppBuilder app)
        {
            // commented out to test on Stuart's computer (transferring project and database connection issues)
            /*
            GlobalConfiguration.Configuration.UseSqlServerStorage("DefaultConnection");

            app.UseHangfireDashboard("/jobs");
            app.UseHangfireServer();
            */
        }

        public static void InitializeJobs()
        {
            /*
            RecurringJob.AddOrUpdate<Workers.SendNotificationsJob>(job => job.Execute(), Cron.Minutely);
            */
        }
    }
}