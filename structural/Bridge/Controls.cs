using Bridge.Contracts;

namespace Bridge.Controls;

public class RemoteControl
{
  protected readonly IDevice _device;

  public RemoteControl(IDevice device)
  {
    _device = device;
  }

  public void TogglePower()
  {
    if (_device.IsEnabled()) {
      _device.Enable();
      return;
    }
    _device.Disable();
  }

  public void VolumeDown()
  {
    _device.SetVolume(_device.GetVolume() - 10);
  }

  public void VolumeUp()
  {
    _device.SetVolume(_device.GetVolume() + 10);
  }

  public void ChannelDown()
  {
    _device.SetChannel(_device.GetChannel() - 1);
  }

  public void ChannelUp()
  {
    _device.SetChannel(_device.GetChannel() + 1);
  }
}

public class AdvancedRemoteControl : RemoteControl
{
  public AdvancedRemoteControl(IDevice device) : base(device) {}

  public void Mute() 
  {
    _device.SetVolume(0);
  }
}