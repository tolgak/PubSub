using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubSub
{
  public interface IPlugin
  { 
    int Id { get; set; }
    string Name { get; }

    IPluginHost Host { get; }

    event Action<Payload, string> OnMessageReceived;
      
    void Initialize(IPluginHost host);
    void Run();


    

  }
}
