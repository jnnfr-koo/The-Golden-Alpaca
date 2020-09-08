using UnityEngine;

public interface IMovementService
{
    float GetAxisRaw(string axisName);
}

public class MovementService : IMovementService
{
    public float GetAxisRaw(string axisName)
    {
        return Input.GetAxisRaw(axisName);
    }
}
