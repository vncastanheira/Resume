using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class Bullet : MonoBehaviour
{
    Rigidbody rb;
    public float radius = 40.0f;
    public float power = 40.0f;
    int layer;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        layer = LayerMask.GetMask("Hostile");
    }

    void OnCollisionEnter(Collision collision)
    {
        Vector3 explosionPos = transform.position;
        // Explosion affects only hostiles
        Collider[] colliders = Physics.OverlapSphere(explosionPos, radius, layer);
        foreach (Collider hit in colliders)
        {
            Rigidbody rb = hit.GetComponent<Rigidbody>();

            if (rb != null)
                rb.AddExplosionForce(power, explosionPos, radius, 3.0F, ForceMode.Impulse);

        }
        Destroy(gameObject);
    }
}
