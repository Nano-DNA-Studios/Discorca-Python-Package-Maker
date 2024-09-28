using DNA_CLI_Framework;
using DNA_CLI_Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discorca_Python_Package_Maker
{
    internal class DiscorcaPythonPackageMaker<T> : CLIApplication<T> where T : DataManager, new()
    {
        /// <inheritdoc/>
        public override string ApplicationName => "Rocket League Replay Parser";


        public DiscorcaPythonPackageMaker() : base()
        {
        }
    }
}
