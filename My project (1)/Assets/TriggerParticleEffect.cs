using UnityEngine;

[RequireComponent(typeof(ParticleSystem), typeof(Collider))]
public class TriggerParticleEffect : MonoBehaviour
{
    private ParticleSystem ps; // Reference to the Particle System
    public int particleAmount = 10;

    private void Start()
    {
        ps = GetComponent<ParticleSystem>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.GetComponent<CharacterController>()) // Check if player triggered event
        {
            ps.Emit(particleAmount); // Emit the specified amount of particles
        }
    }
}
