using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShipMovement : MonoBehaviour
{

    public float speed = 10f;
    public float rotationSpeed = 100f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.Rotate(new Vector3(0,0,-1) * Time.deltaTime * rotationSpeed * horizontalInput);
        transform.Translate(Vector3.up * Time.deltaTime * speed * (1f + verticalInput));
    }
}
