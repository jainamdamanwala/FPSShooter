using UnityEngine;
using UnityEngine.UI;

public class KillFeed : MonoBehaviour
{
    public Text killFeedText;
    private float displayDuration = 3f;

    public void ShowKill(string killer, string victim)
    {
        killFeedText.text = $"{killer} eliminated {victim}";
        Invoke("ClearKillFeed", displayDuration);
    }

    void ClearKillFeed()
    {
        killFeedText.text = "";
    }
}
