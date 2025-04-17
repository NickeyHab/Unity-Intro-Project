using System;
using System.Collections.Generic;
using UnityEngine;

public class Programming101 : MonoBehaviour
{
    private int number;
    private float otherNumber;
    private string[] texts;
    private List<string> otherTexts;
    private Vector3 position = new Vector3(1,2,3);
   
    void Start()
    {
        number = 5;
        otherNumber = 7.25f;
        texts = new string[2] {"test", "text"};
        {
            Debug.Log(texts);
        }

        otherTexts = new List<string>(){"test2", "text2"};
        otherTexts.Add("yes");

        foreach(string text in otherTexts){
            Debug.Log(text);
        }

        for(int index = 0; index < otherTexts.Count; index++)
        {
            
        }

        int number2 = 1 + 2;
        number2++;
        number2+=1;
        Debug.Log(number2);

        if (number2 > 5)
        {
            Debug.Log("bigger");
        } 
        else if (number2 == 5)
        {
            Debug.Log("equal");
        }
        else 
        {
            Debug.Log("not bigger");
        }
    }

    void Update()
    {
    }
}
