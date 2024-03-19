using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Tilemaps;
//using BuildConstructor;

class Chunk
{
    public Vector2Int Position;
    public string Tayp;

    public Chunk(int x, int y , string Tayp)
    {
        Position = new Vector2Int(x, y);
    }
}
public class WolrdManager : MonoBehaviour
{
    List<Chunk> worldCell = new List<Chunk>();

    Vector2Int startPoint = new Vector2Int(0, 0);
    Vector2Int endPoint = new Vector2Int(0, 5);

    public void Start()
    {
        worldCell.Add(new Chunk(1, 1, "HightGround"));
        worldCell.Add(new Chunk(2, 1, "Platform"));
        worldCell.Add(new Chunk(3, 1, "Ground"));
        worldCell.Add(new Chunk(4, 4, "Extractor"));
        FindPath(startPoint, endPoint);

    }

    void FindPath(Vector2Int x, Vrctor2Int y)
    {

    }
}





