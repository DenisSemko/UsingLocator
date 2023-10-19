<img src="https://github.com/DenisSemko/UsingLocator/assets/53062219/9a654799-d104-4c0a-a4fe-a1a326eedf19" alt="logo" title="logo" align="right" height="100" />

# Using Locator for Rider
> Powerful Rider plugin designed to streamline the management of C# using directives within your codebase.

[![Build](https://github.com/DenisSemko/UsingLocator/actions/workflows/build.yml/badge.svg)](https://github.com/DenisSemko/UsingLocator/actions/workflows/build.yml)

## Table of Contents
* [General Info](#general-information)
* [Technologies Used](#technologies-used)
* [Features](#features)
* [Screenshots](#screenshots)
* [Setup](#setup)
* [Usage](#usage)
* [Project Status](#project-status)
* [Contact](#contact)
* [License](#license)

## General Information
UsingLocator is a Rider plugin that simplifies the process of moving using directives to a global file, creating one if it doesn't exist, and intelligently sorting and removing duplicates. With UsingLocator, you can effortlessly maintain code cleanliness and organization, making your C# development experience more efficient and hassle-free.

## Technologies Used
- C# 7.0
- Rider IDE (compatible with Rider version 2023.2.2)

## Features
- Moves all selected using directives to the global file;
- Creates the global file if it doesn't exist;
- Sorts and removes duplicates in the global file.

## Screenshots

<img width="1438" alt="Screenshot 2023-10-18 at 17 54 37" src="https://github.com/DenisSemko/UsingLocator/assets/53062219/628ed21d-ba71-441b-a2e3-f66cf37a68c2">

## Setup
> Before using the plugin, make sure it's compatible with your Rider version! Visit Marketplace to check: [UsingLocator](https://plugins.jetbrains.com/plugin/22951-guidgenerator)

There are two ways how to install the plugin:

  1️⃣ Marketplace
  - Open Rider and go to `Settings` / `Plugins` / `Marketplace`
  - Search for "UsingLocator"
  - Click `Install` -> `Save`
  - Restart Rider

  2️⃣ Install .zip archive
  - Find out the latest [**Release**](https://github.com/DenisSemko/UsingLocator/releases)
  - Download the .zip archive
  - Go to `Settings` / `Plugins` / `Install plugin from the disk`
  - Restart Rider

## Usage
  - Select the using directives you want to make global
  - Press `Alt + Enter`
  - Choose the context action "UsingLocator: Define Using Directive as Global"
  - Be happy

https://github.com/DenisSemko/UsingLocator/assets/53062219/9f8429f8-6dda-49fc-96b4-976365eea4db

## Project Status
_v1.0 has been released_

[![Rider](https://img.shields.io/jetbrains/plugin/v/RIDER_PLUGIN_ID.svg?label=Rider&colorB=0A7BBB&style=for-the-badge&logo=rider)](https://plugins.jetbrains.com/plugin/22963-usinglocator)

## Contact
Created by [@dench327](https://www.linkedin.com/in/denis-semko-551b91191) - feel free to contact me!

© 2023

## License
> You can check out the full license [here](https://github.com/DenisSemko/UsingLocator/blob/main/LICENSE).
This project is licensed under the terms of the MIT license.
