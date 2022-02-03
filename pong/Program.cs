using System.ComponentModel;
using Raylib_cs;
using System.Numerics;
Ball ball = new Ball(300, 300);

Player p1 = new Player();
Player p2 = new LeftPlayer();

// int poäng = 0;
// int poäng2 = 0;





// Collision collision = new Collision(p1, p2, ball

Raylib.InitWindow(800, 600, "Ultimate Pong Game");
Raylib.SetTargetFPS(60);

// Player p1 = new LeftPlayer();
// Player p2 = new RightPlayer();


while (!Raylib.WindowShouldClose())
{

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BLACK);



    ball.GetPoints();
    p1.Update();
    p2.Update();

    bool leftHit = p2.CollidesWith(ball.rect);
    bool rightHit = p1.CollidesWith(ball.rect);
    if (leftHit == true)
    {
        Console.WriteLine("hit!");
        ball.movement.X = -ball.movement.X;
    }
    if (rightHit == true)
    {

        ball.movement.X = -ball.movement.X;
    }
    ball.Update();

    p1.Draw();
    p2.Draw();
    ball.Draw();
    Raylib.EndDrawing();
}

