using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cake.Core;
using Cake.Core.IO;

namespace Cake.Orchard
{
    internal static class FilterBinaries
    {
        public static FilePathCollection Filter(ICakeContext context, FilePathCollection moduleBinaries, FilePathCollection orchardWebBinaries)
        {
            if (context == null)
            {
                throw new ArgumentNullException("context");
            }
            if (moduleBinaries == null || orchardWebBinaries == null)
            {
                throw new ArgumentNullException("A FilePathCollection is empty.");
            }

            var orchardWebAssemblies = new HashSet<string>(
               orchardWebBinaries.Select(item => item.ToString()),
               StringComparer.InvariantCultureIgnoreCase);

            return new FilePathCollection(moduleBinaries
                .Where(item => orchardWebAssemblies.Contains(item.ToString())), PathComparer.Default);
        }
    }
}
