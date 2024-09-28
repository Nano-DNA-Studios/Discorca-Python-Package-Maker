using DNA_CLI_Framework.CommandHandlers;

namespace Discorca_Python_Package_Maker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DiscorcaPythonPackageMaker<DiscorcaPythonPackageMakerDataManager> app = new DiscorcaPythonPackageMaker<DiscorcaPythonPackageMakerDataManager>();
            app.SetCommandHandler<DefaultCommandHandler>();
            app.RunApplication(args);
        }
    }
}
