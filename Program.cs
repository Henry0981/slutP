using Raylib_cs;
using slutP;

Raylib.InitWindow(800, 600, "BlACKBAbY");

Player player = new();

List<GameObject> gameObjects = new();

gameObjects.Add(player);

while (!Raylib.WindowShouldClose())
{
    foreach (var item in gameObjects)
    {
        item.Update();
    }

    Raylib.BeginDrawing();
    Raylib.ClearBackground(Color.Black);

    foreach (var item in gameObjects)
    {
        item.Draw();
    }
    Raylib.EndDrawing();
}

// STEG 1 = SPALTA UP VAD BESTÅR AV! FUNDERA VILKA OLIKA GREJER SOM FINNS MER. 
// ANVÄND PAINT
// STEG 2 = VILKA AV DEM HÄR SAKERNA ÄR VIKTIGTS

