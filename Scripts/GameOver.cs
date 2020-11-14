using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
	public Text txScore;
	public Text txHighScore;
	Text txSelamat;
	int highscore;
	int score;
    // Start is called before the first frame update
    void Start()
    {
		highscore = PlayerPrefs.GetInt("HS",0);
		if (score > highscore)
		{
			highscore = score;
			PlayerPrefs.SetInt("HS", highscore);
		}
		else if (EnemyController.EnemyKilled ==3)
		{
			SceneManager.LoadScene("Congratulations");
		}

		txHighScore.text = "Highscores : " + highscore;
		txScore.text = "Scores : " + score;
    }
	public void Replay()
	{
		score = 0;
		EnemyController.EnemyKilled = 0;
		SceneManager.LoadScene("Gameplay");
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
