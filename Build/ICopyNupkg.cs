using Nuke.Common;
using Nuke.Common.IO;
using Nuke.Common.Utilities.Collections;
using ricaun.Nuke.Components;

interface ICopyNupkg : ICompile, ITest
{
    Target CopyNupkg => _ => _
        .TriggeredBy(Compile)
        .Before(Test)
        .Executes(() =>
        {
            var referencesDirectory = Solution.Directory / "references";

            if (!referencesDirectory.DirectoryExists())
            {
                Serilog.Log.Warning($"Skip Not found: {referencesDirectory}");
                return;
            }

            var mainProjectDirectory = GetMainProject().Directory;
            var packages = Globbing.GlobFiles(mainProjectDirectory, "**/*.nupkg");

            packages.ForEach(file =>
            {
                Serilog.Log.Warning($"CopyFile: {file.Name} to {referencesDirectory}");
                FileSystemTasks.CopyFileToDirectory(file, referencesDirectory, FileExistsPolicy.Overwrite);
            });
        });
}