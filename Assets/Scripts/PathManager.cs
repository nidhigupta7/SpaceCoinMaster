using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PathManager : MonoBehaviour
{
    public GameObject[] pathBackgroundPrefab;
    public float ySpawn = 0;
    public float pathLength = 17;
    public int numberOfPathBg = 5;
    public Transform playerTransform;
    public List<GameObject> activePath;


    void Start()
    {

        for (int i = 0; i < numberOfPathBg; i++)
        {
            if (i == 0)
                spawnPathBackground(0);
            else
                spawnPathBackground(Random.Range(0, pathBackgroundPrefab.Length));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (playerTransform.position.y - 19 > ySpawn - (numberOfPathBg * pathLength))
        {
            spawnPathBackground(Random.Range(0, pathBackgroundPrefab.Length));
            DeletePath();
        }
    }
    public void spawnPathBackground(int pathIndex)
    {
        GameObject go = Instantiate(pathBackgroundPrefab[pathIndex], transform.up * ySpawn, transform.rotation);
        activePath.Add(go);
        ySpawn += pathLength;
    }
    private void DeletePath()
    {
        Destroy(activePath[0]);
        activePath.RemoveAt(0);
    }
}
