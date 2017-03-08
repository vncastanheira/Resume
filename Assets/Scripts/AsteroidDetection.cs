using UnityEngine;
using UnityEngine.Events;

public class AsteroidDetection : MonoBehaviour
{
    public OnHitEvent onHit;

    void OnTriggerStay(Collider other)
    {
        onHit.Invoke(other.transform.position);
    }

}

[System.Serializable]
public class OnHitEvent : UnityEvent<Vector3> { }
