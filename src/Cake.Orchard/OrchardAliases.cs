using Cake.Core;
using Cake.Core.Annotations;
using Cake.Core.IO;

namespace Cake.Orchard
{
    [CakeAliasCategory("Orchard")]
    public static class OrchardAliases
    {
        [CakeMethodAlias]
        public static void ValidateOrchardFiles(this ICakeContext context, FilePathCollection files)
        {
            ValidateExtensionProjectFiles.ValidateFiles(context, files);
        }

        [CakeMethodAlias]
        public static FilePathCollection FilterModuleBinaries(this ICakeContext context,
            FilePathCollection moduleBinaries, FilePathCollection orchardWebBinaries)
        {
            return FilterBinaries.Filter(context, moduleBinaries, orchardWebBinaries);
        }

        [CakeMethodAlias]
        public static FilePathCollection FilterThemeBinaries(this ICakeContext context,
            FilePathCollection themeBinaries, FilePathCollection orchardWebBinaries)
        {
            return FilterBinaries.Filter(context, themeBinaries, orchardWebBinaries);
        }
    }
}
