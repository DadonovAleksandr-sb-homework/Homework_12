﻿using Homework_12.Infrastructure.Commands;
using Homework_12.Model.AppSettings.AppConfig;
using Homework_12.Service.UserDialogService;
using Homework_12.ViewModels.Base;
using ProjectVersionInfo;
using System.Reflection;
using System.Windows;
using System.Windows.Input;

namespace Homework_12.ViewModels.MainWindowVm
{
    internal class MainWindowViewModel : BaseViewModel
    {
        private readonly IAppConfig _appConfig;
        private readonly IUserDialogService _userDialogService;
        /* ------------------------------------------------------------------------------------------------------------ */
        public MainWindowViewModel(IUserDialogService userDialogService)
        {
            _log.Debug($"Вызов конструктора {GetType().Name}");
            _appConfig = AppConfig.GetConfigFromDefaultPath();
            _userDialogService = userDialogService;

            var prjVersion = new ProjectVersion(Assembly.GetExecutingAssembly());
            Title = $"{AppConst.Get().AppDesciption} {prjVersion.Version}";

            #region Commands
            Exit = new RelayCommand(OnExitExecuted, CanExitExecute);
            #endregion

        }

        /// <summary>
        /// Действия выполняемые при закрытии основной формы
        /// </summary>
        public void OnExit()
        {
            //_projectConfigurationRepository?.Save();
        }
        /* ------------------------------------------------------------------------------------------------------------ */
        #region Commands

        #region Exit
        public ICommand Exit { get; }
        private void OnExitExecuted(object p) => Application.Current.Shutdown();
        private bool CanExitExecute(object p) => true;
        #endregion

        #endregion

        /* ------------------------------------------------------------------------------------------------------------ */

        /// <summary>
        /// Заголовок окна
        /// </summary>
        public string Title { get => Get<string>(); set => Set(value); }

    }
}