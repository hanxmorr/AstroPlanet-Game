using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickup;
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

        if (ct > 3f)
        {
            GameObject newObj = Instantiate(pickup);
            newObj.transform.position = new Vector2(4, randY);
            ct = 0;
        }
        ct += Time.deltaTime;
    }
}