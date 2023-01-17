using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFirstPerson : MonoBehaviour
{
    public GameObject obj;
    public Vector3 offset;
    void Update()
    {
        transform.position = obj.transform.position + offset;
        transform.rotation = obj.transform.rotation;
    }
}
