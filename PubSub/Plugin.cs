using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubSub
{
  public class Plugin : IPlugin
  {
    public static int Counter = 0;

    public Plugin()
    {
      this.Id = ++Plugin.Counter;
    }

    public IPluginHost _host;
    public IPluginHost Host => _host;

    private Form _form;

    public event Action<Payload, string> OnMessageReceived;

    public string Name => $"Plugin {this.Id}";

    public int Id { get; set; }
    

    public void Initialize(IPluginHost host)
    {
      _host = host;
      _host.Register(this);

      _form = new frmFeature(this) { Text = $"{this.Name}" };

      _host.OnBroadcast += (payload, message) => OnMessageReceived?.Invoke(payload, message) ;
    }


    public void Run()
    {
      _form.Show();
    }


  }
}
