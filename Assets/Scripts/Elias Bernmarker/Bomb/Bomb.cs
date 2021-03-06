using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    private ParticleSystem.EmissionModule em;
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<ParticleSystem>().Play();
        em = GetComponent<ParticleSystem>().emission;
        StartCoroutine(BombStart());
    }
    IEnumerator BombStart()
    {
        yield return new WaitForSeconds(2);
        transform.GetChild(0).gameObject.SetActive(true);
        em.enabled = true;
        yield return new WaitForSeconds(0.2f);
        Destroy(gameObject);
    }
}