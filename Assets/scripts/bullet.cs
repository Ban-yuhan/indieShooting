using UnityEngine;

public class bullet : MonoBehaviour
{
    public float speed = 10.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.up * speed * Time.deltaTime;
        //Vector3.up 은 y축, Vector3.right 는 x축, Vector3.foward는 z축

        if (transform.position.y > 7.0f)
        {
            Destroy(gameObject);
            //총알의 y 위치가 7보다 커지면 게임오브젝트 파괴
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    //Collider2D 가 충돌할때
    {
        if (collision.gameObject.tag == "enemy")
        {
            Destroy(gameObject);
        }
    }
}
