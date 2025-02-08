using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform EnemyTf;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IEDestroyEnemy());
    }

    // Update is called once per frame
    void Update()
    {
        EnemyTf.position += Vector3.down * speed * Time.deltaTime;
    }

    IEnumerator IEDestroyEnemy()
    {
        yield return new WaitForSeconds(2f);
        Destroy(gameObject);
    }

}
