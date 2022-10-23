using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdJump : MonoBehaviour
{
    Rigidbody2D rd;
    public float JumpPower;
    void Start()
    {
        rd = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            GetComponent<AudioSource>().Play();
            rd.velocity = Vector2.up * JumpPower; // (0,1) * JumpPower
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        // 콜라이저끼리 부딫힐때 이벤트
        if(Score.bestScore < Score.score){
            Score.bestScore = Score.score;
        }
        SceneManager.LoadScene("GameOverScene");
    }
}
