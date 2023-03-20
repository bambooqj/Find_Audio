using NAudio.CoreAudioApi;
using System;

class Program
{
    static void Main(string[] args)
    {
        MMDeviceEnumerator deviceEnum = new MMDeviceEnumerator();
        MMDevice device = deviceEnum.GetDefaultAudioEndpoint(DataFlow.Capture, Role.Console);
        AudioSessionManager sessionManager = device.AudioSessionManager;
        
        for (int i = 0; i < sessionManager.Sessions.Count; i++)
        {
            AudioSessionControl sessionControl = sessionManager.Sessions[i];
            uint processId = sessionControl.GetProcessID;
            string processName = System.Diagnostics.Process.GetProcessById((int)processId).ProcessName;
            Console.WriteLine("Process name: " + processName+"---ProcessID:"+processId);
        }


    }
}
