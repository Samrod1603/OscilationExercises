using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillations : MonoBehaviour
{
    [SerializeField] private float amplitude = 1; 
    public void Update()
    {
        float x = Mathf.Sin(Time.time) * amplitude; 
        transform.position = new Vector3(x, 0, 0); 
    }
}
