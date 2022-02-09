using UnityEngine;

public class Explosion : MonoBehaviour
{
    private GameObject enemy;
    private GameObject player;

    private void Start()
    {
        enemy = GameObject.FindWithTag("Enemy");
        player = GameObject.FindWithTag("Player");
    }

    private void OnTriggerEnter(Collider other)
    {
        //Playanimation
        if (other.gameObject.CompareTag("Enemy"))
        {
            enemy.GetComponent<Health>().currentHealth -= 50;
        }
        else if (other.gameObject.CompareTag("Player"))
        {
            player.GetComponent<Health>().currentHealth -= 50;
        }
        else if (other.CompareTag("Obstacle"))
        {
            //destroy
        }
    }
}
