using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using Raylib_cs;

namespace slutP;


public class Player : GameObject
{
    public float speed = 0.1f;
    public Vector2 pos = new Vector2();
    public Vector2 size = new Vector2(20, 20);

    public override void Update()
    {
        if (Raylib.IsKeyDown(KeyboardKey.D))
        {
            pos.X += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.A))
        {
            pos.X -= speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.S))
        {
            pos.Y += speed;
        }
        if (Raylib.IsKeyDown(KeyboardKey.W))
        {
            pos.Y -= speed;
        }
    }

    public override void Draw()
    {
        Rectangle characterBox = new Rectangle(pos.X, pos.Y, size.X, size.Y);
        Raylib.DrawRectangleRec(characterBox, Color.Red);
    }


}

public class GameObject
{
    public virtual void Update() { }
    public virtual void Draw() { }
}
