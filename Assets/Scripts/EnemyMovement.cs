using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{

    public List<GameObject> waypoints;
    Rigidbody2D rb;
    int waypointIndex = 0;
    public float speedBoost = 1f;
    public GameObject spawnPosition;

    // Start is called before the first frame update
    void Start()
    {

        transform.position = spawnPosition.transform.position;
        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        // G�r s� att fienden g�r till n�sta punkt
        Vector2 direction = waypoints[waypointIndex].transform.position - transform.position;
        rb.velocity = direction.normalized * speedBoost;

        // �ndrar rotation s� att fienden kollar �t h�llet n�sta punkt finns p�
        transform.rotation = Quaternion.LookRotation(Vector3.forward, direction);



        if (Vector2.Distance(waypoints[waypointIndex].transform.position, transform.position) < 0.3)
        {
            waypointIndex += 1;

            if (waypointIndex == waypoints.Count)
            {
                Destroy(gameObject);
            }
            

        }

    }
}
