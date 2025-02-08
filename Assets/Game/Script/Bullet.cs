using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public Transform bulletTf;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(IEDestroyBullet());
    }

    // Update is called once per frame
    void Update()
    {
        bulletTf.position += Vector3.up * speed * Time.deltaTime;
    }

    IEnumerator IEDestroyBullet()
    {
        yield return new WaitForSeconds(1f);
        Destroy(gameObject);
    }

}
