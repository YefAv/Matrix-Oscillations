using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleOsc : MonoBehaviour
{

        [SerializeField] private float trs, dif;
        [SerializeField] private bool noise, diag;
        private void Start()
        {

        }

        private void Update()
        {
            if (noise) GraphSinNoise();
            else if (diag) GraphSinDiag();
            else GraphSinSide();
        }

        void GraphSinDiag()
        {
            Vector3 pos = new Vector3(Mathf.Sin(Time.time)*trs, Mathf.Sin(Time.time)*trs, 0);
            transform.position = pos;
        }

        void GraphSinSide()
        {
            Vector3 pos = new Vector3(Mathf.Sin(Time.time)*trs, 0, 0);
            transform.position = pos;
        }

        void GraphSinNoise()
        {
            Vector3 pos = new Vector3(Mathf.Sin(Time.time*dif)+Mathf.Sin(Time.time)*trs*Mathf.Cos(Time.time*trs+trs), Mathf.Cos(Time.time*dif)*dif, 0);
            transform.position = pos;
        }
}
