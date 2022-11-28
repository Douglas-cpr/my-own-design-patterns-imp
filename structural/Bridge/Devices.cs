using Bridge.Contracts;

namespace Bridge.Devices;

public class Tv : IDevice
{
  private bool _enabled;
  private int _channel;
  private int _volume;

  public void Disable()
  {
    _enabled = false;
  }

  public void Enable()
  {
    _enabled = true;
  }

  public int GetChannel()
  {
    return _channel;
  }

  public int GetVolume()
  {
    return _volume;
  }

  public bool IsEnabled()
  {
    return _enabled;
  }
  
  public void SetChannel(int channel)
  {
    _channel = channel;
  }

  public void SetVolume(int volume)
  {
    _volume = volume;
  }
}

public class Radio : IDevice
{
  private bool _enabled;
  private int _channel;
  private int _volume;

  public void Disable()
  {
    _enabled = false;
  }

  public void Enable()
  {
    _enabled = true;
  }

  public int GetChannel()
  {
    return _channel + 1;
  }

  public int GetVolume()
  {
    return _volume;
  }

  public bool IsEnabled()
  {
    return _enabled;
  }

  public void SetChannel(int channel)
  {
    _channel = channel;
  }

  public void SetVolume(int volume)
  {
    _volume = volume;
  }
}