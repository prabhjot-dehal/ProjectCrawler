using UnityEngine;
using System.Collections.Generic;

public class world_floor : MonoBehaviour {
    Dictionary<string, Sprite> groundSprites;
    
    public int height = 32;
    public int width = 32;
    private string y;

    void Start ()
    {

        Sprite[] sprites = Resources.LoadAll<Sprite>("Mudland_floor");

        groundSprites = new Dictionary<string, Sprite>();

        foreach (Sprite sprite in sprites)
        {
            Debug.Log(sprite.name);

            groundSprites.Add(sprite.name, sprite);
        }


        GameObject[,] groundPlane = new GameObject[height, width];

        for (int x = 0; x < width ; x++)
        {

            for (int y = 0; y < height; y++)
            {
                groundPlane[x, y] = new GameObject(string.Format("tile_{0}_{1}", x, y), typeof(SpriteRenderer));
                groundPlane[x, y].GetComponent<SpriteRenderer>().sprite = groundSprites["Mudland_floor_" + ((8 * (7 - (y % 8))) + (x % 8)).ToString()];

                groundPlane[x,y].transform.position = new Vector2(x, y);
            }

        }
    }
	

}
