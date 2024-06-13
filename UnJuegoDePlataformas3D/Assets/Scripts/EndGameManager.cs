using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndGameManager : MonoBehaviour
{
    public Button replay;
    public Button menu;

    void Start()
    {
        replay.onClick.AddListener(Reload);
        menu.onClick.AddListener(Menu);
    }

    void Reload()
    {
        SceneManager.LoadScene("PlatformGame");
    }

    void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
