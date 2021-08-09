using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{


    [SerializeField]
    [Header("Начальная позиция игрока")]
    private Transform beginCheckPoint;
    [SerializeField]
    private Transform endCheckPoint;
    [SerializeField]
    private float speedMove = 1;


    // Start is called before the first frame update
    void Start()
    {
        transform.position = beginCheckPoint.position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveObject(transform, endCheckPoint, speedMove);
        UpdateMouse();
    }

    void MoveObject(Transform beginPosition, Transform endPosition, float speedMoveObj)
    {
        float step = speedMoveObj * Time.deltaTime;
        transform.position = Vector3.MoveTowards(beginPosition.position, endPosition.position, step);

    }

    void UpdateMouse()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit2D hit = Physics2D.GetRayIntersection(ray, Mathf.Infinity);
            if (hit && hit.collider.tag == "CheckPoint" )
            {
                endCheckPoint = hit.collider.transform;
                print(hit.collider.name);
            }
        }

    }



}
