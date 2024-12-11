using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControlScript : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 5;
    float explosionRadius = 5;
    float explosionStrength = 3000;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))

        {
            rb.AddForce(Vector3.forward);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(jumpForce * Vector3.up, ForceMode.Impulse);

        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            rb.AddForce(Vector3.back);

        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddForce(Vector3.left);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddForce(Vector3.right);
        }
    }

   //// private void OnCollisionEnter(Collision collision)
   // //{
   //     VictimScript victimScript = collision.gameObject.GetComponent<VictimScript>();

   //     Collider[] allVictims = Physics.OverlapSphere(transform.position + Vector3.down, explosionRadius, (int)explosionStrength);

   //     foreach (Collider collider in allVictims)

   //     {
   //         VictimScript newVictim = collider.gameObject.GetComponent<VictimScript>();

   //         if (newVictim != null)
   //         {
   //             newVictim.Bump(explosionStrength,
   //                     transform.position + Vector3.down, explosionRadius, explosionStrength);

   //         }




   //         if (collision.gameObject.name == "Victim")
   //         {
   //             Rigidbody victimrb = collision.gameObject.GetComponent<Rigidbody>();
   //             if (victimrb != null)
   //             {
   //                 victimrb.AddExplosionForce(1000, transform.position + Vector3.down, 5);
   //             }
   //         }
   //     }
    }

