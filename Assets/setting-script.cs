using UnityEngine;

public class settingScript : MonoBehaviour
{
    [Header("Content Panel")]
    public GameObject umumPanel;
    public GameObject kontrolPanel;
    public GameObject bahasaPanel;
    public GameObject audioPanel;
    public GameObject grafisPanel;
    public GameObject tentangPanel;

    // Semua panel dimatikan dulu
    void Start()
    {
        HideAll();

        // Panel awal
        umumPanel.SetActive(true);
    }

    void HideAll()
    {
        umumPanel.SetActive(false);
        kontrolPanel.SetActive(false);
        bahasaPanel.SetActive(false);
        audioPanel.SetActive(false);
        grafisPanel.SetActive(false);
        tentangPanel.SetActive(false);
    }

    public void OpenUmum()
    {
        HideAll();
        umumPanel.SetActive(true);
    }

    public void OpenKontrol()
    {
        HideAll();
        kontrolPanel.SetActive(true);
    }

    public void OpenBahasa()
    {
        HideAll();
        bahasaPanel.SetActive(true);
    }

    public void OpenAudio()
    {
        HideAll();
        audioPanel.SetActive(true);
    }

    public void OpenGrafis()
    {
        HideAll();
        grafisPanel.SetActive(true);
    }

    public void OpenTentang()
    {
        HideAll();
        tentangPanel.SetActive(true);
    }
}