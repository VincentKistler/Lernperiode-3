using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Threading;

class Program
{
    static int playerPositionX = 0;
    static int playerPositionY = 10;
    static int groundLevel = 10;

    static List<Obstacle> obstacles = new List<Obstacle>();

    static void Main()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            DrawPlayer();
            DrawGround();
            MovePlayer();
            MoveObstacles();
            CheckCollisions();

            Thread.Sleep(70);
        }
    }

    static void DrawPlayer()
    {
        Console.SetCursorPosition(playerPositionX, playerPositionY);
        Console.Write("0");
    }

    static void DrawGround()
    {
        Console.SetCursorPosition(0, groundLevel);
        Console.Write(new string('-', Console.WindowWidth));
    }

    static void MovePlayer()
    {
        if (Console.KeyAvailable)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            switch (key.Key)
            {
                case ConsoleKey.A:
                    if (playerPositionX > 0)
                        playerPositionX--;
                    break;
                case ConsoleKey.D:
                    if (playerPositionX < Console.WindowWidth - 1)
                        playerPositionX++;
                    break;
                case ConsoleKey.Spacebar:
                    Jump();
                    break;
            }
        }
    }

    static void Jump()
    {
        if (playerPositionY == groundLevel)
        {
            for (int i = 0; i < 5; i++)
            {
                playerPositionY--;
                DrawPlayer();
                Thread.Sleep(10);
            }

            for (int i = 0; i < 5; i++)
            {
                playerPositionY++;
                DrawPlayer();
                Thread.Sleep(10);
            }
        }
    }

    static void MoveObstacles()
    {
        Random random = new Random();
        if (random.Next(0, 100) < 2) // 10% chance to spawn an obstacle
        {
            obstacles.Add(new Obstacle(Console.WindowWidth - 1, groundLevel - 1));
        }

        for (int i = 0; i < obstacles.Count; i++)
        {
            obstacles[i].MoveLeft();
            obstacles[i].Draw();
        }

        obstacles.RemoveAll(o => o.PositionX < 0); // Remove obstacles that have moved off-screen
    }

    static void CheckCollisions()
    {
        foreach (Obstacle obstacle in obstacles)
        {
            if (playerPositionX == obstacle.PositionX && playerPositionY == obstacle.PositionY)
            {
                GameOver();
            }
        }
    }

    static void GameOver()
    {
        Console.Clear();
        Console.WriteLine("Game Over!");
        Environment.Exit(0);
    }
}

class Obstacle
{
    public int PositionX { get; private set; }
    public int PositionY { get; private set; }

    public Obstacle(int x, int y)
    {
        PositionX = x;
        PositionY = y;
    }

    public void MoveLeft()
    {
        PositionX--;
    }

    public void Draw()
    {
        Console.SetCursorPosition(PositionX, PositionY);
        Console.Write("X");
    }
}
