# MusicRecommenderAPI

Music Recommender API which uses the NReco library for machine learning to recommend music.

## Table of Contents

- [Introduction](#introduction)
- [Features](#features)
- [Installation](#installation)
- [Usage](#usage)
- [Configuration](#configuration)

## Introduction

MusicRecommenderAPI is designed to provide music recommendations using machine learning algorithms. It leverages the NReco library to analyze and predict user preferences.

## Features

- Recommendation engine powered by NReco
- Easy to integrate with existing applications
- Scalable and performant

## Installation

To install the MusicRecommenderAPI, follow these steps:

1. Clone the repository:
    ```bash
    git clone https://github.com/NicatQaraxanov/MusicRecommenderAPI.git
    cd MusicRecommenderAPI
    ```

2. Build the project:
    ```bash
    dotnet build
    ```

3. Run the application:
    ```bash
    dotnet run
    ```

## Usage

To use the API, send requests to the endpoints provided. Here is an example of how to get music recommendations:

```http
GET /api/Recommendations/123
```

## Configuration

Configuration details for the MusicRecommenderAPI can be found in the appsettings.json file. Adjust the settings according to your environment and requirements.