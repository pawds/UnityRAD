using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VictimScript : MonoBehaviour
{
    Rigidbody rb;
    float jumpForce = 5;
    float explosionRadius = 5;
    float explosionStrength = 1000;

    internal void Bump(float explosionForce, Vector3 explosionPosition, float explosionRadius, float explosionStrength)
    {
        print("Bumped !!");
        Renderer renderer = GetComponent<Renderer>();
        renderer.material.color = Color.red;
        Rigidbody rb = GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.AddExplosionForce(explosionForce, explosionPosition, explosionRadius);
        }

    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }


    private void OnCollisionEnter(Collision collision)
    {
        VictimScript victimScript = collision.gameObject.GetComponent<VictimScript>();

        Collider[] allVictims = Physics.OverlapSphere(transform.position + Vector3.down, explosionRadius, (int)explosionStrength);

        foreach (Collider collider in allVictims)

        {
            VictimScript newVictim = collider.gameObject.GetComponent<VictimScript>();

            if (newVictim != null)
            {
                newVictim.Bump(explosionStrength,
                        transform.position + Vector3.down, explosionRadius, explosionStrength);

            }
        }
    }
}
