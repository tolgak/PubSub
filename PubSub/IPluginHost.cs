using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PubSub
{
  public interface IPluginHost
  {
    void Initialize();
    void Register(IPlugin plugin);
    void Spawn<T>(int count) where T : IPlugin;
    
    void Publish(Payload payload, string message);
    event Action<Payload, string> OnBroadcast;
  }
}
