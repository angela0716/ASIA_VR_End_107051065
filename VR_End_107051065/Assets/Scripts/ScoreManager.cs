using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public static int score;
    [Header("分數")]
    public int score1;
    [Header("分數2")]
    public int score2;
    [Header("分數3")]
    public int score3;
    [Header("擊球音效")]
    public AudioClip soundIn;
    private AudioSource aud;
    private void Awake()
    {
        aud = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
       if(other.tag =="棒球")
        {
            transform.GetChild(0).GetComponent<Collider>().enabled = false;
            AddScore();
            AddScore2();  
            AddScore3();
        }
    }
    private void AddScore()
    {
        score += score1;
        textScore.text = "得分:" + score;
        aud.PlayOneShot(soundIn, Random.Range(0.1f,1f));
    }
    private void AddScore2()
    {
        score += score2;
        textScore.text = "得分:" + score;
     
    } 
    private void AddScore3()
    {
        score += score3;
        textScore.text = "得分:" + score;
     
    }

}
