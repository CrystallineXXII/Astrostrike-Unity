using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileController : MonoBehaviour
{
    public GameObject target;

    public float speed = 5f;
    public float rotationSpeed = 100f;
    public float lifeTime = 5f;
    private float distanceToTarget = 0f;
    private float lifeTimer = 0f;

    private Vector3 direction;



    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Shrike");
    }

    // Update is called once per frame
    void Update()
    {
        lifeTimer += Time.deltaTime;
        if (lifeTimer > lifeTime)
        {
            Destroy(gameObject);
        }

        direction = target.transform.position - transform.position;
        direction.Normalize();


        distanceToTarget = direction.magnitude;

        float targetRotation = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg - 90f;

        float step = rotationSpeed * Time.deltaTime;
        transform.rotation = Quaternion.RotateTowards(transform.rotation, Quaternion.Euler(0f, 0f, targetRotation), step);

        transform.position += transform.up * speed * Time.deltaTime;
    }
}
