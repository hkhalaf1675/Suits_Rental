using Microsoft.Extensions.DependencyInjection;
using Suits_Rental.Contexts;
using Suits_Rental.Forms;
using Suits_Rental.IRepositories;
using Suits_Rental.Repositories;

namespace Suits_Rental
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            #region DI
            // inject the services

            //var servicesProvider = new ServiceCollection()
            //    .AddSingleton(typeof(ISuitsRepository),typeof(SuitsRepository))
            //    .BuildServiceProvider();

            //var services = new ServiceCollection();

            //// inject the suits repoistory
            //services.AddSingleton(typeof(ISuitsRepository), typeof(SuitsRepository));

            //var servicesProvider = services.BuildServiceProvider(); 
            #endregion

            Application.Run(new MainForm());
        }
    }
}