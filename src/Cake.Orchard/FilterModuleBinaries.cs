using System;
using System.Collections.Generic;
using System.Linq;
using Cake.Core;
using Cake.Core.IO;

namespace Cake.Orchard {
    /// <summary>
    /// Filters module and theme binaries.
    /// </summary>
    internal static class FilterBinaries {
        /// <summary>
        /// Filters binaries that are in common with orchard web project binaries.
        /// </summary>
        /// <param name="context">The context.</param>
        /// <param name="moduleBinaries">Collection of binaries.</param>
        /// <param name="orchardWebBinaries">Collection of Orchard.Web project binaries.</param>
        /// <returns>Collection of binaries that are shared.</returns>
        public static FilePathCollection Filter(ICakeContext context, FilePathCollection moduleBinaries, FilePathCollection orchardWebBinaries) {
            if (context == null) {
                throw new ArgumentNullException(nameof(context));
            }
            if (moduleBinaries == null || orchardWebBinaries == null) {
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
