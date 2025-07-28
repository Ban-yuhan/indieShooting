using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadingmanager : MonoBehaviour
{

    public TextMeshProUGUI loading;

    private float dotTimer = 0f;
    private int dotCount = 0;
    private float dotInterval = 0.5f;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        dotTimer += Time.deltaTime;
        if (dotTimer >=dotInterval)
        {
            dotTimer = 0f;
            dotCount = (dotCount + 1) % 4; // 1 %4 > 1을 4로나눈 나머지 값

            string dots = new string('.', dotCount); // "."을 dotCount개 만큼
            loading.text = "Loading" + dots; // Loading 과 dots를 표시하겠다
        }

        Invoke("gamestart", 3f); //invoke : (실행할 것 , 딜레이시간)
    }
    
    void gamestart()
    {
    SceneManager.LoadScene("SampleScene");
    }
    
 }
