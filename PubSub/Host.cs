using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
  public class Host : IPluginHost
  {
    private Dictionary<string, IPlugin> _pluginRegistery;

    public event Action<Payload, string> OnBroadcast;

    public void Initialize()
    {
      _pluginRegistery = new Dictionary<string, IPlugin>();

      this.Spawn<Plugin>(4); 
    }

    public void Register(IPlugin plugin)
    {
      if (_pluginRegistery.TryGetValue(plugin.Name, out var p))
        return;

      _pluginRegistery.Add(plugin.Name, plugin);
    }


    
    public void Publish(Payload payload, string message)
    {
      this.OnBroadcast?.Invoke(payload, message);
    }



    public void Spawn<T>(int count) where T : IPlugin
    {
      for (int i = 0; i < count; i++)
      {
        var p = Activator.CreateInstance<T>();
        p.Initialize(this);
        this.Register(p);

        p.Run();
      }
    }
  }
}
