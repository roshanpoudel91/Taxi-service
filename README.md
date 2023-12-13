## Overview

The Taxi service program is intended to be a very simple program which performs driving trips
from one destination to another.

## Expectations

Write a program which which performs trips for a given driver. When the trip
is done the program writes a small message saying the trip was complete. If 
for some reason the trip is unsuccessful an error message will be returned.

## Requirements

 - The minimum driving age is 21
 - A trip between Edmonton and Calgary is 3 seconds.
 - Only trips between Edmonton and Calgary need to be supported. If other locations are selected it can be considered an error.

## Setup

There is a skeleton solution already setup which contains:

 - A basic definition of a driver (/Model/Driver.cs)
 - A hardcoded driver store (/Data/DriverStore.cs)
 - An interface of a trip (/Service/ITrip.cs)
 - A project TaxiService.Tests.csproj which is setup for unit tests. 