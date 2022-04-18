using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matrix : MonoBehaviour
{
    [SerializeField] private Transform someObject;

    [SerializeField] private float rotationZ = 0;
    [SerializeField] private Vector3 scale = Vector3.one;
    

    private void Update()
    {
        someObject.position = new Vector3(4, 4, 0);
        var myMatrix = Matrix4x4.TRS(Vector3.zero, Quaternion.Euler(0f, 0f, rotationZ), scale);
        var newPos = myMatrix.MultiplyVector(someObject.position);
        someObject.position = newPos;
    }
}
