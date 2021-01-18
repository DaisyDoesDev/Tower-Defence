using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] List<Waypoint> path;

    // Start is called before the first frame update
    void Start()
    {
        printAllBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void printAllBlocks()
    {
        foreach (Waypoint waypoint in path)
        {
            print(waypoint.name);
        }
    }
}
