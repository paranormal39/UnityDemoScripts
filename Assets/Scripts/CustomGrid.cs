using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customGrid : MonoBehaviour
{
    public GameObject[] roomsToPick;
    public int gridx;
    public int gridz;
    public float gridSpacingOffset = 1f;
    public Vector3 gridOrgin = Vector3.zero;

    // Start is called before the first frame update
    //create a procudre dungeon or labyrith 
    void Start()
    {
        SpawnGrid();
    }
    void SpawnGrid()
    {
        for(int x = 0; x < gridx; x++)
        {
            for(int z = 0; z <gridz; z++)
            {
                Vector3 spawnPosition = new Vector3(x * gridSpacingOffset, 0, z * gridSpacingOffset) + gridOrgin;
                PickAndSpawn(spawnPosition, Quaternion.identity);
            }
        }

    }

    void PickAndSpawn(Vector3 positionToSpawn,Quaternion rotationToSpawn)
    {
        int randomIndex = Random.Range(0, roomsToPick.Length);
        GameObject clone = Instantiate(roomsToPick[randomIndex], positionToSpawn, rotationToSpawn);
    }
   
}
