using System.Reflection;
using SPTarkov.DI.Annotations;
using SPTarkov.Server.Core.DI;
using SPTarkov.Server.Core.Models.Logging;
using SPTarkov.Server.Core.Models.Utils;
using WTTServerCommonLib.Services;

namespace ClassLibrary1;

[Injectable(InjectionType = InjectionType.Singleton, TypePriority = OnLoadOrder.PostDBModLoader + 2)]

public class Plugin(ISptLogger<Plugin> duck, WTTCustomItemServiceExtended itemService) : IOnLoad
{
    private static Assembly Assembly = Assembly.GetExecutingAssembly();
    
    public Task OnLoad()
    {
        duck.LogWithColor("thank u for using this quacking awesome mod!!",LogTextColor.Cyan);

        itemService.CreateCustomItems(Assembly);
        
        return Task.CompletedTask; 
    }
}