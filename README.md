# :game_die: DiceRoll

A simple console application that allows users to roll dice and receive messages depending on their score.

## Overview

DiceRoll simulates the rolling of three dice and provides bonus points for rolling doubles or triples. Based on your final score, you receive different messages about your luck!

## Features

- Roll three six-sided dice.
- Gain bonus points for doubles (+2) or triples (+6).
- Special rewards for the highest rolls:
  - Roll a **24**: *You Won A House!*
  - Roll **18 or higher**: *You Won A Car!*
- Fun feedback for high (≥ 15) or low (< 6) scores.
- Displays the total score and your dice results.

## How to Run

1. **Clone this repository:**
   ```bash
   git clone https://github.com/FreddyJ01/DiceRoll.git
   ```

2. **Navigate to the project directory:**
   ```bash
   cd DiceRoll/ConsoleApp1
   ```

3. **Build and run the application:**
   ```bash
   dotnet run
   ```

## Example Output

```
You Rolled: 5, 5, 5
You Rolled Triples +6 Points!
You Won A House!
--High Score!--
Total Score: 24
```

## How it Works

- The application generates three random numbers (1-6).
- If two numbers match, you get 2 extra points. If all three match, you get 6 extra points.
- Depending on your total, you receive messages for winning a car, a house, or just a high/low score.

## Requirements

- [.NET 8.0 SDK](https://dotnet.microsoft.com/download)
