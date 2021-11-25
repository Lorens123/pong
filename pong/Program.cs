using Raylib_cs;

Ball ball = new Ball(23, 25);
Raylib.InitWindow(800, 600, "Ultimate Pong Game");

// Player p1 = new LeftPlayer();
// Player p2 = new RightPlayer();


while (!Raylib.WindowShouldClose())
{
    // p1.Update();
    // p2.Update();
    ball.Update();

    Raylib.BeginDrawing();

    Raylib.ClearBackground(Color.BLACK);



    // p1.Draw();
    // p2.Draw();
    ball.Draw();

    Raylib.EndDrawing();
}