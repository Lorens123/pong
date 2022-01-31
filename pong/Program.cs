using System.ComponentModel;
using Raylib_cs;
using System.Numerics;
Ball ball = new Ball(300, 300);

Player p1 = new Player();
Player p2 = new LeftPlayer();

int poäng = 0;
int poäng2 = 0;





// Collision collision = new Collision(p1, p2, ball

Raylib.InitWindow(800, 600, "Ultimate Pong Game");
Raylib.SetTargetFPS(60);

// Player p1 = new LeftPlayer();
// Player p2 = new RightPlayer();


while (!Raylib.WindowShouldClose())
{

    Raylib.BeginDrawing();
    Raylib.DrawText(poäng.ToString(), 370, 10, 30, Color.BLUE);
    Raylib.DrawText(":", 400, 10, 30, Color.PURPLE);
    Raylib.DrawText(poäng2.ToString(), 420, 10, 30, Color.RED);
    Raylib.ClearBackground(Color.BLACK);



    if (ball.rect.x < 0)
    {
        poäng2 += 1;
        ball.rect.x = Raylib.GetScreenWidth() / 2;
        ball.rect.y = Raylib.GetScreenHeight() / 2;
        // ball.IsMoving = false;
        ball.movement.X = -ball.movement.X;


    }
    if (ball.rect.x > Raylib.GetScreenWidth() - ball.rect.width)
    {
        poäng += 1;
        ball.rect.x = Raylib.GetScreenWidth() / 2;
        ball.rect.y = Raylib.GetScreenHeight() / 2;
        ball.movement.X = -ball.movement.X;
        // ball.IsMoving = false;
        // Console.WriteLine("Hit");
    }
    if (poäng2 >= 5)
    {
        Raylib.DrawText("RED HAS WON", 300, 300, 40, Color.PURPLE);
    }
    if (poäng >= 5)
    {
        Raylib.DrawText("BLUE HAS WON", 300, 300, 40, Color.PURPLE);
    }
    p1.Update();
    p2.Update();
    p1.Draw();
    p2.Draw();
    ball.Update();
    ball.Draw();
    Raylib.EndDrawing();
}

