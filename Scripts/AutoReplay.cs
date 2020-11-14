using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class AutoReplay : MonoBehaviour
{
	float timer = 0;
	public Text info;
	int score;
    // Start is called before the first frame update
    void Start()
    {
		if (EnemyController.EnemyKilled == 3)
		{
			info.text = "Congratulations \n You Win!";
		}
    }

    // Update is called once per frame
    void Update()
    {
		timer += Time.deltaTime;
		if (timer > 5)
		{
			score = 0;
			EnemyController.EnemyKilled = 0;
			SceneManager.LoadScene("Gameplay");
		}
    }
}
