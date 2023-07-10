using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NegativePoints : MonoBehaviour
{
    public void Button3Clicked()
    {
        Score.totalScore = Score.totalScore - 1;
        Debug.Log(Score.totalScore);
    }

}

