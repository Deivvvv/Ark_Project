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

    public Chunk(Vector2Int x, string tayp)
    {
        Position = x;
        Tayp = tayp;

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
    Chunk GetChunk(Vector2Int v,int i)
    {
        switch (i)
        {
            case (0):
                v += new Vector2Int(0, 1);
                break;
            case (1):
                v += new Vector2Int(1, 0);
                break;
            case (2):
                v += new Vector2Int(0, -1);
                break;
            case (3):
                v += new Vector2Int(-1, 0);
                break;
        }


        i = worldCell.FindIndex(x => x.Position == v);
        if (i != -1)
            return worldCell[i];

        return AddChunk(v);
    }
    Chunk AddChunk( Vector2Int v)
    {
        Chunk chunk = new Chunk(v, "Block");
        worldCell.Add(chunk);
        return chunk;
    }

    void FindPath(Vector2Int x, Vrctor2Int y)
    {
        
    }
}

class PathCaseMain
{
    public int Id;
    public string Tayp;
    public Vector2Int Position;
    public int cor;//x,y,-x,-y
    public int Length;

}


class IndysryPath
{

}




