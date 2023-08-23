using UnityEngine;
using UnityEngine.Tilemaps;

public class ExampleTile
{
    public readonly Tilemap Tilemap;

    public readonly Vector2Int Position;

    public ExampleTile( Tilemap tileMap, Vector2Int position )
    {
        this.Tilemap    = tileMap;
        this.Position   = position;

    }

}
