using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

namespace Cake.Orchard {
    /// <summary>
    /// Contains functionality related to running Orchard build tasks.
    /// </summary>
    [CakeAliasCategory("Orchard")]
    public static class OrchardAliases {
        /// <summary>
        /// Validates Orchard module project files.
        /// </summary>
        /// <example>
        /// <code>
        /// #addin Cake.Orchard
        /// 
        /// Task("ValidateProjectFiles")
        ///  .Does(() => {
        ///    ValidateProjectFiles(GetFiles("pattern to match"));
        /// });
        /// </code>
        /// </example>
        /// <param name="context">The context.</param>
        /// <param name="files">Orchard module project files to be validated.</param>
        [CakeMethodAlias]
        public static void ValidateOrchardFiles(this ICakeContext context, FilePathCollection files) {
            ValidateExtensionProjectFiles.ValidateFiles(context, files);
        }

        /// <summary>
        /// Filters module binaries that are in common with orchard web project binaries.
        /// </summary>
        /// <example>
        /// <code>
        /// #addin Cake.Orchard
        /// 
        /// Task("FilterModuleBinaries")
        ///  .Does(() => {
        ///    var filteredBinaries = FilterModuleBinaries(GetFiles("**/Modules/**/*.dll"),GetFiles("**/**/*.dll");
        /// });
        /// </code>
        /// </example>
        /// <param name="context">The context.</param>
        /// <param name="moduleBinaries">Collection of module binaries.</param>
        /// <param name="orchardWebBinaries">Collection of Orchard.Web project binaries.</param>
        /// <returns>Collection of module binaries that are shared.</returns>
        [CakeMethodAlias]
        public static FilePathCollection FilterModuleBinaries(this ICakeContext context,
            FilePathCollection moduleBinaries, FilePathCollection orchardWebBinaries) {
            return FilterBinaries.Filter(context, moduleBinaries, orchardWebBinaries);
        }

        /// <summary>
        /// Filters theme binaries that are in common with the orchard web project binaries.
        /// </summary>
        /// <example>
        /// <code>
        /// #addin Cake.Orchard
        /// 
        /// Task("FilterThemeBinaries")
        ///  .Does(() => {
        ///    var filteredBinaries = FilterThemeBinaries(GetFiles("**/Themes/**/*.dll"),GetFiles("**/**/*.dll"));
        /// });
        /// </code>
        /// </example>
        /// <param name="context">The context.</param>
        /// <param name="themeBinaries">Collection of theme binaries.</param>
        /// <param name="orchardWebBinaries">Collection of Orchard.Web project binaries.</param>
        /// <returns>Collection theme of binaries that are shared.</returns>
        [CakeMethodAlias]
        public static FilePathCollection FilterThemeBinaries(this ICakeContext context,
            FilePathCollection themeBinaries, FilePathCollection orchardWebBinaries) {
            return FilterBinaries.Filter(context, themeBinaries, orchardWebBinaries);
        }
    }
}
