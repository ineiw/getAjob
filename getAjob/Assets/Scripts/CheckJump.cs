using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckJump : MonoBehaviour
{
    public bool jumpFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.CompareTag("Road")){
            jumpFlag = true;
        }
    }
}
