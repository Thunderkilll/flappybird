using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    Vector3 range = new Vector3();
    // Start is called before the first frame update
    void Start()
    {
        range = transform.position - player.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(range.x + player.position.x,
            transform.position.y, range.z + player.position.z);
    }
}
