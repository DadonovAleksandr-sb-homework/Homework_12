﻿using System;
using System.Threading;

namespace Homework_12.Service.UserDialogService
{
    internal interface IUserDialogService
    {
        void ShowInformation(string message);
        void ShowWarning(string message);
        void ShowError(string message);
        bool Confirm(string message, bool exclamation = false);

        (IProgress<double> Progress, IProgress<string> Status, CancellationToken Cancel, Action Close) ShowProgress(string title);
    }
}