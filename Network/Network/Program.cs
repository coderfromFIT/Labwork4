using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

interface IConnectable
{
    void Connect();
    void Disconnect();
    void TransmitData(string data, Computer destination);
}

// Base class for computers
class Computer
{
    public string IPAddress { get; set; }
    public int Power { get; set; }
    public string OS { get; set; }

    public Computer(string ipAddress, int power, string os)
    {
        IPAddress = ipAddress;
        Power = power;
        OS = os;
    }
}

// Derived classes for specific types of computers
class Server : Computer
{
    public Server(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
        // Additional properties specific to Server
    }
}

class Workstation : Computer
{
    public Workstation(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
        // Additional properties specific to Workstation
    }
}

class Router : Computer
{
    public Router(string ipAddress, int power, string os) : base(ipAddress, power, os)
    {
        // Additional properties specific to Router
    }
}

// Class representing a network
class Network
{
    private List<Computer> computers = new List<Computer>();

    public void AddComputer(Computer computer)
    {
        computers.Add(computer);
    }

    public void ConnectComputers(Computer computer1, Computer computer2)
    {
        // Logic for connecting computers in the network
        Console.WriteLine($"{computer1.IPAddress} is now connected to {computer2.IPAddress}");
    }

    public void DisconnectComputers(Computer computer1, Computer computer2)
    {
        // Logic for disconnecting computers in the network
        Console.WriteLine($"{computer1.IPAddress} is now disconnected from {computer2.IPAddress}");
    }

    public void TransmitData(Computer sender, Computer receiver, string data)
    {
        // Logic for transmitting data between computers
        Console.WriteLine($"{sender.IPAddress} sent data to {receiver.IPAddress}: {data}");
    }
}

class Program
{
    static void Main()
    {
        // Creating computers with default values
        Server server = new Server("192.168.1.1", 1000, "Windows Server");
        Workstation workstation = new Workstation("192.168.1.2", 500, "Windows 10");
        Router router = new Router("192.168.1.3", 800, "RouterOS");

        // Creating a network
        Network network = new Network();
        network.AddComputer(server);
        network.AddComputer(workstation);
        network.AddComputer(router);

        // Connecting computers in the network
        network.ConnectComputers(server, workstation);
        network.ConnectComputers(workstation, router);

        // Transmitting data between computers
        network.TransmitData(server, workstation, "Hello, workstation!");

        // Disconnecting computers in the network
        network.DisconnectComputers(server, workstation);

        Console.ReadKey();
    }
}