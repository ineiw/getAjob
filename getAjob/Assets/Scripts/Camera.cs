using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform truckPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // camera move with truckpos , not rotation
        transform.position = new Vector3(27,truckPos.position.y+20,truckPos.position.z+34);
    }
}
