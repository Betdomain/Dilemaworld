using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Unity.VisualScripting;

public class DialogueINI : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] lines;
    public float textSpeed;
    public GameObject button1;
    

    private int index;



    // Start is called before the first frame update
    void Start()
    {
        textComponent.text = string.Empty;        
        StarDialogue();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(textComponent.text == lines[index])
            {
                NextLine();
            }
            else
            {
                StopAllCoroutines();
                textComponent.text = lines[index];
         
            }
        }    
    }

    void StarDialogue()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
        //Type each character 1 by 1
        foreach (char c in lines[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(textSpeed);
        }
    }

    public void enableButton()
    {
        button1.SetActive(true);
    }

    void NextLine()
    {
        if (index < lines.Length- 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine (TypeLine());

        }
        else
        {
            gameObject.SetActive(false);
            enableButton(); 
                                
        }
    }

}
