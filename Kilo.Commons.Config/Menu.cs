using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitizenFX.Core;
using CitizenFX.Core.Native;
using FivePD.API;
using MenuAPI;
using Newtonsoft.Json.Linq;

namespace Kilo.Commons;

public class ConfigMenu : BaseScript
{
    public static Menu _menu = new Menu("Config Editor", "By DevKilo");

    public ConfigMenu()
    {
        Startup();
    }

    private void Startup()
    {
     // This is being worked on!   
    }

    
}