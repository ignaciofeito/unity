using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 10f;
    public Vector3 direction = new Vector3(0f, 0f, 1f);

    public float lifetime = 2f;
    public int damage = 1;
    void Start()
    {
        Invoke("DestroyDelay", lifetime);
    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += transform.localScale;
        }
    }

    void DestroyDelay()
    {
        Destroy(gameObject);
    }
}
