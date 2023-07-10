using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NeutralPoints : MonoBehaviour
{
    public void Button2Clicked()
    {
        Score.totalScore = Score.totalScore + 0;
        Debug.Log(Score.totalScore);
    }

}
