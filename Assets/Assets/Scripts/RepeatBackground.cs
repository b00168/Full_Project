using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
  public float backSpeed = 4f;
  private Vector3 startPos;
  
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;       
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * backSpeed * Time.deltaTime);
          if( transform.position.y < 0.23)
        {
            transform.position = startPos;
        }  
    }
}
