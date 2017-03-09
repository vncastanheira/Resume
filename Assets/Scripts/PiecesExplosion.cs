using UnityEngine;

[RequireComponent(typeof(MeshRenderer))]
public class PiecesExplosion : MonoBehaviour
{
    public ParticleSystem DebrisEffect;
    public ParticleSystem ExplosionEffect;
	
    public void Trigger()
    {
        if (DebrisEffect != null)
        {
            // Create a particle effect that spawns several debris
            // The debris will receive the material from the object that spawned them
            var debris = Instantiate(DebrisEffect, transform.position, DebrisEffect.transform.rotation);
            var renderer = debris.GetComponent<ParticleSystemRenderer>();
            var meshRenderer = GetComponent<MeshRenderer>();
            renderer.material = meshRenderer.material;
            Destroy(debris.gameObject, 5.0f);
        }

        if(ExplosionEffect != null)
        {
            // Create a particle explosion effect
            var explosion = Instantiate(ExplosionEffect, transform.position, transform.rotation);
            Destroy(explosion.gameObject, 5.0f);
        }
    }
}
