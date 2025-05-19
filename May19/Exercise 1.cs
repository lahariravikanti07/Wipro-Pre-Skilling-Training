using System;

namespace SmartHomeDevices
{
    // 1. Abstract Class
    public abstract class SmartDevice
    {
        public abstract void TurnOn(); // Abstract Method

        public void ShowStatus() // Concrete Method
        {
            Console.WriteLine("Device status: Active");
        }
    }

    // 2. Interface
    public interface IRemoteControl
    {
        void IncreaseVolume();
        void DecreaseVolume();
    }

    // 3a. SmartLight Class
    public class SmartLight : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Light turned on");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Lights do not support volume control");
        }
    }

    // 3b. SmartSpeaker Class
    public class SmartSpeaker : SmartDevice, IRemoteControl
    {
        public override void TurnOn()
        {
            Console.WriteLine("Smart Speaker turned on");
        }

        public void IncreaseVolume()
        {
            Console.WriteLine("Volume increased");
        }

        public void DecreaseVolume()
        {
            Console.WriteLine("Volume decreased");
        }
    }

    // 4. Main Method
    class Program
    {
        static void Main(string[] args)
        {
            SmartDevice light = new SmartLight();
            SmartDevice speaker = new SmartSpeaker();

            Console.WriteLine("Smart Light:");
            light.ShowStatus();
            light.TurnOn();
            ((IRemoteControl)light).IncreaseVolume();
            ((IRemoteControl)light).DecreaseVolume();

            Console.WriteLine("\nSmart Speaker:");
            speaker.ShowStatus();
            speaker.TurnOn();
            ((IRemoteControl)speaker).IncreaseVolume();
            ((IRemoteControl)speaker).DecreaseVolume();
        }
    }
}
