using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class SpaceShip : MonoBehaviour
{
    public Transform tf;
    public float speed;
    public GameObject bulletPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            tf.position += speed * Vector3.right * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            tf.position += speed * Vector3.left * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            tf.position += speed * Vector3.up * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            tf.position += speed * Vector3.down * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newBullet = Instantiate(bulletPrefab);
            newBullet.transform.position = tf.position - Vector3.up * 0.3f;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
