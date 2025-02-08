using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnControl : MonoBehaviour
{
    public GameObject EnemyPrefab;
    public float spawnSpeed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IESpawnEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator IESpawnEnemy()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnSpeed);
            Instantiate(EnemyPrefab).transform.position = new Vector3(Random.Range(-7f, 7f), 5, 0);
        }
    }
}
