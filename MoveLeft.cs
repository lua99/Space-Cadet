using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float Speed=1;

    private Enemy enemy;

    private void Awake()
    {
        enemy = GetComponent<Enemy>();
    }


    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left *Time.deltaTime*Speed);

        if(transform.position.x < -11)
        {
            transform.position += Vector3.right * 22;
            enemy?.Respawn();
        }
    }
}
