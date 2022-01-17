using Raylib_cs;
using System.Numerics;
Ball ball = new Ball(300, 300);

Player p1 = new Player();
Player p2 = new LeftPlayer();

Raylib.InitWindow(800, 600, "Ultimate Pong Game");
Raylib.SetTargetFPS(60);

// Player p1 = new LeftPlayer();
// Player p2 = new RightPlayer();


while (!Raylib.WindowShouldClose())
{




    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BLACK);
    p1.Update();
    p2.Update();




    ball.Update();



    p1.Draw();
    p2.Draw();
    ball.Draw();

    Raylib.EndDrawing();
}