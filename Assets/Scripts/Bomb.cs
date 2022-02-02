using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private BoxCollider _boxCollider;

    private GameObject enemy;
    private GameObject player;
    
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemy = GameObject.FindWithTag("Enemy");
        _boxCollider = GetComponent<BoxCollider>();
        StartCoroutine(BombStart());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator BombStart()
    {
        yield return new WaitForSeconds(5);
        _boxCollider.enabled = _boxCollider.enabled;
        Destroy(gameObject);
    }

    private void OnTriggerEnter(Collider other)
    {
        //Playanimation
        if (other.CompareTag("Enemy"))
        {
            enemy.GetComponent<Health>().currentHealth -= 50;
        }
        /*else if (other.CompareTag("Player"))
        {
            player.GetComponent<Health>().currentHealth -= 50;
        }*/
        else if (other.CompareTag("Obstacle"))
        {
            //destroy
        }
    }
}