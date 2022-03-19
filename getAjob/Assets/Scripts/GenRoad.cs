using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRoad : MonoBehaviour
{
    public Transform truck;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    // instantiiate road 
    void genRoad(){
        // get height and width 
        float _y = -Mathf.Sin(Mathf.Deg2Rad*11)*25f;
        float _z = Mathf.Cos(Mathf.Deg2Rad*11)*25f;
        // instantiate road on position
        GameObject.Instantiate(gameObject.transform.parent,new Vector3(transform.position.x,transform.position.y+_y+0.12f,transform.position.z+_z/2.0f),Quaternion.Euler(11f,0f,0f));
    }
    private void OnTriggerEnter(Collider other) {
        // if collision with Truck instantiate road
        if (other.gameObject.tag == "Truck"){
            genRoad();
        }
    }
}
