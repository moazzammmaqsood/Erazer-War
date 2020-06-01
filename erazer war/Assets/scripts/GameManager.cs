using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update

        public GameObject player ;
        public GameObject enemy ;
        public PlayerModelClass playerclass;
        public EnemyModelClass enemyclass;
        public Material[] skins;
        public bool playerturn;
        Renderer render;
    void Start()
    {
        player= GameObject.FindGameObjectWithTag("Player");
        enemy= GameObject.FindGameObjectWithTag("Enemy");
        render=player.GetComponent<Renderer>();
        render.enabled=true;
        render.sharedMaterial=getskin(1);
        playerturn=true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void gamestart(){



    }
    public void Restart(){

    }

    public void Pause(){

    }

    public void End(){

    }

    public  Material getskin(int i){

        return skins[i];
    }

}
