using UnityEngine;

public class WinScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.collider.name);
        if (collision.collider.name == "Victim")
        {
            print("cat wrangled");
            GetComponent<TextDisplay>();

        }
    }

    
    
        
            
        }
    

