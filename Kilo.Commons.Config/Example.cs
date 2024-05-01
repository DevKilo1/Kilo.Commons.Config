using CitizenFX.Core;
using Newtonsoft.Json.Linq;

namespace Kilo.Commons.Config;

public class Example : BaseScript
{
    private Config config;

    private JObject defaultConfig = new JObject()
    {
        ["Test"] =  "Yes"
    };
    
    public Example()
    {
        LoadConfig();
    }

    private void LoadConfig()
    {
        // AddonType: callouts or plugins. This will decide what the subfolder is named (e.g. fivepd/callouts/[CustomFolderName]/config.json)
        // encodedConfigJSON: This is a stringified JObject. The returned Config class will be preloaded with the default config.
        // customFolderName: This is a required string value and it cannot be "". To prevent future issues, you need to have a custom folder to contain your config file. Normally the callout DLL is also placed in there.
        // fileName: The name of your config file.
        // resourceName: Always fivepd for now. No support for other resources.
        
        config = new Config(AddonType.plugins, defaultConfig.ToString(), "Example", "config.json", "fivepd");
        // You can index it like any other JObject. The Config class just has some extra things, which right now is only the (string)CustomFolderName.
    }
}