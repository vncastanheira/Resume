using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Asteroid : MonoBehaviour
{
    // Trigger an event on death
    public UnityEvent OnDeath;

    void OnCollisionEnter(Collision collision)
    {
        OnDeath.Invoke();

        Destroy(gameObject);
    }
}
