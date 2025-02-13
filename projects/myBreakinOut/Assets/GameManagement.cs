using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagement : MonoBehaviour {
    public int points = 0; 
    public int lives = 3;

    public static GameManagement S;

    void Awake() {
        S = this;
    }

    public void AddPoint(int pv) {
        points += pv;
    }

    public void LoseLife() {
        lives--;
        Debug.Log(lives);

        if (lives <= 0) {
            GameOver();
        }
    }

    public void GameOver() {
        SceneManager.LoadScene("GameOver");
    }
}
