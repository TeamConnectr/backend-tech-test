# Connectr Backend Tech Test

Hello, and thank you for taking our tech test and your interest in working with us!

The Connectr platform supports users to find great employers, and to improve their skills and advance their careers. We do this through connecting users with the best possible mentors, content, quiz-style self assesment and personalisation. We have big plans for Connectr and an ambitious product roadmap for the future.

This test is designed to assess the skills we use everyday.

## Goal

Build an API that allows clients to query Star Wars data and add additional data. A set of data (based on the swapi.dev API) is included. You can use this data however you like (including converting to other formats).

## Setup

This repository includes a sample project which will create a database and populate it with the example data on first run.

The application is based on an empty ASP.NET 5 project template, with the database setup using Entity Framework Core (`StarwarsDbContext`). By default the database will be created in your [localdb instance](https://docs.microsoft.com/en-us/sql/database-engine/configure-windows/sql-server-express-localdb?view=sql-server-ver15).

You can modify, alter or add to this project in anyway you see fit.

Please clone this repository to your machine and file share a ZIP with your final changes (emails with attachments often get blocked).

We have tested this project with Visual Studio 2019 and 2022.

## Duration

**Please only spend an hour on this test and aim to showcase your C# skills.**

It is ok to use a framework, scaffolding and Nuget packages.

Start with the most important requirements first. If you're short on time, there will be an opportunity at the next stage of the process to talk us through how any missing requirements would be met.

## Requirements

1. Allow clients to retrieve a list of all the films. This should include the films name, the names of all the planets featured and the name of all the characters featured.
2. Allow clients to create a character. The character should have a name, an optional birth year, one species, and one or more films.
3. Update the endpoint created in 1 to include paging.
4. Update the endpoint created in 1 to allow filtering by species. The client should be able to specify a species and only films that featured that species should be returned.
5. Update the endpoint created in 1 to allow filtering by planet. The client should be able to specify a planet and only films that featured that planet should be returned.

## Criteria for assessment

- Coding style
- Your overall solution approach
- Maintainability and extensibility
- Meeting the requirements
