using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class menu : MonoBehaviour
{
    public GameObject menuPanel;
    public GameObject materiPanel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        menuPanel.SetActive(true);
        materiPanel.SetActive(false);
    }


    void Update()
    {
        
    }

    public void startgame(string scenename)
    {
        SceneManager.LoadScene(scenename);
    }

    public void infoButton()
    {
        menuPanel.SetActive(false);
        materiPanel.SetActive(true);
    }

    public void showMenuPanel()
    {
        menuPanel.SetActive(true);
        materiPanel.SetActive(false);
    }

    public void backButton()
    {
        menuPanel.SetActive(true);
        materiPanel.SetActive(false);
    }

    public void exitgame()
    {
        Application.Quit();
    }

    public void AudioButton()
    {
        
    }
}
