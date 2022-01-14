using System.Numerics;
using System;
using Raylib_cs;


// Väggarnas funktion är att bollen skall kunna studsa på den.
// Väggarna ska placeras horisontellt högst upp/längst ner på raylib fönstret.
// Väggen ska vara vit för att den skall synas.
public class Wall
{
   private Rectangle wallRect;
   

   public Wall (int x, int y)
   {
       wallRect = new Rectangle(x, y, 800, 10);
       
   }


   public void WallDraw()
   {
       Raylib.DrawRectangleRec(wallRect, Color.WHITE);
   }



}