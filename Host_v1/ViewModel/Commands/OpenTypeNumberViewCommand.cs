﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Host_v1.ViewModel.Commands
{
    class OpenTypeNumberViewCommand : MyCommand<MainViewModel1>
    {
        public OpenTypeNumberViewCommand(MainViewModel1 cvm) : base(cvm)
        {
        }

        public override bool CanExecute(object parameter)
        {
            return true;
        }

        public override void Execute(object parameter)
        {
            View.TypeNumber t = new View.TypeNumber(_cvm.db);
            t.ShowDialog();
        }
    }
}