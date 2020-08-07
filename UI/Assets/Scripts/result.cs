using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class result : MonoBehaviour
{
    public Text name;
    public Text age;
    public Text clas;
    public Text time;
    public Text score;
    public Text iq;

    int totalscore;
    string prevscene;
    // Start is called before the first frame update
    void Start()
    {
        prevscene = PlayerPrefs.GetString("SceneNumber");
        Debug.Log(prevscene);
        Debug.Log("score44"+scriptforD.score3);
        name.text = userinput.name;
        age.text = userinput.age;
        clas.text = userinput.clas;
        if (prevscene == "ObjectMathing")
        {
            time.text = Selector.temp;
            totalscore = CollosionDetectionandScore.score + CollosionDetectionandScore1.score + CollosionDetectionandScore2.score;
            score.text = totalscore.ToString();
            if(totalscore == 0 || totalscore < 20)
            {
                iq.text = "Low";
            }
            else if(totalscore>20 && Selector.timeforiq<60)
            {
                iq.text = "High";
            }
            else if((totalscore>10 || totalscore > 20) && (Selector.timeforiq>60 || Selector.timeforiq < 60) )
            {
                iq.text = "Average";
            }
            else if (totalscore < 10 || totalscore < 20 && Selector.timeforiq > 120)
            {
                iq.text = "Low";
            }

        }
        if(prevscene == "Counting")
        {
            time.text = RandomNumber.temp;
            totalscore = collisioncunting.count + collisioncunting.count1 + collisioncunting.count2 + collisioncunting.count3 + collisioncunting.count4 + collisioncunting.count5 + collisioncunting.count6 + collisioncunting.count7 + collisioncunting.count8;
            //Debug.Log("ttatata" + totalscore);
            if (totalscore == 0)
            {
                score.text = "0";
                iq.text = "Low";
            }
            else if (totalscore == RandomNumber.random_number && RandomNumber.timeforiq < 60)
            {
                score.text = "30";
                iq.text = "High";
            }
            else if(totalscore> RandomNumber.random_number || totalscore < RandomNumber.random_number && RandomNumber.timeforiq > 60 || RandomNumber.timeforiq < 60)
            {
                score.text = "20";
                iq.text = "Average";
            }
            
        }
        if (prevscene == "ObjectMathingUrdu")
        {
            time.text = SelectorUrdu1.temp;
            totalscore = collisionurdu1.score + collisionurdu2.score + collisionurdu3.score;
            score.text = totalscore.ToString();
            if (totalscore == 0 || totalscore<20)
            {
                iq.text = "Low";
            }
            else if (totalscore > 20 && SelectorUrdu1.timeforiq < 60)
            {
                iq.text = "High";
            }
            else if (totalscore > 10 || totalscore > 20 && SelectorUrdu1.timeforiq > 60 )
            {
                iq.text = "Average";
            }
            else if ((totalscore < 10 || totalscore > 10) && (SelectorUrdu1.timeforiq > 120 || SelectorUrdu1.timeforiq <60))
            {
                iq.text = "Low";
            }
            
        }
        if (prevscene == "CountingUrdu")
        {
            time.text = RandomNumberUrdu.temp;
            totalscore = collisioncunting.count + collisioncunting.count1 + collisioncunting.count2 + collisioncunting.count3 + collisioncunting.count4 + collisioncunting.count5 + collisioncunting.count6 + collisioncunting.count7 + collisioncunting.count8;
            Debug.Log("ttatata" + totalscore);
            if (totalscore == 0)
            {
                score.text = "0";
                iq.text = "Low";
            }
            else if (totalscore == RandomNumberUrdu.random_number && RandomNumberUrdu.timeforiq < 60)
            {
                score.text = "30";
                iq.text = "High";
            }
            else if ((totalscore > RandomNumberUrdu.random_number || totalscore < RandomNumberUrdu.random_number) && (RandomNumber.timeforiq > 60 || RandomNumber.timeforiq < 60))
            {
                score.text = "20";
                iq.text = "Average";
            }
        }
        if (prevscene == "ObjectReD")
        {
            time.text = scriptforD.temp;
            score.text = scriptforD.score3.ToString();
            totalscore = scriptforD.score3;
            if(totalscore > 30 && scriptforD.prevtime<60)
            {
                iq.text = "High";
            }
            else if ((totalscore > 20 || totalscore > 30) && (scriptforD.prevtime > 60 || scriptforD.prevtime < 60))
            {
                iq.text = "Average";
            }
            else if (totalscore < 20 )
            {
                iq.text = "Low";
            }
        }
        if (prevscene == "ObjectReDUrdu")
        {
            time.text = scriptforDurdu.temp;
            score.text = scriptforDurdu.score3.ToString();
            totalscore = scriptforDurdu.score3;
            if (totalscore > 30 && scriptforDurdu.prevtime < 60)
            {
                iq.text = "High";
            }
            else if (totalscore > 20 || totalscore > 30 && scriptforDurdu.prevtime > 60 || scriptforDurdu.prevtime < 60)
            {
                iq.text = "Average";
            }
            else if (totalscore < 20)
            {
                iq.text = "Low";
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
