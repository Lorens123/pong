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


    public Ball(int x, int y)
    {
        rect = new Rectangle(x, y, 20, 20);
        // position = new Vector2(30, 30);
        movement = new Vector2(5f, 5f);




    }
    public void Update()
    {
        // movement = 0;

        if (rect.y < 0 || rect.y > 580)
        {
            movement.Y = -movement.Y;

        }

        if (rect.x < 0 || rect.x > 780)
        {
            movement.X = -movement.X;

        }




        rect.x += movement.X;
        rect.y -= movement.Y;

    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.WHITE);

    }
}