using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveController : MonoBehaviour
{
        int playerSpeed = 1;    //플레이어 속도
        Rigidbody2D rid2D;       //리지드 바디 선언

    // Start is called before the first frame update
    private void Start()
    {
       rid2D = GetComponent<Rigidbody2D>(); //스크립트 리지드 선언
    }   

    void PlayerMove(){
        if(Input.GetKey(KeyCode.RightArrow)){   //오른쪽키 조건문
            rid2D.AddForce(new Vector2(playerSpeed,0), ForceMode2D.Force); 
            //Force 는 엑셀 처럼 천천히 , Impulse 는 처음부터 빠르게 
            // transform.Translate(new Vector3(playerSpeed * Time.deltaTime,0,0)); 포지션 변화 이동
        }
        if(Input.GetKey(KeyCode.LeftArrow)){   //왼쪽키 조건문
            rid2D.AddForce(new Vector2(-playerSpeed,0), ForceMode2D.Force);
            // transform.Translate(new Vector3(-playerSpeed * Time.deltaTime,0,0));
        }

    }
    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }
}
