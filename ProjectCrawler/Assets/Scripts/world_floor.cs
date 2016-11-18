using UnityEngine;
using System.Collections;

public class world_floor : MonoBehaviour {

    public int height = 32;
    public int width = 32;


    void Start ()
    {

        int[,] groundPlane = new int[height, width];

        for (int i = 0; i < width ; i++)
        {

            for (int x = 0; x < height; i++)
            {
                groundPlane[i,x] = new GameObject("mudland_floor{0}{1}",typeof(SpriteRenderer){height}{width});
            }

        }
    }
	

}
