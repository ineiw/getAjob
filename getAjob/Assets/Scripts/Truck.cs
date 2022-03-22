using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Truck : MonoBehaviour
{
    Pool pool;
    public WheelCollider [] wheelCols = new WheelCollider [4];
    public Transform [] wheelMeshes = new Transform [4];
    Rigidbody rigi;
    float jumpPower = 900000;
    public CheckJump cj;
    // Start is called before the first frame update
    void Start()
    {
        rigi = gameObject.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float hor = Input.GetAxis("Horizontal");
        float space = Input.GetAxisRaw("Jump");
        if (cj.jumpFlag && space >0)
            jump();
        steering(hor);
        setWheelsPos();
    }
    public void Init(Pool _pool){
        pool = _pool;
    }
    GameObject getPoolObj(){
        GameObject road = null;
        road = pool.Dequeue();
        return road;
    }
    void steering(float hor){
        for (int i=2;i<4;i++){
            wheelCols[i].steerAngle = 45*hor;
        }
    }
    void jump(){
        rigi.AddForce(Vector3.up*jumpPower);
        Debug.Log(12);
        cj.jumpFlag = false;
    }
    void setWheelsPos(){
        // 4 wheels pos,rot match mesh 4 wheels
        for (int i = 0; i < 4; i++)
        {
            Vector3 _pos = wheelMeshes[i].transform.position;
            Quaternion _quat = wheelMeshes[i].transform.rotation;

            wheelCols[i].GetWorldPose(out _pos,out _quat);

            wheelMeshes[i].transform.position = _pos + new Vector3(0,0.2f,0);
            wheelMeshes[i].transform.rotation = _quat;
            wheelMeshes[i].transform.Rotate(0,0,90);
        }
    }
}
