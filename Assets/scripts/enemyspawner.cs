using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class enemyspawner : MonoBehaviour
{
    public GameObject[] enemyPrefab;
        public float spawnDelay = 1.0f;
    float timer = 0;
        

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int i = Random.Range(0, 2);
        float x = Random.Range(-5f, 5f);
        Instantiate(enemyPrefab[i], new Vector3(x, 7.0f, 0), Quaternion.identity);
    } 

    // Update is called once per frame
    void Update()
    {
       
        timer += Time.deltaTime;
        if (timer > spawnDelay )

        {
            float x = Random.Range(-5f, 5f); //x좌표를 -2.5에서 2.5내의 난수로 지정
            //Random.Range = 범위 내 난수를 발생하는 유니티 자체 함수.
            //최소값은 포함하고, 최대값은 제외함. (0,2) = 0~1값(0또는 1)이 랜덤으로 지정 (0은 포함, 2는 제외)
            int i = Random.Range(0, 2);
            Instantiate(enemyPrefab[i], new Vector3(x, 6.0f, 0), Quaternion.identity);
            
            timer = 0.0f;
           
        }
      

    }
}
