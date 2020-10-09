using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ServiceReference1;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace TestPlatformProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public IServiceProvider ServiceProvider { get; private set; }
        public IConfiguration Configuration { get; private set; }

        protected override void OnStartup(StartupEventArgs e)
        {
            var serviceCollection = new ServiceCollection();
            ConfigurationServiceAsync(serviceCollection);

            ServiceProvider = serviceCollection.BuildServiceProvider();
            ServiceProvider.GetRequiredService<MainWindow>().Show();
        }
        private void ConfigurationServiceAsync(IServiceCollection services)
        {
            services.AddTransient(typeof(MainWindow));

            services.AddTransient(typeof(Service1Client));
        }
    }
}