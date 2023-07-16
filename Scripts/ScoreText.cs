using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    [SerializeField] private Text TextScore;
    [SerializeField] private Text TextScoreRec;

    public void UpdateScoreText(int index)
    {
        TextScore.text = index.ToString();
    } 
    
    public void UpdateScoreTextRec(int index)
    {
        TextScoreRec.text = "рекорд: " + index.ToString();
    }
}
