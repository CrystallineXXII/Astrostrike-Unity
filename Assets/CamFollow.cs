using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform target;
    public float zoomSpeed = 1f;
    public float minZoom = 3f;
    public float maxZoom = 10f;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {   float scroll = Input.GetAxis("Mouse ScrollWheel");

        transform.position = new Vector3(target.position.x, target.position.y, -10);
        Camera.main.orthographicSize -= scroll * zoomSpeed;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, minZoom, maxZoom); 

    }
}
