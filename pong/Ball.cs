using System.Numerics;
using System;
using Raylib_cs;
public class Ball
{
    // Bollen till pong ska vara fyrkantig i kvadrat form, 
    // Den ska kunna stunda på paddlarna och på vågrätta väggarna.
    // När bollen nuddar väggen på sidorna ger det 1 poäng. Max 5 för att vinna med.
    // I början av varje spel ska bollen åka till "random" håll antingen höger eller vänster. 
    private Rectangle rect;
    private Random generator = new Random();
    private Vector2 movement;


    public Ball(int x, int y)
    {
        rect = new Rectangle(x, y, 20, 20);
        // position = new Vector2(30, 30);
        movement = new Vector2(2f, 2f);




    }
    public void Update()
    {


        rect.x += movement.X;
        rect.y -= movement.Y;

        if (rect.y > 580 || rect.y < 0)
        {
            movement.Y = -movement.Y;
        }

        if (rect.x > 780 || rect.x < 0)
        {
            movement.X = -movement.X;
        }


    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.WHITE);

    }
}