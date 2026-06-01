using UnityEngine;

public class WorldScrolling : MonoBehaviour
{
    [SerializeField] Transform playerTransform;
    Vector2Int currentTilePosition;
    [SerializeField] Vector2Int playerTilePosition;
    [SerializeField] float tileSize = 20f;
    GameObject[,] worldTiles;

    [SerializeField] int WorldTileHorizontalCount;
    [SerializeField] int WorldTileVerticalCount;

    private void Awake()
    {
        worldTiles = new GameObject[WorldTileHorizontalCount, WorldTileVerticalCount];
    }
    private void Update()
    {
        playerTilePosition.x = (int)(playerTransform.position.x / tileSize);
        playerTilePosition.y = (int)(playerTransform.position.y / tileSize);

    }

    public void Add(GameObject tileGameObject, Vector2Int tilePosition)
    {
        worldTiles[tilePosition.x, tilePosition.y] = tileGameObject;
    }
}
