using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    GameObject player;
    GameObject hpGauge;
    public float radius;
    // Start is called before the first frame update
    void Start()
    {
        this.player = GameObject.Find("player");
        this.hpGauge = GameObject.Find("hpGauge");
    }

    // Update is called once per frame
    void Update()
    {
        if (this.hpGauge.GetComponent<Image>().fillAmount > 0f)
            transform.Translate(0, -0.1f, 0);
        else
            transform.Translate(0, 0, 0);

        if(transform.position.y<-4.0f)
        {
            GameObject scoredirector = GameObject.Find("ScoreDirector");
            scoredirector.GetComponent<ScoreDirector>().IncreaseScore();
            Destroy(gameObject);
            /*Destory(this); 를 할 시 'Component'가 삭제된다. 즉, 화살의 y축 좌표가 -4가 되면 낙하(16번째줄)하지 않는다. */
            
        }

        Vector2 p1 = transform.position;
        Vector2 p2 = this.player.transform.position;
        Vector2 d = p2 - p1;
        float dis = d.magnitude;
        float r1 = 0.5f;
        float r2 = 0.8f;

        if(d.magnitude<r1+r2)
        {
            GameObject hpdirector = GameObject.Find("HPDirector");
            hpdirector.GetComponent<HPDirector>().DecreaseHp();
            GameObject scoredirector = GameObject.Find("ScoreDirector");
            scoredirector.GetComponent<ScoreDirector>().DecreaseScore();

            Destroy(gameObject);
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
