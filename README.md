# Labwork4
# EcoSystem Modeling System

## Overview
This repository contains a simulation system for modeling ecosystems. The system is designed to simulate the interactions between different organisms within an ecosystem, including aspects such as energy, age, and size. The system includes classes for living organisms, such as animals, plants, and microorganisms, as well as interfaces for reproduction and predation. The `Ecosystem` class models the overall interaction between organisms, including aspects like feeding, reproduction, and competition for resources.

## Classes and Interfaces
### 1. Living Organism
- Base class with attributes: energy, age, size.

### 2. Animal, Plant, Microorganism
- Inherited classes from Living Organism with unique characteristics for each type.

### 3. IReproducible and IPredator Interfaces
- `IReproducible`: Defines the ability to reproduce.
- `IPredator`: Defines the ability to hunt other organisms.

### 4. Ecosystem
- Class modeling the interaction between different organisms within an ecosystem.
- Simulates feeding, reproduction, and competition for resources.

# Computer Network Simulation

## Overview
This repository contains a simulation system for a hypothetical computer network. The system is designed to simulate the behavior of computers, servers, workstations, and routers in a network. It includes classes for basic computers, servers, workstations, and routers, along with interfaces for connecting and disconnecting devices. The `Network` class models the overall interaction between different computers, including data transmission and connection/disconnection.

## Classes and Interfaces
### 1. Computer
- Base class with attributes: IP address, power, operating system type.

### 2. Server, Workstation, Router
- Inherited classes from Computer with unique properties for each type.

### 3. IConnectable Interface
- Defines the ability to connect to other devices in the network, transmit and receive data.

### 4. Network
- Class modeling the interaction between different computers in the network.
- Simulates data transmission, connection, and disconnection.

# Traffic Simulation System (Optional)

## Overview
This section outlines a simulation system for modeling and optimizing traffic in a city. It includes classes for roads, vehicles, and an interface for drivable actions. Optionally, it suggests creating a simulation class for simulating traffic on different roads, including the ability to optimize traffic flow.

## Classes and Interfaces
### 1. Road
- Class with information about length, width, number of lanes, current traffic level, etc.

### 2. Vehicle
- Class with characteristics such as speed, size, and type (car, truck, bus, etc.).

### 3. IDriveable Interface
- Defines actions that a vehicle can perform, such as moving and stopping.

### 4. Traffic Simulation (Optional)
- (A) Class simulating the movement and behavior of different vehicles based on road conditions.
- (B) (Optional) Simulation class using the mentioned classes to model traffic on various city roads. Includes the ability to optimize traffic by adjusting the movement of vehicles, regulating traffic lights, etc.
