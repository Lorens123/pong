using Raylib_cs;


Raylib.InitWindow(800, 600, "Ultimate Pong Game");

// Player p1 = new LeftPlayer();
// Player p2 = new RightPlayer();
Ball ball = new Ball();

while (!Raylib.WindowShouldClose())
{
    // p1.Update();
    // p2.Update();
    ball.Update();

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BLACK);

    Raylib.DrawCircle(100, 100, 100, Color.WHITE);

    // p1.Draw();
    // p2.Draw();
    ball.Draw();

    Raylib.EndDrawing();
}