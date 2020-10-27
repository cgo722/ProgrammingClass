using UnityEngine;

public class Spawing : MonoBehaviour
{
    public GameObject collectable;

    private float spawnRangeX = 20;
    private float spawnRangeZ = 20;
    private float delayTime = 1f;
    private float spawnInterval = 1.5f;

    private void Start()
    {
        InvokeRepeating("SpawnCollectables", delayTime, spawnInterval);

    }

    void SpawnCollectables()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), .5f, Random.Range(-spawnRangeZ, spawnRangeZ));
        Instantiate(collectable, spawnPos, collectable.transform.rotation);
    }
}
