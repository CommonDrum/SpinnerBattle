using UnityEngine;
using UnityEngine.Events;

public static class GameEvents
{
    public static UnityEvent<float> OnSpeedChanged = new UnityEvent<float>();
}
