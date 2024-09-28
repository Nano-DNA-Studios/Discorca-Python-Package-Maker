using DNA_CLI_Framework;
using DNA_CLI_Framework.Commands;
using DNA_CLI_Framework.Data;

namespace Discorca_Python_Package_Maker.Commands
{
    internal class Create : Command
    {
        public override string CommandName => "create";

        public override string CommandDescription => "Creates a new Default Package";

        DiscorcaPythonPackageMakerDataManager Data => ApplicationData<DiscorcaPythonPackageMakerDataManager>.Instance();

        public override void Execute(string[] args)
        {
            if (args.Length != 1)
            {
                if (args.Length == 0)
                    Console.WriteLine("Please provide a package name.");

                if (args.Length > 1)
                    Console.WriteLine("Too many arguments provided.");

                return;
            }

            string packageName = args[0];

            ConsoleProcessHandler processHandler = new ConsoleProcessHandler(ConsoleProcessHandler.ProcessApplication.CMD);
            processHandler.ChangeWorkingDirectory(Data.CWD);


            if (!Path.Exists(Path.Combine(Data.CWD, packageName)))
                processHandler.RunProcess($"mkdir {packageName}");

            if (!Path.Exists(Path.Combine(Data.CWD, packageName, "Install.txt")))
                File.WriteAllText(Path.Combine(Data.CWD, packageName, "Install.txt"), "");

            if (!Path.Exists(Path.Combine(Data.CWD, packageName, "Start.py")))
                File.WriteAllText(Path.Combine(Data.CWD, packageName, "Start.py"), "print(\"Hello World!\")");

            Console.WriteLine("Package Created. \nOnce finished coding use \"dicorcapack.exe PackageName path/to/folder\" to compress the packge and send it to Discorca");

            try
            {
                processHandler.RunProcess($"code {packageName}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
