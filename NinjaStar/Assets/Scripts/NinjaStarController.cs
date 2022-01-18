using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NinjaStarController : MonoBehaviour
{
    GameObject NinjaStar;
    float speed = 0;
    Vector2 startPos;
    // Start is called before the first frame update
    void Start()
    {
        this.NinjaStar = GameObject.Find("NinjaStar");
    }

    // Update is called once per frame
    void Update()
    {
        /* transform.Rotate(0, 0, 12); // 항상 회전 */
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.y - startPos.y; // 마우스 클릭, 뗀 것의 y축 차이에 의해서만 진행

            this.speed = swipeLength / 500.0f;
        }
        transform.Translate(new Vector3(0, this.speed, 0), Space.World); // Space.World를 통해 회전 영향X
        this.speed *= 0.98f; // 감속

        /* if (transform.position.y> 6 || transform.position.y<-6)
            Destroy(gameObject); // 1280x720 Portrait 기준으로 절댓값이 약 5.8일때 화면에서 보이지 않음. */

        if (Mathf.Abs(transform.position.y) > 4.6)
            this.speed *= -1;

        if(Mathf.Abs(this.speed)>0.001f)
        {
            if (this.speed * 100 > 16)
                transform.Rotate(0, 0, 16); // 회전 속도 제한
            else
                transform.Rotate(0, 0, this.speed * 100); // 표창이 이동하지 않을 시엔 사실상 회전을 안 함
        }
            
    }
}
/* 스스로에게 주어지는 업그레이드 가능한 과제
1. 표창이 화면 모서리를 맞으면 반대방향으로 가게함으로써 화면 안에 계속 남아있게 할 수 있나?
2. 표창이 정지해있을 시(0.001f 이하일 시 정지로 간주하는 등의 방법) 회전을 멈출수 있는가?
*/