using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class LevelSceneController : MonoBehaviour
{

    Button wp1,wp2,wp3,wp4,wp5;
    int playerselect=0;
    int score=0;
    int playerlevel=0;
    int upgradelevel=0;
    int noofweight=0;
    int noofpower=0;
    float weightval=0;
    float powerval=0;
    int gems=0;
    public PlayerModelClass player;
    public Slider weightslider;
    public Slider powerslider;
    
    public Text scoretext;
    public Text upgradetext;
    public Text gemtext;
    public Text weightcount;
    public Text powercount;
    // Start is called before the first frame update
    void Start()
    {

        player.setscore(2000);
        player.setgems(6);
        updatescore();
        updatespinners();
        updategems();
        updatepowerupcount();
         }

    // Update is called once per frame
    void Update()
    {
        
    }
    void updatescore(){
        scoretext.text=player.getscore().ToString();
    }


    public void buyupgrade(){

        int tempscore=player.getscore();
        int tempuplevel=player.getupgradelevel();

        int buyupgradeval=tempuplevel*150;


        if(tempscore>buyupgradeval){

            tempscore=tempscore-buyupgradeval;
            tempuplevel=tempuplevel+1;
            player.setscore(tempscore);
            player.setupgradelevel(tempuplevel);
        }

    updatespinners();
    updatescore();
        
        
    }

     void updatespinners(){
        int tempuplevel=player.getupgradelevel();         
        int buyupgradeval=tempuplevel*150;
        upgradetext.text="Upgrade for "+ buyupgradeval.ToString();
        int temp=player.getupgradelevel();

            weightval=temp*5;
            powerval=temp*5;
            weightslider.value=weightval;
            powerslider.value=powerval;

     }


    void updategems(){
        gems=player.getgems();
        gemtext.text=gems.ToString();
    }

    void updatepowerupcount(){
        noofpower=player.getnoofpower();
        noofweight=player.getnoofweight();

        weightcount.text=noofweight.ToString();
        powercount.text=noofpower.ToString();


    }
    public void buypowerupsweight(){
        gems=player.getgems();
        if(gems>=2){
            gems=gems-2;
            noofweight=noofweight+1;
            player.setgems(gems);
            player.setnoofweight(noofweight);

            updategems();
            updatepowerupcount();
        }

    }
    public void buypoweruppower(){
        gems=player.getgems();
        if(gems>=2){
            gems=gems-2;
            noofpower=noofpower+1;
            player.setgems(gems);
            player.setnoofpower(noofpower);

            updategems();
            updatepowerupcount();
        }

    }
}
