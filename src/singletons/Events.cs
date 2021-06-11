using System;
using Godot;

public class Events : Node
{

    public static event Action startGame;
    public static event Action endGame;
    public static event Action<int> levelCompleted;
    public static event Action nextLevelPressed;
    public static event Action gemCollected;


    ////////////////////////////////////

    public static void PublishGemCollected() => gemCollected?.Invoke();
    public static void PublishStartGame() => startGame?.Invoke();
    public static void PublishEndGame() => endGame?.Invoke();
    public static void PublishLevelCompleted(int stars) => levelCompleted?.Invoke(stars);
    public static void PublishNextLevelPressed() => nextLevelPressed?.Invoke();
}