using DNA_CLI_Framework;
using DNA_CLI_Framework.Commands;
using DNA_CLI_Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discorca_Python_Package_Maker.Commands
{
    internal class Package : DefaultCommand
    {

        DiscorcaPythonPackageMakerDataManager Data => ApplicationData<DiscorcaPythonPackageMakerDataManager>.Instance();

        public override void Execute(string[] args)
        {
            //Create a new Package
        }

        public override void ExecuteSolo(string[] args)
        {
            //Package A Folder

            //Arg 1 : Package Name
            //Arg 2 : Folder Path

            ConsoleProcessHandler processHandler = new ConsoleProcessHandler(ConsoleProcessHandler.ProcessApplication.CMD);

            if (args.Length == 1)
            {
                string packageName = args[0];
                string folderPath = ".";

                processHandler.RunProcess($"tar -zcvf {packageName}.tar.gz -C . ./");
            }

            if (args.Length == 2)
            {
                string packageName = args[0];
                string folderPath = args[1];

                if (Path.Exists(folderPath) == false)
                    folderPath = Data.CWD + "\\" + folderPath;

                Console.WriteLine(folderPath);
                if (Path.Exists(folderPath) == false)
                    throw new Exception("Folder Path does not exist.");

                processHandler.RunProcess($"tar -zcvf {packageName}.tar.gz -C {folderPath} ./");

                return;
            }
        }
    }
}
