using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    Vector3 animalArea1;
    Vector3 animalArea2;
    Vector3 cropArea;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void spawnCow()
    {
        animalArea1 = new Vector3(Random.Range(10.19f, 15.52f), 4, Random.Range(5.85f, 10.98f));
        Instantiate(Resources.Load("Cow"), animalArea1, Quaternion.identity);
    }

    public void spawnPig()
    {
        animalArea2 = new Vector3(Random.Range(5.32f, 10.33f), 4, Random.Range(11.79f, 16.70f));
        Instantiate(Resources.Load("Pig"), animalArea2, Quaternion.identity);
    }

    public void spawnCorn()
    {
        //cropArea = new Vector3(Random.Range(9.7f, 26.6f), 4, Random.Range(27.6f, 34.4f));
        
    }

    public void spawnWheat()
    {
        //cropArea = new Vector3(Random.Range(9.7f, 26.6f), 4, Random.Range(27.6f, 34.4f));

    }
}
