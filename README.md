# Webhook Application

This repository contains a sample webhook implementation designed for real-time data exchange between an airline service and travel agents. The system demonstrates how webhooks can be used to send and receive notifications of events, such as flight updates.

## Overview

The project consists of three main services:
1. **AirLineSendAgent**: A service responsible for dispatching webhook notifications.
2. **AirlineWeb**: A web-based service that manages flight data and events.
3. **TravelAgentWeb**: Receives flight updates via webhooks and processes the data.

## Prerequisites

Ensure you have the following installed on your machine:
- .NET Core SDK 9.0
- Docker and Docker Compose
- A text editor (VSCode, Visual Studio, etc.)

## Additional Resources

If you are interested in learning more about how to implement webhooks using .NET, consider taking the following course:

- [Webhooks with .NET 5 - Udemy Course](https://www.udemy.com/course/webhooks-with-dotnet-5)

### Certification

I have completed this course. You can view my certificate here:  
- [Certificate of Completion](https://www.udemy.com/certificate/UC-88ad6d5c-df25-4cbf-bdf5-52716cf852fd/)

## Installation

### Clone the repository

```bash
git clone https://github.com/ahmedaymanelalfy/Webhook.git
cd Webhook


```bash
# Clone the repository
git clone https://github.com/ahmedaymanelalfy/WebHooks.git

# Navigate to the project directory
cd WebHooks

# Install dependencies (if applicable)
dotnet restore
