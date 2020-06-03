using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalPlayer : MonoBehaviour
{
	public GameManager gameManager;

	void OnTriggerEnter(Collider collider)
	{
		Debug.Log("Called" + collider.tag);
		if (collider.tag == "Player")
		{
			Debug.Log("Player scored");
			gameManager.increamentPlayerScore();
		}
	}
}
