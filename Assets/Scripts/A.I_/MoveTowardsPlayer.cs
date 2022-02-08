using UnityEngine;

public class MoveTowardsPlayer : MonoBehaviour
{
    private Transform playerTransform;
    public float withinRange;
    public float speed;

    private void Start()
    {
        playerTransform = GameObject.Find("Player").GetComponent<Transform>();
    }

    private void Update()
    {
        AttackRange();
    }

    void AttackRange()
    {
        float dist = Vector3.Distance(playerTransform.position, transform.position);
        if (dist <= withinRange)
        {
            transform.position = Vector3.MoveTowards(transform.position, new Vector3(playerTransform.position.x, transform.position.y, transform.position.z), speed * Time.deltaTime);
        }
    }
}
