using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnSpaceAnimals : MonoBehaviour
{
    public Color GizmosColor = new Color(0.5f, 0.5f, 0.5f, 0.2f);

    // Start is called before the first frame update
    void Start()
    {
        //define animal spawn area as vectors in 3D scene

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnDrawGizmos()
    {
        Gizmos.color = GizmosColor;
        Gizmos.DrawCube(transform.position, transform.localScale);

    }

}
