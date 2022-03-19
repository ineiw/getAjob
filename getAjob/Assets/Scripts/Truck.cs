using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    public WheelCollider [] wheelCols = new WheelCollider [4];
    public Transform [] wheelMeshes = new Transform [4];
    void setWheelsPos(){
        // 4 wheels pos,rot match mesh 4 wheels
        for (int i = 0; i < 4; i++)
        {
            Vector3 _pos = wheelMeshes[i].transform.position;
            Quaternion _quat = wheelMeshes[i].transform.rotation;

            wheelCols[i].GetWorldPose(out _pos,out _quat);

            wheelMeshes[i].transform.position = _pos+new Vector3(0,0.2f,0);
            wheelMeshes[i].transform.rotation = _quat;
            wheelMeshes[i].transform.Rotate(0,0,90);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        setWheelsPos();
    }
}
