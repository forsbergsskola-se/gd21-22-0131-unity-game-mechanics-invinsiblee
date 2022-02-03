using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombImp2 : MonoBehaviour
{
    public GameObject Bomb;
    public GameObject Player;
    private float nextFire = 0;
    public float cooldownTime = 2;

    [Header("Charge")] 
    public float shootChargeTime = 1f;
    public float minimumShootForce;
    public float maximumShootForce;
    public float chargeProgress = 0f;
    public float chargeShot;

    void Start()
    {
        Player = GameObject.Find("Player");
    }

    void Update()
    {
        if (Time.time > nextFire)
        {
            if (Input.GetButton("Fire1"))
            {
                chargeProgress += Time.deltaTime * shootChargeTime;
            }
            if (Input.GetButtonUp("Fire1"))
            {
                Shoot();
            }
        }
    }

    void Shoot()
    {
        chargeShot = Mathf.Clamp(chargeProgress, minimumShootForce, maximumShootForce);
        chargeProgress = 200f;
        
        nextFire = Time.time + cooldownTime;

        var bombInstance = Instantiate(Bomb,
            new Vector3(Player.transform.position.x + 1, Player.transform.position.y, Player.transform.position.z),
            Quaternion.identity);
        bombInstance.GetComponent<Rigidbody>().AddForce(chargeShot,0,0);
    }
}