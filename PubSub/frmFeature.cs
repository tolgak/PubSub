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
  public partial class frmFeature : Form
  {
    private IPlugin _plugin;

    private string[] _sampleTopics   = { "Topic 1", "Topic 3.1", "Topic 2", "Topic 3.3", "Topic 2.1", "Topic 2.2", "Topic 3.2", "Topic 4", "Topic 5", "Topic 5.1"};
    private string[] _sampleMessages = { "Lorem ipsum dolor sit amet, consectetur adipiscing elit."
                                       , "Vestibulum scelerisque dui ac mattis placerat."
                                       , "Donec bibendum mauris vel bibendum viverra."
                                       , "Nullam at nisl convallis dui porttitor dignissim sollicitudin porta ipsum."
                                       , "Praesent id nisl quis nunc commodo auctor."
                                       , "Aliquam rutrum erat malesuada sapien vestibulum, convallis sagittis neque iaculis."
                                       , "Praesent fringilla erat sed rutrum dignissim." };

    private List<string> _topicsOfInterest = new List<string>();
    
    private int _cntPublished = 0;
    private int _cntReceived = 0;
    private int _cntInterested = 0;
    private Random _random = new Random();

    private string RandomTopic   => _sampleTopics[_random.Next(0, _sampleTopics.Length - 1)];

    private string RandomMessage => _sampleMessages[_random.Next(0, _sampleMessages.Length - 1)];


    public frmFeature() 
    {
      InitializeComponent();
    }

    public frmFeature(IPlugin plugin) : this()
    {
      _plugin = plugin;
      _plugin.OnMessageReceived += plguin_OnMessageReceived;

      this.PublishTo(new Payload { Sender = this, Topic = "What's new?" }, $"{_plugin.Name} came alive!");

      this.ApplyRandomSubscription();
      this.RefreshEventInfo();      
    }

    private void plguin_OnMessageReceived(Payload payload, string message)
    {
      try
      {
        if (!this.Interested(payload))
          return;

        _cntInterested++;
        this.Log($"{DateTime.Now} {payload.Topic}\n");
        this.Log($"{message}\n\n\n");
      }
      finally
      {
        _cntReceived++;
        this.RefreshEventInfo(payload.Topic);
      }
    }

    private void btnPublish_Click(object sender, EventArgs e)
    {
      this.PublishTo(new Payload { Sender = this, Topic = this.RandomTopic}, $"{this.RandomMessage}");
    }

    private void btnResubscribe_Click(object sender, EventArgs e)
    {
      _topicsOfInterest.Clear();

      this.ApplyRandomSubscription();
      this.RefreshEventInfo();
    }

    private void frmFeature_FormClosing(object sender, FormClosingEventArgs e)
    {
      _plugin.OnMessageReceived -= this.plguin_OnMessageReceived;
    }

    private void PublishTo(Payload payload, string message)
    {
      _plugin.Host.Publish(payload, message);
      _cntPublished++;

      RefreshEventInfo();
    }

    private void ApplyRandomSubscription()
    {
      lblTopic1.Text = this.PickRandomTopic();
      _topicsOfInterest.Add(lblTopic1.Text);      

      lblTopic2.Text = this.PickRandomTopic();
      _topicsOfInterest.Add(lblTopic2.Text);      

      lblTopic3.Text = this.PickRandomTopic();
      _topicsOfInterest.Add(lblTopic3.Text);
    }


    private string PickRandomTopic()
    {
      var topic = this.RandomTopic;
      if (!_topicsOfInterest.Contains(topic))
        return topic;

      return PickRandomTopic();
    }


    private void RefreshEventInfo(string topic = "")
    {
      lblMessageInfo.Text = $"Published: {_cntPublished} Received: {_cntReceived}  Interested: {_cntInterested}";

      pnlTop.Controls.OfType<Label>()
                     .ToList()
                     .ForEach(x => { x.BackColor = x.Text == topic ? Color.Maroon : SystemColors.Control;
                                     x.ForeColor = x.Text == topic ? Color.White : SystemColors.ControlText; });
    }

    private bool Interested(Payload payload)
    {
      return payload.Topic == "URGENT" || (payload.Sender != this && _topicsOfInterest.Contains(payload.Topic));
    }

    private void Log(string text) => txtLog.AppendText(text);


  }
}
