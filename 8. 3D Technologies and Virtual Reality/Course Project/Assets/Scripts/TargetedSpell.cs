using UnityEngine;

public class TargetedSpell : MonoBehaviour
{
    public float damage = 25f;
    public float lifeTime = 3f;
    public float damageDelay = 0.5f; // Time before damage is applied to sync with the VFX animation
    
    [Header("Visuals")]
    [Tooltip("Properly scales the complex particle systems (Sizes, Speeds, Radius) without breaking them!")]
    public float vfxScale = 1.0f;

    private Enemy target;

    private void Start()
    {
        // 1. Properly scale all particle systems inside this prefab
        if (vfxScale != 1.0f)
        {
            ScaleParticleSystems(vfxScale);
        }

        // Since we spawn the spell exactly on the target, we can grab the currently selected target
        target = SelectionManager.Instance.currentSelection;

        if (target != null)
        {
            Invoke(nameof(DealDamage), damageDelay);
        }
        
        // Destroy the spell VFX after lifeTime
        Destroy(gameObject, lifeTime);
    }

    private void DealDamage()
    {
        if (target != null)
        {
            target.TakeDamage(damage);
        }
    }

    private void ScaleParticleSystems(float scale)
    {
        // Simply scaling the Transform breaks complex VFX. We must scale the internal particle properties!
        transform.localScale = new Vector3(scale, scale, scale);

        ParticleSystem[] particles = GetComponentsInChildren<ParticleSystem>();
        foreach (ParticleSystem p in particles)
        {
            var main = p.main;
            main.startSizeMultiplier *= scale;
            main.startSpeedMultiplier *= scale;
            main.gravityModifierMultiplier *= scale;

            var shape = p.shape;
            if (shape.enabled)
            {
                shape.radius *= scale;
                shape.scale *= scale;
            }
        }
    }
}
