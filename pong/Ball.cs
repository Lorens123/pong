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


    private Ball()
    {
        rect = new Rectangle(10, 10, 10, 10);
        Raylib.DrawRectangleRec(rect, Color.WHITE);

    }
    private void BeginningOfTheGame()
    {

    }
}