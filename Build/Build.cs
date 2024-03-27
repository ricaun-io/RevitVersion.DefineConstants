using Nuke.Common;
using Nuke.Common.Execution;
using ricaun.Nuke;
using ricaun.Nuke.Components;

class Build : NukeBuild, IPublishPack, IPrePack, ICopyNupkg
{
    bool IPack.UnlistNuget => true;
    public static int Main() => Execute<Build>(x => x.From<IPublishPack>().Build);
}
