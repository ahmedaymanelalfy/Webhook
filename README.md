# Webhook Application

This repository contains a sample webhook implementation designed for real-time data exchange between an airline service and travel agents. The system demonstrates how webhooks can be used to send and receive notifications of events, such as flight updates.

## Overview

The project consists of three main services:
1. **AirLineSendAgent**: A service responsible for dispatching webhook notifications.
2. **AirlineWeb**: A web-based service that manages flight data and events.
3. **TravelAgentWeb**: Receives flight updates via webhooks and processes the data.

## Prerequisites

Ensure you have the following installed on your machine:
- .NET Core SDK 6.0 or later
- Docker and Docker Compose
- A text editor (VSCode, Visual Studio, etc.)

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
