using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{

    // private bool isPressed= false;
    float releaseTime=0.7f;
    public Touch touch;
    public float speedmod=0.01f;
    // public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
    
    }

int count=0;
    // Update is called once per frame
    void Update()
    {
        // Debug.Log("checkup");

    // if (Input.GInput.touchCount>0) 
    //  {
    //  Touch touch = Input.GetTouch(0); // get first touch since touch count is greater than zero
    //  count++;
        // Debug.Log("check");
    Plane plane=new Plane(Vector3.up,new Vector3(40.9f, 2.1f, -205.2f));
        // if(Input.GetMouseButtonDown(0)){
            if(Input.touchCount>0){
            // float x=(float) Input.mousePosition.x;

            touch=Input.GetTouch(0);
        GetComponent<SpringJoint>().spring=15;
            // float y=2.07
            count++;
            if(touch.phase==TouchPhase.Moved){
            Ray ray = Camera.main.ScreenPointToRay(touch.deltaPosition);

        Debug.Log("checkdown");


            transform.position=new Vector3(transform.position.x+touch.deltaPosition.x*speedmod,
                                        transform.position.y,
                                        transform.position.z+touch.deltaPosition.y*speedmod);



            // float enter = 0.0f;

            // if (plane.Raycast(ray, out enter))
            // {
            //     //Get the point that is clicked
            //     Vector3 hitPoint = ray.GetPoint(enter);

            //     //Move your cube GameObject to the point where you clicked
            //     // m_Cube.transform.position = hitPoint;
            //     transform.position = hitPoint;                  // Vector3.Lerp(transform.position, hitPoint, Time.deltaTime);

            // }

            }
            if(touch.phase==TouchPhase.Ended){
        StartCoroutine(Release());
        Debug.Log("checkup");

            }

        //  Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(x, 2.17f,Input.mousePosition.z));
        //   transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);

            // rb.position=Camera.main.ScreenToWorldPoint(touchedPos);

        }
  if(count>0){
        // StartCoroutine(Release());
            
        }



    //  if (touch.phase == TouchPhase.Stationary || touch.phase == TouchPhase.Moved) 
    //  {

    //      // get the touch position from the screen touch to world point
    //      Vector3 touchedPos = Camera.main.ScreenToWorldPoint(new Vector3(touch.position.x, touch.position.y, 10));
    //      // lerp and set the position of the current object to that of the touch, but smoothly over time.
    //       transform.position = Vector3.Lerp(transform.position, touchedPos, Time.deltaTime);
    //  }
    //  else if(count>1)
    //  {
    //     StartCoroutine(Release());
    //     count=0;

    //  }
//  }
        // if(isPressed){
        //     rb.position=Camera.main.ScreenToWorldPoint(Input.mousePosition);
        // }
        
    }
    //  void OnMouseDrag()
    //  {
    //      Vector3 mousePosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 2f);
    //      Vector3 objPosition = Camera.main.ScreenToWorldPoint(mousePosition);
 
    //      transform.position = objPosition;
    //  }
    IEnumerator Release(){
        yield return new WaitForSeconds(releaseTime);
        Debug.Log("checkrelease");

        GetComponent<SpringJoint>().spring=0;
    }

    // void OnMouseDown(){
    //     Debug.Log("check");
    //     isPressed=true;
    //     // rb.isKinematic=true;
    // }

    // void OnMouseUp(){
    //     isPressed=false;
    //     rb.isKinematic=false;
    //     StartCoroutine(Release());
    // }
}
