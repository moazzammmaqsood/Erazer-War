using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseFollow : MonoBehaviour
{

    private float Offset=0.8f;
    private Vector3 tempPos;
    public float speedmod=0.01f;
    private Touch touch;
    GameObject player;
    // Start is called before the first frame update
    void Start()
    {
     transform.position=new Vector3(transform.position.x,Offset,transform.position.z);   
    player=GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        Plane plane=new Plane(Vector3.up,new Vector3(-0.087f, 0f, -9.978f));
     
       if(Input.touchCount>0){

             touch=Input.GetTouch(0);
        if(touch.phase==TouchPhase.Began){
                  transform.position=new Vector3(player.transform.position.x+touch.deltaPosition.x*speedmod,
                                        Offset,
                                        player.transform.position.z+touch.deltaPosition.y*speedmod);
        }

        if(touch.phase==TouchPhase.Moved){
        Ray ray = Camera.main.ScreenPointToRay(touch.deltaPosition);
        // Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, 0.5f,touch.position.y));

        // tempPos=Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x,transform.position.y,Input.mousePosition.z));
        // transform.position=new Vector3(tempPos.x,0.81f,tempPos.z); 
     transform.position=new Vector3(transform.position.x+touch.deltaPosition.x*speedmod,
                                        Offset,
                                        transform.position.z+touch.deltaPosition.y*speedmod);

            // if (plane.Raycast(ray, out Offset))
            // {
            //     //Get the point that is clicked
            //     Vector3 hitPoint = ray.GetPoint(Offset);

            //     //Move your cube GameObject to the point where you clicked
            //     // m_Cube.transform.position = hitPoint;
            //     transform.position = hitPoint;                  // Vector3.Lerp(transform.position, hitPoint, Time.deltaTime);

            // }
        }
    }
    }
}
