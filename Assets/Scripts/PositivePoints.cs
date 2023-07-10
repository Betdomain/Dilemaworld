using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PositivePoints : MonoBehaviour
{

    public void Button1Clicked()
    {
        Score.totalScore = Score.totalScore + 1;
        Debug.Log(Score.totalScore);
    
    }
    
}
