using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenRoad : MonoBehaviour
{
    int cnt = 4;
    public Transform truck;
    Transform genObject;
    Transform parentObj;
    // Start is called before the first frame update
    void Start()
    {
        genObject = gameObject.transform.parent.parent;
        parentObj = transform.parent;
    }

    // instantiiate road 
    void genRoad(){
        // get height and width 
        float _y = -Mathf.Sin(Mathf.Deg2Rad*parentObj.transform.rotation.eulerAngles.x)*parentObj.transform.localScale.z;
        float _z = Mathf.Cos(Mathf.Deg2Rad*parentObj.transform.rotation.eulerAngles.x)*parentObj.transform.localScale.z;
        // instantiate road on position
        // GameObject.Instantiate(gameObject.transform.parent.parent,new Vector3(transform.position.x,transform.position.y+_y+0.12f,transform.position.z+_z/2.0f),Quaternion.Euler(11f,0f,0f));
        GameObject.Instantiate(genObject,new Vector3(genObject.position.x,genObject.position.y+_y,genObject.position.z+_z),Quaternion.identity);
    }
    private void OnTriggerEnter(Collider other) {
        // if collision with Truck instantiate road
        if (other.gameObject.tag == "Truck"){
            genRoad();
        }
    }
}
