using UnityEngine;
using System.Collections;

public class world_floor : MonoBehaviour {

    public int height = 32;
    public int width = 32;
    private string y;
    Sprite groundSprties = Resources.LoadAll<Sprite>("mudland");


    void Start ()
    {

        GameObject[,] groundPlane = new GameObject[height, width];

        for (int x = 0; x < width ; x++)
        {

            for (int y = 0; y < height; y++)
            {
                groundPlane[x, y] = new GameObject(string.Format("tile_{0}_{1}", x, y), typeof(SpriteRenderer));
                groundPlane[x,y] = GetComponent<SpriteRenderer>().sprite = 

            }

        }
    }
	

}
