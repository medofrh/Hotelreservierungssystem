# Hotel Reservation System

Welcome to the Hotel Reservation System project! This project demonstrates an object-oriented model for a hotel reservation system in C#. It includes classes for managing hotels, rooms, guests, and reservations.

## Table of Contents

- [Overview](#overview)
- [Requirements](#requirements)
- [Project Structure](#project-structure)
- [Installation](#installation)
- [Usage](#usage)
- [License](#license)

## Overview

The Hotel Reservation System consists of several classes that work together to manage reservations for a hotel:

- **Hotel**: Represents a hotel with a name, address, and a list of rooms.
- **Room**: Represents a room with a room number, type (single, double, suite), price per night, and availability status.
- **Guest**: Represents a guest with a first name, last name, and a unique guest ID.
- **Reservation**: Represents a reservation for a room, including the guest, room, and reservation dates.

The system allows guests to reserve and cancel rooms, and hotels can manage the availability of rooms.

## Requirements

- .NET Core or .NET Framework (version 5.0 or later) must be installed on your machine.

## Project Structure

- `HotelReservationSystem/` - Contains the main source code and classes for the project.
- `Tests/` - Contains unit tests for the project.
- `README.md` - This file, which provides an overview of the project.

## Installation

To set up the project on your local machine, follow these steps:

1. Clone the repository:

    ```shell
    git clone <repository-url>
    ```

2. Navigate to the project directory:

    ```shell
    cd HotelReservationSystem
    ```

3. Restore dependencies:

    ```shell
    dotnet restore
    ```

## Usage

To run the project, use the following command:

```shell
dotnet run
