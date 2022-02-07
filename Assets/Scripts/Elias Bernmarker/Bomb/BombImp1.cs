using UnityEngine;

public class BombImp1 : MonoBehaviour
{
    public GameObject Bomb;
    public GameObject Player;
    private float nextFire = 0;
    public float cooldownTime = 2;

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
                nextFire = Time.time + cooldownTime;
                Instantiate(Bomb, new Vector3(Player.transform.position.x + 1f, Player.transform.position.y, Player.transform.position.z), Quaternion.identity);
            }
        }
    }
}