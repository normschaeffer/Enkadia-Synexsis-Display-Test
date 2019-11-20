using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Enkadia.Synexsis.Components.Displays.Samsung;
using Enkadia.Synexsis.Components.Displays.Sharp;
using Enkadia.Synexsis.ComponentFramework.Extensions;
using Microsoft.Extensions.DependencyInjection;


namespace DisplayTest
{

    public sealed partial class MainPage : Page
    {

        private ExLink FrontDisplay;
        private SharpDisplay Rear1;
        private SharpDisplay Rear2;
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
            serviceCollection.AddTransient<SharpDisplay>();
            sp = serviceCollection.BuildServiceProvider();
            FrontDisplay = sp.ResolveWith<ExLink>("FrontDisplay");
            Rear1 = sp.ResolveWith<SharpDisplay>("Rear1");
            Rear2 = sp.ResolveWith<SharpDisplay>("Rear2");
        }

        public void BtnPowerOff_OnClick(object sender, RoutedEventArgs e)
        {
            FrontDisplay.PowerOff();
            Rear1.PowerOff();
            Rear2.PowerOff();
        }

        public void BtnPowerOn_OnClick(object sender, RoutedEventArgs e)
        {
            FrontDisplay.PowerOn();
            Rear1.PowerOn();
            Rear2.PowerOn();
        }
    }
}
