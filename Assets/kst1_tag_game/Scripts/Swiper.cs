using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swiper : MonoBehaviour
{
    Vector2 start;
    Vector2 end;
    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            start = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        }

        if(Input.GetMouseButtonUp(0))
        {
            end = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            Vector2 distToPointer = end - start;

            string dir = "zero";

            if(Vector2.Dot(distToPointer, Vector2.left) > 0)
            {
                dir = "left";
            }
            else if (Vector2.Dot(distToPointer, Vector2.right) > 0)
            {
                dir = "right";
            }
            else if (Vector2.Dot(distToPointer, Vector2.up) > 0)
            {
                dir = "up";
            }
            else if (Vector2.Dot(distToPointer, Vector2.down) > 0)
            {
                dir = "down";
            }
        }
    }
}
