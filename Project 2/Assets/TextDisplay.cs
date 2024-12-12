using UnityEngine;
//using TMPro;
using UnityEngine.UI;
using System;

public class TextDisplay : MonoBehaviour
{
    Text myText;
    private bool condition = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myText = GetComponent<Text>();
    
        myText.text = "hfghfghgfhgf";
        
    }

    //Update is called once per frame


    internal void turnOn()
    {
        print("bong");
   
        myText.text = "Cat Wrangled!";
    }

    internal void turnOff()
    {
        myText.text = "Hello";
    }
}
