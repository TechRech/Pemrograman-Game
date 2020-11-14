using UnityEngine;
using UnityEngine.UI;
public class ShowScore : MonoBehaviour
{
	public int score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
		GetComponent<Text>().text = score.ToString("000");
    }
}
