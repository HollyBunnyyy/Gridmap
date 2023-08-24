using UnityEngine;

public class ExampleTile
{
    public readonly Vector3 WorldPosition;
    public readonly Vector3Int LocalPosition;

    public ExampleTile( Vector3 worldPosition, Vector3Int localPosition )
    {
        this.WorldPosition = worldPosition;
        this.LocalPosition = localPosition;

    }

}
