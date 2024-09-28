using DNA_CLI_Framework.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Discorca_Python_Package_Maker
{
    internal class DiscorcaPythonPackageMakerDataManager : DataManager
    {
        /// <inheritdoc/>
        public override string COMMAND_PREFIX => DEFAULT_COMMAND_PREFIX;
    }
}
