using UnityEngine;
using UnityEngine.Tilemaps;

public class ExampleGrid : MonoBehaviour
{
    [SerializeField]
    private Tilemap _tileMap;

    public GridMap<ExampleTile> GridMap;

    protected virtual void Awake()
    {
        _tileMap.CompressBounds();

        GridMap = new GridMap<ExampleTile>( _tileMap.size.x, _tileMap.size.y, _tileMap.cellSize, _tileMap.cellGap );

        for( int x = 0; x < GridMap.Width; x++ )
        {
            for( int y = 0; y < GridMap.Height; y++ )
            {
                GridMap[x, y] = new ExampleTile( GridMap.TileToWorldPosition( x, y ), new Vector3Int( x, y ) );

                _tileMap.SetTileFlags( GridMap[x, y].LocalPosition + _tileMap.origin, TileFlags.None );

            }
        }

        foreach( ExampleTile tile in GridMap.GetSurroundingTiles( 8, 8, 7, RadiusShape.CIRCLE ) )
        {
            _tileMap.SetColor( tile.LocalPosition + _tileMap.origin, Color.green );

        }

        foreach( ExampleTile tile in GridMap.GetSurroundingTiles( 26, 8, 7, RadiusShape.DIAMOND ) )
        {
            _tileMap.SetColor( tile.LocalPosition + _tileMap.origin, Color.yellow );

        }

        foreach( ExampleTile tile in GridMap.GetSurroundingTiles( 44, 8, 7, RadiusShape.SQUARE ) )
        {
            _tileMap.SetColor( tile.LocalPosition + _tileMap.origin, Color.blue );

        }

    }
}
