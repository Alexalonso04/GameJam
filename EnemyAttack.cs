using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyAttack : MonoBehaviour
{
    public float timeBetweenAttacks = 0.5f
    public int attackDamage = 10;

    Animator anim; //animator component
    GameObject player; //player GameObject
    PlayerHealth playerHealth; //player's health
    EnemyHealth enemyHealth; //enemy's health
    bool playerInRange; //the player is nearby 
    float timer;
}