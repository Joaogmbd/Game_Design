using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{


    // Start is called before the first frame update
    void Start()
    {

    }
    public GameObject plane;
    private Vector3 offset = new Vector3(0, 5, -7);
    // Update is called once per frame
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
