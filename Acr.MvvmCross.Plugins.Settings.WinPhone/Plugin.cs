using System;
using Cirrious.CrossCore;
using Cirrious.CrossCore.Plugins;


namespace Acr.MvvmCross.Plugins.Settings.WinPhone {

    public class Plugin : IMvxPlugin {

        public void Load() {
            Mvx.LazyConstructAndRegisterSingleton(() => Acr.Settings.Settings.Instance);
        }
    }
}