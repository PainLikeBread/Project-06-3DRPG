using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImSpinning : MonoBehaviour
{

    public float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Generate random rotation angles
        float randomRotationX = Random.Range(-100f, 100f) * speed * Time.deltaTime;
        float randomRotationY = Random.Range(-30f, 30f) * speed * Time.deltaTime;
        float randomRotationZ = Random.Range(-180f, 180f) * speed * Time.deltaTime;

        // Apply rotation
        transform.Rotate(new Vector3(0, randomRotationY, 0));
    }
}
