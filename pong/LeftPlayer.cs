using System;
using Raylib_cs;
using System.Numerics;


// Vänstra padeln ska placeras längst till vänster av fönstret
// Den skall styras av W knapp för att styr sig upp resp S knapp för att styras nedåt
// Viktigt att padeln kolliderar med bollen och inte försvinner över taken och under golvet.


public class LeftPlayer : Player
{
    public LeftPlayer()
    {
        rect.x = 0;
        upKey = KeyboardKey.KEY_W;
        downKey = KeyboardKey.KEY_S;


    }

}

