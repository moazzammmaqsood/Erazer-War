using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyModelClass : MonoBehaviour
{
    private int score=0;
    private int playerlevel=0;
    private int upgradelevel=0;
    private int noofweight=0;
    private int noofpower=0;

    public void setscore(int score){
        PlayerPrefs.SetInt("enemyScore",score);

    }

    public void setplayerlevel(int level){
        PlayerPrefs.SetInt("enemylevel",level);
    }
    public void setupgradelevel(int upgradelevel){
        PlayerPrefs.SetInt("enemyupgradelevel",upgradelevel);
    }
    public void setnoofweight(int noofweight){
        PlayerPrefs.SetInt("enemynoofweight",noofweight);
    }
   public void setnoofpower(int noofpower){
        PlayerPrefs.SetInt("enemynoofpower",noofpower);
   }

    public void setgems(int gems){
        PlayerPrefs.SetInt("enemygems",gems);
    }

   public int getscore(){
        return  PlayerPrefs.GetInt("enemyScore",0);
   }
   public int getplayerlevel(){
        return   PlayerPrefs.GetInt("enemyplayerlevel",0);
   }
   public int getupgradelevel(){
       return     PlayerPrefs.GetInt("enemyupgradelevel",1);
   }
   public int getnoofweight(){
       return PlayerPrefs.GetInt("enemynoofweight",0);
   }
      public int getnoofpower(){
       return PlayerPrefs.GetInt("enemynoofpower",0);
   }
    public int getgems(){
       return PlayerPrefs.GetInt("enemygems",0);
    }
}
