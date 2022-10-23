using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject pipe;
    public float timeDiff;
    float timer = 0;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if(timer > timeDiff){
            GameObject newpipe = Instantiate(pipe); // 파이프 생성
            newpipe.transform.position = new Vector3(2,Random.Range(-3.0f,2.8f),0); // 좌표에 위치
            timer = 0; // 1초마다 리셋
            Destroy(newpipe, 5.0f);
        }
        
    }
}
