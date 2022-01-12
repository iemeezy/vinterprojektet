using Raylib_cs;

Raylib.InitWindow(800, 600, "The title of my window");
Raylib.SetTargetFPS(60);

Texture2D smile= Raylib.LoadTexture("smile.png");

while (!Raylib.WindowShouldClose())
{
  Raylib.BeginDrawing();
  
  Raylib.ClearBackground(Color.WHITE);
  
  Raylib.DrawCircle(100,100,100,Color.MAGENTA);

  Raylib.DrawTexture(smile, 100,100, Color.WHITE);
  
  Raylib.EndDrawing();
}