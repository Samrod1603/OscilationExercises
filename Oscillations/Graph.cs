using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graph : MonoBehaviour
{
    
    [SerializeField] int totalPrefabs = 100;
    [SerializeField] float distanceFactor = 1;
    [SerializeField] float graphAmplitude = 1; 
    [SerializeField] GameObject prefab;

    private GameObject[] allPrefabs; 
    // Start is called before the first frame update
    void Start()
    {
        allPrefabs = new GameObject[totalPrefabs];
        for (int i = 0; i < totalPrefabs; i++)
        {
            allPrefabs[i] = Instantiate(prefab, transform);
           
            
        }
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < totalPrefabs; i++)
        {
            float x = (i * distanceFactor) ;
            float y = Mathf.Sin(x - Time.time) * graphAmplitude;
            allPrefabs[i].transform.localPosition = new Vector3(x, y, 0);
        }
        
    }
}
