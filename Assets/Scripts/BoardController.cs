using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoardController : MonoBehaviour
{

    private Board currentBoard;

	// Use this for initialization
	void Start ()
	{
        InitialiseBoard();
	}

    void InitialiseBoard()
    {
        currentBoard = BoardGenerator.GenerateBoard();

        for (int x = 0; x < currentBoard.tiles.GetLength(0); x++)
        {
            string line = "";
            for (int y = 0; y < currentBoard.tiles.GetLength(1); y++)
            {
                line += (x + y) % 2 == 0 ? "[#]" : "[_]";
            }
            Debug.Log(line);
        }
    }
}
