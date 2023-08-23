using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ExampleGrid : MonoBehaviour
{
    [SerializeField]
    private Tilemap _tileMap;

    private GridMap<ExampleTile> _gridMap;

    protected virtual void Awake()
    {
        _tileMap.CompressBounds();

        _gridMap = new GridMap<ExampleTile>( _tileMap.size.x, _tileMap.size.y, _tileMap.cellSize, _tileMap.cellGap );

        for( int x = 0; x < _gridMap.Width; x++ )
        {
            for( int y = 0; y < _gridMap.Height; y++ )
            {
                _gridMap[x, y] = new ExampleTile( _tileMap, new Vector2Int( x, y ) );

            }
        }

        foreach( ExampleTile tile in _gridMap.GetSurroundingTiles( 3, 3, 2, RadiusShape.DIAMOND ) )
        {
            _tileMap.SetTileFlags( (Vector3Int)tile.Position + _tileMap.origin, TileFlags.None );
            _tileMap.SetColor( (Vector3Int)tile.Position + _tileMap.origin, Color.green );


        }


    }

}
