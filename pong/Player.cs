
using System;
using Raylib_cs;
using System.Numerics;


// Playern ska fungera som ett virtuellt pingisrack.
// Racken eller paddeln ska vara två rektanglar som skall placeras längst till vänster/höger
// Bollen ska kunna studsa på den när bollen kolliderar.
// Paddlarna styrs av W eller upp-pil för att röra sig upp, S och ner-pil för att röra sig nedåt



public class Player
{

    public bool isItLeft;
    protected Rectangle rect;

    protected KeyboardKey upKey;
    protected KeyboardKey downKey;
    protected Vector2 movement;


    public Player()
    {
        rect = new Rectangle(790, 300, 10, 100);
        upKey = KeyboardKey.KEY_UP;
        downKey = KeyboardKey.KEY_DOWN;
    }

    public void Update()
    {
        movement.Y = 0;

        if (Raylib.IsKeyDown(upKey))
        {
            movement.Y = -4;
        }
        if (Raylib.IsKeyDown(downKey))
        {
            movement.Y = 4;
        }
        if (rect.y > 560)
        {
            movement.Y = 0;
        }



        rect.y += movement.Y;
    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.RED);

    }


    // public void Movement()
    // {
    //     // W,S


    //     // UPP, NER

    // // }
}