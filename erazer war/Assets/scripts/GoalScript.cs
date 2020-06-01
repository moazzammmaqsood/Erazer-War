using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GoalScript : MonoBehaviour
{
    // Start is called before the first frame update

    public Text goal;
    void OnTriggerEnter(){
        goal.text="Goal";
        Debug.Log("check goal");
    }
}
