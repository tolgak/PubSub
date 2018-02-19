using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PubSub
{
  public partial class frmMain : Form
  {

    private IPluginHost _host;
    public IPluginHost Host => _host;

    private List<string> _interestedTopic;

    public frmMain()
    {
      InitializeComponent();

      Initialize();
    }

    private void Initialize()
    {
      _interestedTopic = new List<string> { "What's new?" };

      _host = new Host();      
      _host.OnBroadcast += _host_OnBroadcast;
      _host.Initialize();
    }

    private void _host_OnBroadcast(Payload payload, string message)
    {
      if (!this.Interested(payload))
        return;

      this.Log($"Message received on {payload.Topic}\n");
      this.Log($"{payload.Topic} {message}\n");
    }

    private void Log(string text)
    {
      txtLog.AppendText(text);
    }

    private bool Interested(Payload payload)
    {
      return payload.Sender != this && _interestedTopic.Contains(payload.Topic);
    }

    private void btnSpawn_Click(object sender, EventArgs e)
    {
      _host.Spawn<Plugin>(1);
    }

    private void btnUrgent_Click(object sender, EventArgs e)
    {
      _host.Publish(new Payload { Sender = this, Topic = "URGENT" }, "WE ARE ON FIRE!!!");
    }
  }
}
