﻿using FUNERAL_MVVM.Utility;
using FUNERALMVVM.ViewModel;
using System;

namespace FUNERALMVVM.Commands.Workers
{
    internal class AddWorkerCommand : BaseCommands
    {
        private readonly WorkerController _context;

        public AddWorkerCommand(WorkerController context)
        {
            _context = context;
        }

        public override void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}