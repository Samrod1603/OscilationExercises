using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiagonalOscillations : MonoBehaviour
{
    [SerializeField] private float amplitude = 1;
    [SerializeField] private float period = 1;

    private Vector3 initialBallPosition = new Vector3(0, 0);
  
    private void Start()
    {
        initialBallPosition = transform.position; 
    }
    public void Update()
    {
 
        if (period > 0)
        {
            // movimiento senosoidal horizontal ------------------------------------
            //float x = Mathf.Sin(2 * Mathf.PI * (Time.time / period)) * amplitude;
            //transform.position = new Vector3(initialBallPosition.x + x, 0, 0);

            // movimiento senosoidal diagonal ------------------------------------
            //float x = Mathf.Sin(2 * Mathf.PI * (Time.time / period)) * amplitude;
            //transform.position = new Vector3(initialBallPosition.x + x, initialBallPosition.y + x, 0);

            float x = Mathf.Sin(2 * Mathf.PI * (Time.time / period)) * (Mathf.Sin(5f *Time.time) +  Mathf.Cos(Time.time/3f) + Mathf.Sin(Time.time/ 13f));
            transform.position = new Vector3(initialBallPosition.x + x, initialBallPosition.y + x, 0);
        }
        
        
    }
}
