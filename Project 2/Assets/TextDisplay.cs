using UnityEngine;
//using TMPro;
using UnityEngine.UI;
using System;

public class TextDisplay : MonoBehaviour
{
    public Text myText;
    private bool condition = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        myText = GetComponent<Text>();
        myText.gameObject.SetActive(false);
        
    }

    //Update is called once per frame
    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.name == "Victim")
        {
            myText.gameObject.SetActive(true);
        }
        else
        {
            myText.gameObject.SetActive(false);
        }
    }
}
