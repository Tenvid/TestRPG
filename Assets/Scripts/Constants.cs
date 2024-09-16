using UnityEngine;

public class Constants
{
    const float arrowX = 100;
    public const int CombatOptions = 3;
    public static readonly Vector3[] ArrowPositions = {
        new Vector3(arrowX, -105, 0),
        new Vector3(arrowX, -145, 0),
        new Vector3(arrowX, -190, 0),
    };
}
