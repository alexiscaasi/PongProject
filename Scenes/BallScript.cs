using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    public float speed = 6f;

    // Start is called before the first frame update
    void Start()
    {
      float xStart = Random.Range(0,2) == 0 ? -1 : 1;
      float yStart = Random.Range(0,2) == 0 ? -1 : 1;

      GetComponent<Rigidbody>().velocity = new Vector3 (speed * 2 * xStart, speed * 2 * yStart, 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
