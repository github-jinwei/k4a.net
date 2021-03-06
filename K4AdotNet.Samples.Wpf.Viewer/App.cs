﻿using System;
using System.Windows;

namespace K4AdotNet.Samples.Wpf.Viewer
{
    internal sealed class App : AppBase
    {
        [STAThread]
        public static void Main()
            => new App().Run();

        protected override Window CreateMainWindow(StartupEventArgs e)
            => new MainWindow(new MainModel(this));

        public override void ShowWindowForModel(object viewModel)
        {
            if (viewModel is ViewerModel viewerModel)
                new ViewerWindow(viewerModel) { Owner = CurrentWindow }.Show();
            else
                throw new NotSupportedException();
        }
    }
}
