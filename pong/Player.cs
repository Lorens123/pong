
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
    private Vector2 movement;





    public Player()
    {
        rect = new Rectangle(790, 300, 10, 100);
        upKey = KeyboardKey.KEY_UP;
        downKey = KeyboardKey.KEY_DOWN;

    }

    public bool CollidesWith(Rectangle r)
    {
        return Raylib.CheckCollisionRecs(rect, r);
    }

    public void Update()
    {
        movement.Y = 0;

        if (Raylib.IsKeyDown(upKey))
        {
            movement.Y = -7;
        }
        if (Raylib.IsKeyDown(downKey))
        {
            movement.Y = 7;
        }

        rect.y += movement.Y;

        if (rect.y < 0)
        {
            rect.y -= movement.Y;
        }
        if (rect.y > 500)
        {
            rect.y -= movement.Y;
        }

    }

    public void Draw()
    {
        Raylib.DrawRectangleRec(rect, Color.RED);

        if (rect.x < 300)
        {
            Raylib.DrawRectangleRec(rect, Color.BLUE);
        }
    }

    public float GetYMovement()
    {
        return movement.Y;
    }


    // public void Movement()
    // {
    //     // W,S


    //     // UPP, NER

    // // }
}