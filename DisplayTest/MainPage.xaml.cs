using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Enkadia.Synexsis.Components.Displays.Samsung;
using Enkadia.Synexsis.ComponentFramework.Extensions;
using Microsoft.Extensions.DependencyInjection;


namespace DisplayTest
{

    public sealed partial class MainPage : Page
    {

        private ExLink Display;
        private IServiceCollection serviceCollection;
        private IServiceProvider sp;


        public MainPage()
        {
            this.InitializeComponent();
            Device();
        }

        public void Device()
        {
            serviceCollection = new ServiceCollection();
            serviceCollection.AddSynexsis();
            serviceCollection.AddTransient<ExLink>();
            sp = serviceCollection.BuildServiceProvider();
            Display = sp.GetService<ExLink>();
        }

        public async void BtnPowerOff_OnClick(object sender, RoutedEventArgs e)
        {
            await Display.PowerOff();
        }

        public async void BtnPowerOn_OnClick(object sender, RoutedEventArgs e)
        {
            await Display.PowerOn();
        }
    }
}
