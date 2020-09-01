using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;

    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel() {
        Debug.Log("Level WON");
        completeLevelUI.SetActive(true);
        Invoke(nameof(Restart), restartDelay); // should be next lvl

    }

    public void EndGame() {
        if (gameHasEnded == false) {
            gameHasEnded = true;
            Debug.Log("GAME OVER");
            Invoke(nameof(Restart), restartDelay);
        }
    }
    void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        completeLevelUI.SetActive(false); // animation fix

    }
}
