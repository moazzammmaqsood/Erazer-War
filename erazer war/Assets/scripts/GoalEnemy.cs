using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalEnemy : MonoBehaviour
{
    // Start is called before the first frame update

	public GameManager gameManager;

	void OnTriggerEnter(Collider collider){
		Debug.Log("Called"+collider.tag);
		if (collider.tag == "Enemy")
		{
			Debug.Log("Enemy scored");
			gameManager.increamentEnemyScore();
		}
    }
}
