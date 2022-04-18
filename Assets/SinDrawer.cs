using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SinDrawer : MonoBehaviour
{
    [SerializeField] private GameObject prefab;

    [SerializeField] private int nSamples = 100;

    [SerializeField][Range(0,0.03f)] private float separationFactor=0.01f;

    [SerializeField][Range(0,10)] private float transformacionEscala = 1, transformacionExpandir=1;

    [SerializeField] [Range(-10, 10)] private float transformacionPos = 0;

    private void Start()
    {
        for (int i = 0; i < nSamples; i++)
        {
            var child = Instantiate(prefab, transform);
        }
        
    }

    private void Update()
    {
        
        GraphSin();
        transformacionPos = Time.time;
    }

    void GraphSin()
    {
        int i = 0;
        foreach (Transform child in transform)
        {
            float x = i * separationFactor;
            child.localPosition = new Vector3(x, transformacionEscala * (Mathf.Sin(x * transformacionExpandir + transformacionPos)), 0);
            ++i;
        }
    }

    void GraphNoise()
    {
        int i = 0;
        foreach (Transform child in transform)
        {
            float x = i * separationFactor;
            child.localPosition = new Vector3(x, transformacionEscala * (Mathf.Sin(x * transformacionExpandir + transformacionPos)+Mathf.Sin(2*x+5)), 0);
            ++i;
        }
    }
}
