using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public class Position
{
    [SerializeField]
    public string size;
    public int width;
    [SerializeField]
    public int height;
    [SerializeField]
    public int x;
    [SerializeField]
    public int y;



    public Position(string size, int x, int y)
    {
        this.size = size;
		Vector2Int newSize = GetSceneSize(size);
        width = newSize.x;
        height = newSize.y;
        this.x = x;
        this.y = y;
    }

	public Vector2Int GetSceneSize(string size) {
		if (size == "small") {
			return new Vector2Int(30, 40);
		}
		else if (size == "medium") {
			return new Vector2Int(45, 25);
		}
		else if (size == "large") {
			return new Vector2Int(80, 20);
		}
		else {
			return Vector2Int.zero;
		}
	}
}
