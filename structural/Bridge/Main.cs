using System.Net.Mime;
using Bridge.Controls;
using Bridge.Devices;

namespace Bridge;

public static class Application
{
  public static void Main(string[] args)
  {
    var tv = new Tv();
    var remoteControl = new RemoteControl(tv);

    var radio = new Radio();
    var advancedRemoteControl = new AdvancedRemoteControl(radio);

    advancedRemoteControl.Mute();
  }
}