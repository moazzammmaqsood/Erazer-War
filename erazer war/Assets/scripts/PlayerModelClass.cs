using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerModelClass : MonoBehaviour
{
    private int score=0;
    private int playerlevel=0;
    private int upgradelevel=0;
    private int noofweight=0;
    private int noofpower=0;

    public void setscore(int score){
        PlayerPrefs.SetInt("Score",score);

    }

    public void setplayerlevel(int level){
        PlayerPrefs.SetInt("playerlevel",level);
    }
    public void setupgradelevel(int upgradelevel){
        PlayerPrefs.SetInt("upgradelevel",upgradelevel);
    }
    public void setnoofweight(int noofweight){
        PlayerPrefs.SetInt("noofweight",noofweight);
    }
   public void setnoofpower(int noofpower){
        PlayerPrefs.SetInt("noofpower",noofpower);
   }

    public void setgems(int gems){
        PlayerPrefs.SetInt("gems",gems);
    }

   public int getscore(){
        return  PlayerPrefs.GetInt("Score",0);
   }
   public int getplayerlevel(){
        return   PlayerPrefs.GetInt("playerlevel",0);
   }
   public int getupgradelevel(){
       return     PlayerPrefs.GetInt("upgradelevel",1);
   }
   public int getnoofweight(){
       return PlayerPrefs.GetInt("noofweight",0);
   }
      public int getnoofpower(){
       return PlayerPrefs.GetInt("noofpower",0);
   }
    public int getgems(){
       return PlayerPrefs.GetInt("gems",0);
    }
}
