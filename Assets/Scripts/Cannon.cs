using UnityEngine;
using UnityEngine.Events;

public class Cannon : MonoBehaviour
{
    public UnityEvent onFire;

    public Transform Bullet;
    public float impulse;
    [Range(0, 2)]
    public float RechargeTime;

    float timer;

    void Start()
    {
        timer = RechargeTime;
    }

    void Update()
    {
        timer -= Time.deltaTime;
    }

    public void Shoot()
    {
        if (timer <= 0)
        {
            var b = Instantiate(Bullet, transform.position, transform.rotation);
            var rb = b.GetComponent<Rigidbody>();
            if (rb == null)
            {
                Debug.LogError("Bullet does not contain a Rigidbody Component");
                Debug.Break();
            }

            rb.AddForce(Vector3.forward * impulse, ForceMode.Impulse);
            onFire.Invoke();

            timer = RechargeTime;
        }

    }
}
