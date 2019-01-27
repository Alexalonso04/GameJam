using UnityEngine;

using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour

{
    public Slider HealthBar;
    public float Health = 100;
    private float _currentHealth;
    bool isDead;   
    Animator anim;                              // Reference to the animator.
    AudioSource enemyAudio;                     // Reference to the audio source.
    ParticleSystem hitParticles;                // Reference to the particle system that plays when the enemy is damaged.
    CapsuleCollider capsuleCollider;  
    void Start ()
    {
        _currentHealth = Health;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        HealthBar.value = _currentHealth;
    }

    
    void Death ()
    {
        // The enemy is dead.
        if(_currentHealth == 0)
        {
            isDead = true;
            anim.SetTrigger("Dead");
        }
    }


}