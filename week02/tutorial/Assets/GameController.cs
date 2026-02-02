using TMPro;
using UnityEngine;

public class GameController : MonoBehaviour

{
    [SerializedField] private playerController playerController;
    public TMP_Text TimerText;
    public Canvas GameOverCanvas;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    private void Awake()
    {
        if (playerController != null)
        {
            playerController.PlayerDied += WhenPlayerDies;
        }
        if (GameOverCanvas.gameObject.activeSelf)
        {
            GameOverCanvas.gameObject.SetActive(false);
        }
    }

    void WhenPlayerDies()
    {
        GameOverCanvas.gameObject.SetActive(true);
        TimerText.text = "You Lasted:" + Math.Round(TimerText.timeSinceLevelLoad, 2);

        if (playerController != null)
        {
            playerController.PlayerDied -= WhenPlayerDies;
        }
    }

    public void RetryClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
