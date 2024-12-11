using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 1000F;

    float jumpForce = 5;
    float explosionRadius = 5;
    float explosionStrength = 3000;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
        {

    }

        // Update is called once per frame
        void Update()
        {

        }

    private void OnCollisionEnter(Collision collision)
    {
        print("jhgojyg");
       // VictimScript victimScript = collision.gameObject.GetComponent<VictimScript>();

        Collider[] allVictims = Physics.OverlapSphere(transform.position , explosionRadius );

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
