using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseFollow : MonoBehaviour
{
    private float offset = -0.8f;
    private Vector3 temPos;
    void Start()
    {
        transform.position  =  new Vector3(transform.position.x,transform.position.y,offset);
    }

    void Update()
    {
        temPos = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,Input.mousePosition.y,10));
        transform.position = new Vector3(temPos.x,2.899f,temPos.z);
    }
}
