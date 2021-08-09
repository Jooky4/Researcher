using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckerObjects : MonoBehaviour
{
    void Update()
    {
        UpdateMouse();
    }




    void UpdateMouse()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit)
            {
                print(hit.collider.name);
            }
        }

    }





}
