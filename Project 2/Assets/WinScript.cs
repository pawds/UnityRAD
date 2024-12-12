using UnityEngine;

public class WinScript : MonoBehaviour
{

    TextDisplay textDisplay;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        textDisplay = FindObjectOfType<TextDisplay>();
        textDisplay.turnOff();
        if (textDisplay != null)
            print("I found the text ");
        else
            print("No Text!!");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Return))
            textDisplay.turnOn();
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "Victim")
        {
            print("cat wrangled");
            textDisplay.turnOn();

        }
    }

    
    
        
            
        }
    

