using UnityEngine;
using System.Collections;

public class AIController : MonoBehaviour
{

    private Animator animator;
    private GameObject player;
    private bool collidedWithPlayer;

    void Awake()
    {
    player = GameObject.FindGameObjectWithTag("Player");
     animator = GetComponent<Animator>();
    }

 

    void OnTriggerEnter(Collider other)

    {

        if (other.gameObject == player)

        {

            animator.SetBool("IsNearPlayer", true);

        }

        print("enter trigger with player");

    }
 

    void OnCollisionEnter(Collision other)

    {

        if (other.gameObject == player)

        {

            collidedWithPlayer = true;

        }

        print("enter collided with player");

    }

 

    void OnCollisionExit(Collision other)

    {

        if (other.gameObject == player)

        {

            collidedWithPlayer = false;

        }

        print("exit collided with player");

    }

 

    void OnTriggerExit(Collider other)

    {

        if (other.gameObject == player)

        {

            animator.SetBool("IsNearPlayer", false);

        }

        print("exit trigger with player");

    }

    void Attack()

    {

        if (collidedWithPlayer)

        {

            print("player has been hit");

        }

    }

}
