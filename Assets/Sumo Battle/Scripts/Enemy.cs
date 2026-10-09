using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    private Rigidbody enemyRb;
    private GameObject player;

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // FixedUpdate runs at a fixed rate, so the push no longer depends on the frame rate
    void FixedUpdate()
    {
        Vector3 lookDirection = (player.transform.position - transform.position).normalized;
        enemyRb.AddForce(lookDirection * speed);
    }

    void Update()
    {
        // Knocked off the island
        if (transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}