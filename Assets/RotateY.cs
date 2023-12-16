using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateY : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 currentRotation = gameObject.transform.rotation.eulerAngles;
        gameObject.transform.rotation = Quaternion.Euler(currentRotation.x, currentRotation.y + 1.0f, currentRotation.z);
    }
}
