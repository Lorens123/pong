using System.Numerics;
using System;
using Raylib_cs;
public class Ball
{
    // Bollen till pong ska vara fyrkantig i kvadrat form, 
    // Den ska kunna stunda på paddlarna och på vågrätta väggarna.
    // När bollen nuddar väggen på sidorna ger det 1 poäng. Max 5 för att vinna med.
    // I början av varje spel ska bollen åka till "random" håll antingen höger eller vänster. 
    public Rectangle rect;
    private Random generator = new Random();
    public Vector2 movement;
    public bool IsMoving;
    private int poäng = 0;
    private int poäng2 = 0;


    public Ball(int x, int y)
    {
        rect = new Rectangle(x, y, 20, 20);
        movement = new Vector2(7f, 7f);

    }
    public void GetPoints()
    {
        Raylib.DrawText(poäng.ToString(), 370, 10, 30, Color.BLUE);
        Raylib.DrawText(":", 400, 10, 30, Color.PURPLE);
        Raylib.DrawText(poäng2.ToString(), 420, 10, 30, Color.RED);
        if (rect.x < 0)
        {
            poäng2 += 1;
            movement.X = -movement.X;
            Reset();
        }
        if (rect.x > Raylib.GetScreenWidth() - rect.width)
        {
            poäng += 1;
            movement.X = -movement.X;
            Reset();

        }
        if (poäng2 >= 5)
        {
            Raylib.DrawText("RED HAS WON! GAME OVER!", 100, 200, 40, Color.RED);
            movement.X = 0;
            movement.Y = 0;
        }
        if (poäng >= 5)
        {
            Raylib.DrawText("BLUE HAS WON! GAME OVER!", 100, 200, 40, Color.BLUE);
            movement.X = 0;
            movement.Y = 0;
        }
    }

    public void Reset()
    {
        rect.x = Raylib.GetScreenWidth() / 2;
        rect.y = Raylib.GetScreenHeight() / 2;

        movement = new Vector2();
        movement.X = 5;
        // movement.Y = generator.Next(-8, 8);
        movement.Y = 0;
    }

    public void Update()
    {
        // movement = 0;

        if (rect.y < 0 || rect.y > 580)
        {
            movement.Y = -movement.Y;

        }

        // if (rect.x < 0 || rect.x > 780)
        // {
        //     movement.X = -movement.X;

        // }

        rect.x += movement.X;
        rect.y += movement.Y;

    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.PURPLE);

    }
}