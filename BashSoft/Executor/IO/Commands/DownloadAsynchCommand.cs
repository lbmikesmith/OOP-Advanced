﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Executor.Contracts;
using Executor.Exceptions;
using Executor.Network;
using Executor.Judge;
using Executor.Repository;

namespace Executor.IO.Commands
{
    class DownloadAsynchCommand : Command
    {
        public DownloadAsynchCommand(string input, string[] data, Tester tester,
            StudentsRepository repository, DownloadManager downloadManager, IDirectoryManager ioManager)
            : base(input, data, tester, repository, downloadManager, ioManager)
        {
        }

        public override void Execute()
        {
            if (this.Data.Length != 2)
            {
                throw new InvalidCommandException(this.Input);
            }

            string url = this.Data[1];
            this.DownloadManager.DownloadAsync(url);
        }
    }
}
