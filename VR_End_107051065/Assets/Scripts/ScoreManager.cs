using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
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
            AddScore();
        }
    }
    private void AddScore()
    {
        score += 1;
        textScore.text = "得分:" + score;
        aud.PlayOneShot(soundIn, 1.5f);
    }
}
