using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombImp1 : MonoBehaviour
{
    public GameObject Bomb;
    public GameObject Player;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            Instantiate(Bomb, Player.transform.position, Quaternion.identity);
        }
    }
}