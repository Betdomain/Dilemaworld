using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HeavenorHell: MonoBehaviour
{
    public void MoveToScene(int sceneID)
    {
        
        if(Score.totalScore > 3)
        {
            SceneManager.LoadScene(7);
        }
        else
        {
            SceneManager.LoadScene(8);
        }
        

    }
}

