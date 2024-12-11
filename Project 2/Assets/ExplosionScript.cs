using UnityEngine;
using System.Collections;

public class ExplosionScript : MonoBehaviour
{
    public float radius = 5.0F;
    public float power = 100F;


 

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
        Vector3 explosionPos = transform.position;
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 100F);
        }
    }

}
