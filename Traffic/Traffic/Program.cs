using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Road
{
    public double Length { get; set; }
    public double Width { get; set; }
    public int NumberOfLanes { get; set; }
    public int TrafficLevel { get; set; }
}

// Interface for drivable vehicles
interface IDriveable
{
    void Move();
    void Stop();
}

// Class representing a vehicle
class TransportVehicle : IDriveable
{
    public int Speed { get; set; }
    public double Size { get; set; }
    public string Type { get; set; }

    public void Move()
    {
        Console.WriteLine($"{Type} is moving at speed {Speed}.");
    }

    public void Stop()
    {
        Console.WriteLine($"{Type} has stopped.");
    }
}

// Class simulating traffic and behavior on a road
class TrafficSimulation
{
    public void SimulateTraffic(List<TransportVehicle> vehicles, Road road)
    {
        foreach (var vehicle in vehicles)
        {
            // Simulate traffic behavior based on road conditions
            Console.WriteLine($"{vehicle.Type} on {road.Length}-meter road with {road.NumberOfLanes} lanes.");
            if (road.TrafficLevel > 50)
            {
                vehicle.Stop();
            }
            else
            {
                vehicle.Move();
            }
        }
    }
}

// Optional: Class simulating a traffic optimization simulation
class TrafficOptimizationSimulation : TrafficSimulation
{
    public void OptimizeTraffic(List<TransportVehicle> vehicles, Road road)
    {
        // Implement traffic optimization logic here
        Console.WriteLine("Traffic optimization in progress...");
    }
}

class Program
{
    static void Main()
    {
        // Example usage
        Road cityRoad = new Road { Length = 1000, Width = 20, NumberOfLanes = 2, TrafficLevel = 30 };

        List<TransportVehicle> vehicles = new List<TransportVehicle>
        {
            new TransportVehicle { Type = "Car", Speed = 60, Size = 5 },
            new TransportVehicle { Type = "Bus", Speed = 40, Size = 10 },
            new TransportVehicle { Type = "Truck", Speed = 30, Size = 15 }
        };

        TrafficSimulation simulation = new TrafficSimulation();
        simulation.SimulateTraffic(vehicles, cityRoad);

        // Optional: Simulate traffic optimization
        TrafficOptimizationSimulation optimizationSimulation = new TrafficOptimizationSimulation();
        optimizationSimulation.OptimizeTraffic(vehicles, cityRoad);
        Console.ReadKey();
    }
}