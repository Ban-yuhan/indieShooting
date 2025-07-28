using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //싱글턴
    public int myscore = 0;
    public TextMeshProUGUI textScore;
    public TextMeshProUGUI Gameover;
    public Button Restart;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Awake()
    {
        Instance = this; // 내 자신의 클래스를 저장해둔다.

    }

    void Start()
    {
        textScore.text = myscore.ToString();
        Gameover.gameObject.SetActive(false);
        Restart.gameObject.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {
    }
    public void Addscore(int score)
                { 
        myscore += score; 
        textScore.text = myscore.ToString();
    

    }
    
    public void RestartGame()
    { 
    SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1;
    }
   
   
}

