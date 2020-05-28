using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private GameObject mousePointA;
    private GameObject mousePointB;
    private GameObject arrow;
    private GameObject circle;
    private float currentDistance;
    private float safeSpace;
    private float shootPower;
    private Vector3 shootDirection;
    private float maxDistance =3f;
    // Start is called before the first frame update
    void Awake()
    {
        mousePointA = GameObject.FindGameObjectWithTag("PointA");
        mousePointB = GameObject.FindGameObjectWithTag("PointB");
    }
    private void OnMouseDrag()
    {
        Debug.Log(mousePointA.transform.position.x);
        currentDistance = Vector3.Distance(mousePointA.transform.position, transform.position);
        if (currentDistance < maxDistance)
        {
            safeSpace = currentDistance;
        }else{
            safeSpace = maxDistance;
        }
        shootPower = Mathf.Abs(safeSpace)*10;
        Vector3 dimxy = mousePointA.transform.position - transform.position;
        float difference = dimxy.magnitude;
        mousePointB.transform.position = transform.position+((dimxy/difference)*currentDistance*-1);
        mousePointB.transform.position = new Vector3(mousePointB.transform.position.x,mousePointB.transform.position.y,-0.8f);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
