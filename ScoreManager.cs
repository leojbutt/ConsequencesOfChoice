using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCounter : MonoBehaviour
{

    public int scoreLeft;
    public int scoreRight;
    public Text countTextL;
    public Text countTextR;

    //Define two scores and display on screen
	  void Start ()
    {
        scoreLeft = 0;
        scoreRight = 0;
        setCountText();
    }

    //Add to first score
    public void addLeft ()
    {
        scoreLeft++;
	  }

    //Add to second score
    public void addRight()
    {
        scoreRight++;
    }

    //Display scores on screen
    public void setCountText()
    {
        countTextL.text = "Count Left:" + scoreLeft.ToString();
        countTextR.text = "Count Right:" + scoreRight.ToString();
    }
}
