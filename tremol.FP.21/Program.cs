using System;
using System.IO.Ports;
using System.Management;
using System.Net.Sockets;
using System.Net;
using System.Text.Json;


try
{
    using (Tremol.FP test = new Tremol.FP())
    {
        test.OpenPort("COM9", 115200);
        test.PrintLogo();
        test.PrintText("Test 1...");
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}