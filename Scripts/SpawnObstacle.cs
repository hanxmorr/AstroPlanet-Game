using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacle : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    float ct = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        int randIndex = Random.Range(0, 4);
        float randY = Random.Range(-2f, 2f);
        
        if (ct > 2f)
        {
            GameObject newObj = Instantiate(obstaclePrefabs[randIndex]);
            newObj.transform.position = new Vector2(4, randY);
            ct = 0;
        }
        ct += Time.deltaTime;
    }
}
