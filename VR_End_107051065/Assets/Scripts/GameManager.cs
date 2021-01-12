using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    /// <summary>
    /// 重新
    /// </summary>
    public void RestarGame()
    {
        SceneManager.LoadScene("九宮格");
    }
    /// <summary>
    /// 離開
    /// </summary>
    public void QuitGame()
    {
        Application.Quit();
    }
}
