﻿using FUNERAL_MVVM.Utility;
using FUNERALMVVM.View;
using FUNERALMVVM.ViewModel;
using LegacyInfrastructure.Worker;
using Worker;
using Worker.EF;

namespace FUNERALMVVM.Commands.Workers
{
    internal class AuthenticationCommand : BaseCommands
    {
        private readonly AuthenticationController _controller;
        public AuthenticationCommand(AuthenticationController controller)
        {
            _controller = controller;
        }

        public override void Execute(object parameter)
        {
            _controller.Response = WorkerConnector.Auth(_controller.Name, _controller.Password);

            string role = WorkerConnector.GetWorkerRole(_controller.Name);

            WorkerRepos workerRepos = new WorkerRepos();
            workerRepos.SendToJournal(_controller.Name);

            if (_controller.Response is "ok")
            {
                WorkWindow workWindow = new();
                workWindow.Show();
                if(role == "Сотрудник")
                {
                    workWindow.UploadDORD.IsEnabled = false;
                    workWindow.StorageHead.IsEnabled = false;

                    workWindow.UploadDORD.Content = "";
                    workWindow.StorageHead.Content = "";
                }
                _controller._mainWindow.Close();
            }
        }
    }
}
