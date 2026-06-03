# Smart Traffic Light Simulation System

## Project Overview

The Smart Traffic Light Simulation System is a traffic management simulation developed using VB.NET Windows Forms Application. The purpose of this project is to demonstrate how traffic lights and pedestrian crossing systems can be managed through timer-based automation and event-driven programming.

The system simulates four connected traffic intersections, identified as Intersection A, Intersection B, Intersection C, and Intersection D. Each intersection contains vehicle traffic lights represented by Red, Yellow, and Green indicators. The traffic lights operate automatically according to a programmed sequence that controls the flow of traffic in different directions.

The project was designed to provide a simple representation of how real-world traffic management systems work. Through the use of timers, the traffic lights automatically change phases after a specific amount of time. This allows the simulation to continuously manage traffic flow without requiring manual control.

## System Functionality

The simulation contains four intersections arranged in a grid layout. Each intersection includes multiple traffic light indicators that represent the traffic signals used by vehicles. The traffic lights change according to synchronized traffic phases to prevent conflicting traffic movements and ensure an organized flow of vehicles.

The system operates through a countdown timer that determines when a traffic light phase should change. As the countdown reaches zero, the system automatically switches to the next phase. This process continues repeatedly throughout the simulation.

In addition to vehicle traffic management, the system also includes pedestrian crossing functionality. Each intersection has a dedicated pedestrian request button. When a pedestrian button is pressed, the system registers the request and activates the pedestrian crossing signal for a limited period of time. This allows pedestrians to cross safely before the signal returns to its normal state.

The simulation also provides Start, Stop, and Reset controls. These controls allow users to start the simulation, pause its operation, or reset the system back to its initial condition.

## Key Features

* Four traffic intersections (A, B, C, and D)
* Sixteen vehicle traffic lights
* Automatic traffic light phase switching
* Traffic light synchronization
* Pedestrian crossing system
* Pedestrian request buttons
* Countdown timer display
* Current phase monitoring
* Start, Stop, and Reset controls
* Graphical User Interface (GUI)
* Event-driven programming implementation

## Programming Concepts Used

This project demonstrates several important programming concepts:

### Event-Driven Programming

The system uses event-driven programming to respond to user actions and system events. Button click events are used for pedestrian requests and system controls, while timer events are used to update the traffic light states automatically.

### Timer-Based Control

A timer component is used to manage the traffic light sequence. The timer continuously updates the countdown and determines when traffic lights should change from one phase to another.

### Graphical User Interface (GUI)

The project uses Windows Forms controls such as Panels, Buttons, Labels, and Timers to create an interactive graphical interface that visually represents traffic lights and pedestrian signals.

## Controls Used

The following controls were used during development:

* Panels for traffic light indicators and pedestrian lights
* Buttons for pedestrian requests and system controls
* Labels for displaying countdown values and phase information
* Timer for automatic traffic light operation

## Project Purpose

The primary purpose of this project is to demonstrate how traffic management can be simulated through software. It provides an example of how timers, graphical user interfaces, and event-driven programming can work together to create an interactive traffic control system.

This project also serves as a learning tool for understanding the basic principles of traffic light synchronization, pedestrian crossing management, and automated control systems using VB.NET Windows Forms.
