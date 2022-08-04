using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int health = 3;
    public int speed = 5;
    public Vector3 direction = new Vector3(0f, 0f, 1f);

    void Start()
    {

    }

    void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }

    void Damage(int attack)
    {
        health -= attack;
    }

    void Heal(int heal)
    {
        health += heal;
    }
}
