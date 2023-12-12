// Author Drayff

using JengoEngine;

Circle circle1 = new Circle(new Vector2(4, 4), 5);
Circle circle2 = new Circle(new Vector2(5, 5), 5);

if (circle1.Update(circle2))
{
    Console.WriteLine("true");
}
else
{
    Console.WriteLine("false");
}


Log.Info("Test Info.");
Log.Debug("Test Debug.");
Log.Warning("Test Warning.");
Log.Error("Test Error.");
