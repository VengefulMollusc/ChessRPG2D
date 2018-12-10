using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class BoardGenerator {

    public static Board GenerateBoard(int xSize = 8, int ySize = 8)
    {
        Tile[,] tiles = new Tile[xSize, ySize];

        return new Board(tiles);
    }
}

public class Board
{
    public Tile[,] tiles;

    public Board(Tile[,] tiles)
    {
        this.tiles = tiles;
    }
}

public enum Tile
{
    Plain,
    Empty
}
