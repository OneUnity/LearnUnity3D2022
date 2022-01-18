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
        /* transform.Rotate(0, 0, 12); // �׻� ȸ�� */
        if(Input.GetMouseButtonDown(0))
        {
            this.startPos = Input.mousePosition;
        }
        else if(Input.GetMouseButtonUp(0))
        {
            Vector2 endPos = Input.mousePosition;
            float swipeLength = endPos.y - startPos.y; // ���콺 Ŭ��, �� ���� y�� ���̿� ���ؼ��� ����

            this.speed = swipeLength / 500.0f;
        }
        transform.Translate(new Vector3(0, this.speed, 0), Space.World); // Space.World�� ���� ȸ�� ����X
        this.speed *= 0.98f; // ����

        /* if (transform.position.y> 6 || transform.position.y<-6)
            Destroy(gameObject); // 1280x720 Portrait �������� ������ �� 5.8�϶� ȭ�鿡�� ������ ����. */

        if (Mathf.Abs(transform.position.y) > 4.6)
            this.speed *= -1;

        if(Mathf.Abs(this.speed)>0.001f)
        {
            if (this.speed * 100 > 16)
                transform.Rotate(0, 0, 16); // ȸ�� �ӵ� ����
            else
                transform.Rotate(0, 0, this.speed * 100); // ǥâ�� �̵����� ���� �ÿ� ��ǻ� ȸ���� �� ��
        }
            
    }
}
/* �����ο��� �־����� ���׷��̵� ������ ����
1. ǥâ�� ȭ�� �𼭸��� ������ �ݴ�������� ���������ν� ȭ�� �ȿ� ��� �����ְ� �� �� �ֳ�?
2. ǥâ�� ���������� ��(0.001f ������ �� ������ �����ϴ� ���� ���) ȸ���� ����� �ִ°�?
*/