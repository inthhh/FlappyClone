using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed;
    // Start is called before the   first frame update
    void Start() // 처음에만 실행
    {
        
    }

    // Update is called once per frame
    void Update() // 매 프레임마다 실행
    {
        transform.position += Vector3.left * speed * Time.deltaTime; // (-1,0,0)
        
    }
}

