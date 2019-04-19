using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using Hangfire;
using System.Configuration;
using betawatch.DatabaseModel;
using betawatch.Classes;

[assembly: OwinStartup(typeof(betawatch.Startup))]

namespace betawatch
{
    public class Startup
    {
        private BackgroundJobServer _jobServer;

        public void Configuration(IAppBuilder app)
        {
            ///Configure Hangfire to use SQL Server
            GlobalConfiguration.Configuration.UseSqlServerStorage(ConfigurationManager.ConnectionStrings["BetaWatchModel"].ConnectionString);

            ///Route the Hangfire Dashboard to /JobDashboard        TODO: ADD PROTECTION
            app.UseHangfireDashboard("/JobDashboard");

            ///Start a server to handle requests
            _jobServer = new BackgroundJobServer();

            ///Start a job to update the database hourly
            RecurringJob.AddOrUpdate("RefreshDatabase", () => CrackwatchFunctions.RefreshDatabase(), Cron.Hourly);


        }
    }
}
