using System.Collections;
using UnityEngine;

public class AsteroidEmitter : MonoBehaviour
{
    [Header("Instances")]
    public GameObject[] asteroids;

    [Space(10f)]
    [Header("Options")]
    [Range(0, 200)]
    public float Radius;
    [Range(0, 50)]
    public float MaxDelay = 1;
    public float Life;

    float timer;

    void Start()
    {
        timer = MaxDelay;
    }

    void Update ()
    {
        StartCoroutine(Spawn());
	}

    private IEnumerator Spawn()
    {
        // randomly choose an asteroid from index
        var index = Random.Range(0, asteroids.Length);
        // random radius
        var r = Random.Range(-Radius, Radius);
        // set a spawn position
        var pos = new Vector3(Random.Range(0.0f, 1.0f) * r, Random.Range(0.0f, 1.0f) * r, transform.position.z);

        var asteroid = Instantiate(asteroids[index].gameObject, pos, transform.rotation);
        
        // add a trigger collider
        var col = asteroid.AddComponent<BoxCollider>();

        // add a rigidbody, remove gravity and apply force
        var rb = asteroid.AddComponent<Rigidbody>();
        rb.mass = 2;
        rb.useGravity = false;
        rb.AddForce(Vector3.back * 70, ForceMode.Impulse);

        // define a time to be destroyed
        Destroy(asteroid, Life);

        // delay the asteroid instantiating
        yield return new WaitForSeconds(MaxDelay);
    }

    void OnDrawGizmos()
    {
        Gizmos.DrawWireSphere(transform.position, Radius);
    }
}
