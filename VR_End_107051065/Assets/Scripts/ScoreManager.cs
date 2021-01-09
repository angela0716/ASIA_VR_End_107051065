using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;
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
    }
}
