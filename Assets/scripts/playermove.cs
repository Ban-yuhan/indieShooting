using NUnit.Framework.Constraints;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class playermove : MonoBehaviour
{

    public float speed = 5.0f;
    public int playerHp = 3;
    public Image[] Hp;

    //public bool playerdeath = true;   
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //키보드의 상하좌우 키가 눌렸을 떄 입력 값 가져오기
        float h = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        // 이동할 방향 계산
        Vector3 dir = new Vector3(h, y, 0);

        //계산한 방향으로 플레이어를 이동시켜 위치를 갱신
        transform.position += dir.normalized * speed * Time.deltaTime;




    }
    private void OnTriggerEnter2D(Collider2D collision)
    //Collider2D 가 충돌할때
    {
        if (collision.gameObject.tag == "enemy")
        {
           playerHp -= 1;
            Hp[playerHp].enabled = false;


            if (playerHp <= 0)
            {
                Destroy(gameObject);
                GameManager.Instance.Gameover.gameObject.SetActive(true);
                GameManager.Instance.Restart.gameObject.SetActive(true);
                Time.timeScale = 0;


            }

        }
       







    }
    
}
    
