using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    public Button play;

    void Start()
    {
        play.onClick.AddListener(Play);
    }

    void Play()
    {
        SceneManager.LoadScene("PlatformGame");
    }
}
