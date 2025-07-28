using Unity.VisualScripting;
using UnityEngine;

public class playershoot : MonoBehaviour
{
    public GameObject bulletPrefab; // 총알 Prefab
    public float power = 1f;
    public Transform firepoint1;
    public Transform firepoint2_1; //총알 발사 위치
    public Transform firepoint2_2;
    public Transform firepoint3_1;
    public Transform firepoint3_2;
    public Transform firepoint3_3;
    public float fireDelay = 0.2f; //발사 딜레이 시간
    private float lastFire = 0.0f; //마지막으로 발사한 시간

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // 스페이스 키가 눌린 상태에서 딜레이 시간이 초과됐으면
        if (Input.GetKey(KeyCode.Space) && Time.time > lastFire + fireDelay) //유니티에서 제공 keycode : 각 키가 값으로 매칭되어있음
        {
            if (power == 1)
            {
                Instantiate(bulletPrefab.transform, firepoint1.position, Quaternion.identity);
            }
            else if (power == 2)
            {
                //총알 프리펍을 불러와서 시작 위치에 배치
                Instantiate(bulletPrefab.transform, firepoint2_1.position, Quaternion.identity);
                Instantiate(bulletPrefab.transform, firepoint2_2.position, Quaternion.identity);
                //Instantiate(Resources.Load("Bullet"), firepoint.position, Quaternion.identity);
                //로도 가능하지만 부하가 많이 걸림
            }
            else if (power == 3)
            {
           
             Instantiate(bulletPrefab.transform, firepoint3_1.position, Quaternion.identity);
             Instantiate(bulletPrefab.transform, firepoint3_2.position, Quaternion.identity);
             Instantiate(bulletPrefab.transform, firepoint3_3.position, Quaternion.identity);
                
            }

            lastFire = Time.time;
        }
            
        
      
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "power")
        {
            if (power <= 2)
            {
                power += 1;
            }
            else
            {
                GameManager.Instance.Addscore(5);

            }
        }
        

    }
}
