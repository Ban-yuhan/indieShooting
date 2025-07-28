using Unity.VisualScripting;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed = 2.0f;
    public float Hp = 3.0f;
    public GameObject power;

    //------------------------------------------------------------------------------------------------------------------------
    //public float Pos = 0;
    //public float moveSpeed = 3f;
    //public float moveRange = 3f;
    //private Vector2 initialPosition;
    //---------------------------------------------------------------------------------------------------------------------------------------


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //----------------------------------------------------------------------------------------------------------------------------
        //initialPosition = transform.position;
        //------------------------------------------------------------------------------------------------------------------------------
    }


    // Update is called once per frame 매 프레임마다 호출되는 함수
    void Update()
    {
        //위치 갱신
        transform.position += Vector3.down * speed * Time.deltaTime;

        //일정 위치 이하로 내려가면 파괴
        if (transform.position.y < -7)
        {
            Destroy(gameObject);
        
        }
        
        //--------------------------------------------------------------------------------------------------------------
        //if (Pos == 0)
        //{
        //float movement = Mathf.Sin(Time.time * moveSpeed) * moveRange;
        //transform.position = new Vector2(initialPosition.x + movement, initialPosition.y);
        //--------------------------------------------------------------------------------------------------------------------------
    }
    private void OnTriggerEnter2D(Collider2D collision)
        //Collider2D 가 충돌할때
    {
        if (collision.gameObject.tag == "Bullet")
            //해당 스크립트의 gameobjact가 "Bullet" tag를 가진 오브젝트와 충돌 하면
        {
            Hp -= 1.0f;
            if (Hp <= 0)
            {
                Destroy(gameObject);
                GameManager.Instance.Addscore(10);
                
                int P = Random.Range(0, 100);
                if (P <= 25) 
                {
                    Vector3 location = transform.position;
                    Instantiate(power, location, Quaternion.identity);

                }
            }
        }
        if (collision.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }


        //----------------------------------------------------------------------------------------------------------------------------------------
        //else if (Pos == 1)

        // {
        //float movement = Mathf.Sin(Time.time * moveSpeed) * moveRange;
        // transform.position = new Vector2(initialPosition.x + movement, initialPosition.y);
        //-----------------------------------------------------------------------------------------------------------------------------------

    }
    
}
  // void는 ~때. OntriggerEnter2D 를 void로 따로 만드는 이유 = 충돌할 때 따로 실행되어야 하기 때문

