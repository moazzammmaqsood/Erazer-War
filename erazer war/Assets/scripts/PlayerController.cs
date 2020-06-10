using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class PlayerController : MonoBehaviour
{
	private GameObject mousePointA;
	private GameObject mousePointB;
	private GameObject arrow;
	private GameObject circle;
	float speed = 0;
	public GameManager manager;
	//calc distance
	private float currentdistance;
	public float maxdistance = 3f;
	private float safespace;
	private float shootpower;
	private Touch touch;
	private bool strike = false;
	private Vector3 shootDirection;

	// Start is called before the first frame update

	private void Awake()
	{
		mousePointA = GameObject.FindGameObjectWithTag("pointa");
		mousePointB = GameObject.FindGameObjectWithTag("pointb");
		arrow = GameObject.FindGameObjectWithTag("arrow");
		circle = GameObject.FindGameObjectWithTag("circle");
	}

	private void Update()
	{
		// Debug.Log("checkmouse");

		speed = GetComponent<Rigidbody>().velocity.magnitude;
		if (strike && speed < 0.5)
		{
			Vector3 dimxz = mousePointA.transform.position - transform.position;
			float difference = dimxz.magnitude;
			mousePointB.transform.position = transform.position + ((dimxz / difference) * currentdistance * -1);
			mousePointB.transform.position = new Vector3(mousePointB.transform.position.x, 0.13f, mousePointB.transform.position.z);
			strike = false;
			manager.playerturn = false;
			manager.touchflag=false;
		}
		else if (speed >= 0.5)
		{
			strike = true;
			manager.touchflag=true;

		}

		if (Input.touchCount > 0 && !manager.touchflag)
		{

			touch = Input.GetTouch(0);
			if (touch.phase == TouchPhase.Began)
			{
				//  Vector3 dimxz=mousePointA.transform.position-transform.position;
				// float difference=dimxz.magnitude;
				//  mousePointB.transform.position=transform.position+((dimxz/difference)* currentdistance*-1);
				// mousePointB.transform.position=new Vector3(mousePointB.transform.position.x,0.8f,mousePointB.transform.position.z);
			}
			if (touch.phase == TouchPhase.Moved)
			{
				if (manager.playerturn)
				{
					currentdistance = Vector3.Distance(mousePointA.transform.position, transform.position);
					if (currentdistance <= maxdistance)
					{
						safespace = currentdistance;
					}
					else
					{
						safespace = maxdistance;
					}

					shootpower = Mathf.Abs(safespace) * -10;

					Vector3 dimxz = mousePointA.transform.position - transform.position;
					float difference = dimxz.magnitude;
					mousePointB.transform.position = transform.position + ((dimxz / difference) * currentdistance * -1);
					mousePointB.transform.position = new Vector3(mousePointB.transform.position.x, 0.8f, mousePointB.transform.position.z);
					shootDirection = Vector3.Normalize(mousePointA.transform.position - transform.position);
					doarrowandcirclestuff();
				}
			}

			if (touch.phase == TouchPhase.Ended)
			{
				//   Debug.Log("check end");
				if (manager.playerturn)
				{
					Vector3 push = shootDirection * shootpower * -1;
					GetComponent<Rigidbody>().AddForce(push, ForceMode.Impulse);
					arrow.GetComponent<Renderer>().enabled = false;
					circle.GetComponent<Renderer>().enabled = false;

				}
				//    mousePointA.transform.position=new Vector3(transform.position.x,mousePointA.transform.position.y,transform.position.z);
				// mousePointB.transform.position=new Vector3(transform.position.x,mousePointB.transform.position.y,transform.position.z);
			}
		}


	}


	// Update is called once per frame
	// void Update()
	// {

	// }
	public void doarrowandcirclestuff()
	{
		arrow.GetComponent<Renderer>().enabled = true;
		circle.GetComponent<Renderer>().enabled = true;
		if (currentdistance <= maxdistance)
		{
			arrow.transform.position = new Vector3((2 * transform.position.x) - mousePointA.transform.position.x, 1.8f, (2 * transform.position.z) - mousePointA.transform.position.z);
		}
		else
		{
			Vector3 dimxz = mousePointA.transform.position - transform.position;
			float difference = dimxz.magnitude;

			arrow.transform.position = transform.position + ((dimxz / difference) * maxdistance * -1);
			arrow.transform.position = new Vector3(arrow.transform.position.x, 0.8f, arrow.transform.position.z);
		}

		circle.transform.position = transform.position + new Vector3(0, 0.04f, 0);
		Vector3 dir = mousePointA.transform.position - transform.position;
		float rot;
		if (Vector3.Angle(dir, transform.forward) > 90)
		{
			rot = Vector3.Angle(dir, transform.right);
		}
		else
		{
			rot = Vector3.Angle(dir, transform.right) * -1;
		}

		arrow.transform.eulerAngles = new Vector3(0, rot, 0);
		float scaleX = Mathf.Log(1 + safespace / 2, 2) * 2.2f;
		float scaleZ = Mathf.Log(1 + safespace / 2, 2) * 2.2f;
		arrow.transform.localScale = new Vector3(1 + scaleX, 0.001f, 1 + scaleZ);
		circle.transform.localScale = new Vector3(1 + scaleX, 0.001f, 1 + scaleZ);
	}

		void OnCollisionEnter(UnityEngine.Collision hit)
{

    string hitobject = hit.gameObject.tag;
    Debug.Log(hitobject);
}
}
