using System;

class SmartDevice
{
    public string DeviceName;
    public bool PowerStatus;

    public SmartDevice(string name)
    {
        DeviceName = name;
        PowerStatus = false;
    }

    public void TogglePower()
    {
        PowerStatus = !PowerStatus;
        Console.WriteLine($"{DeviceName} is now {(PowerStatus ? "ON" : "OFF") }");
    }
}

class SmartLight : SmartDevice
{
    public int Brightness;

    public SmartLight(string name) : base(name)
    {
        Brightness = 50;
    }

    public void SetBrightness(int value)
    {
        Brightness = value;
        Console.WriteLine($"{DeviceName} brightness set to {Brightness}%");
    }
}

class SmartThermostat : SmartDevice
{
    public double Temperature;

    public SmartThermostat(string name) : base(name)
    {
        Temperature = 22.0;
    }

    public void SetTemperature(double value)
    {
        Temperature = value;
        Console.WriteLine($"{DeviceName} temperature set to {Temperature}");
    }
}

class Program
{
    static void Main()
    {
        SmartLight light = new SmartLight("Bedroom Light");
        SmartThermostat thermostat = new SmartThermostat("Hall Thermostat");

        light.TogglePower();
        light.SetBrightness(80);

        Console.WriteLine();

        thermostat.TogglePower();
        thermostat.SetTemperature(25.5);

        Console.ReadLine();
    }
}