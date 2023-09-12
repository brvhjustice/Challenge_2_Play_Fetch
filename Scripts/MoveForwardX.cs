using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;
    

    // Update is called once per frame
    void Update()
    {
        //transform.position = new Vector3(0, 0, 0);
      //Vector3 spawnPos = Vector3();
        transform.Translate(Vector3.forward * speed * Time.deltaTime );
        
    }
}
