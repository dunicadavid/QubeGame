using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Transform Player;

    public Text score;

	void Update () {
        score.text = Player.position.x.ToString("0");
	}
}
