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
    private Vector2 position;


    public Ball(int x, int y)
    {
        rect = new Rectangle(x, y, 20, 20);

    }
    public void Update()
    {
        position = new Vector2(30, 30);
        movement = new Vector2(0.5f, 0.5f);
        position += movement;
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.WHITE);

    }
}