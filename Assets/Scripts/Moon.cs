using System.Collections.Generic;
using UnityEngine;

public class Moon : MonoBehaviour
{
    public Transform center;
    public float speed = 10f;
    public float radius = 5f;
    private float angle = 0f;
    
    void FixedUpdate()
    {
        OrbitCenter();
    }

    void OrbitCenter()
    {
        if (center != null)
        {
            angle += speed * Time.deltaTime;

            float x = center.position.x + Mathf.Cos(angle) * radius;
            float z = center.position.z + Mathf.Sin(angle) * radius;

            transform.position = new Vector3(x, transform.position.y, z);
        }
    }
}
