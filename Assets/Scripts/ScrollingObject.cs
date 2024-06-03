using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingObject : MonoBehaviour
{
    public float speed = 5f;
    private void Update()
    {
        if (!GameManager.instance.isGameover)
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }
    }
}
