using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeekAndDestroyBehaviour : MonoBehaviour
{
    // Fixed target
    Vector3 Target;

    [HideInInspector]
    public float Direction;
	
	public void Seek(Vector3 hit)
    {
        Target = new Vector3(hit.x, hit.y, transform.position.z);
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, Target, 0.2f);
        Direction = Target.x - transform.position.x;
    }

    void OnParticleCollision(GameObject other)
    {

    }
}
