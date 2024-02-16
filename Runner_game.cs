using System;
using System.Collections.Generic;
using System.Threading;

class Obstacle
{
    public int PositionX { get; set; }
    public int PositionY { get; set; }

    public Obstacle(int x, int y)
    {
        PositionX = x;
        PositionY = y;
    }

    public void Draw()
    {
        Console.SetCursorPosition(PositionX, PositionY);
        Console.Write("X");
    }
}

class Program
{
    static int playerPositionX = 0;
    static int playerPositionY = 10;
    static int groundLevel = 10;
    static bool isJumping = false;
    static int score = 0;

    static List<Obstacle> obstacles = new List<Obstacle>();
    static Random random = new Random();

    static void Main()
    {
        Console.CursorVisible = false;

        while (true)
        {
            Console.Clear();
            DrawPlayer();
            DrawGround();
            MovePlayer();
            DrawObstacles();
            UpdateObstacles();
            DrawScore();

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
                case ConsoleKey.Spacebar:
                    Jump();
                    break;
            }
        }

        if (isJumping)
        {
            playerPositionY--;
            if (playerPositionY == groundLevel - 5)
            {
                isJumping = false;
            }
        }
        else if (playerPositionY < groundLevel)
        {
            playerPositionY++;
        }
    }

    static void Jump()
    {
        if (!isJumping && playerPositionY == groundLevel)
        {
            isJumping = true;
        }
    }

    static void DrawObstacles()
    {
        foreach (var obstacle in obstacles)
        {
            obstacle.Draw();
        }
    }

    static void UpdateObstacles()
    {
        if (random.Next(0, 300) < 10)
        {
            obstacles.Add(new Obstacle(Console.WindowWidth - 1, groundLevel));
        }

        foreach (var obstacle in obstacles)
        {
            obstacle.PositionX--;

            if (obstacle.PositionX == playerPositionX && obstacle.PositionY == playerPositionY)
            {
                score++;
            }
        }

        obstacles.RemoveAll(obstacle => obstacle.PositionX < 0);
    }

    static void DrawScore()
    {
        Console.SetCursorPosition(0, 0);
        Console.Write($"Score: {score}");
    }
}
