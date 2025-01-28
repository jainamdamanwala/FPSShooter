using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class Leaderboard : MonoBehaviour
{
    public GameObject leaderboardPanel;
    public Transform leaderboardContent;
    public GameObject leaderboardEntryPrefab;

    private List<LeaderboardEntry> entries = new List<LeaderboardEntry>();

    public void AddEntry(string playerName, int score)
    {
        LeaderboardEntry newEntry = new LeaderboardEntry { playerName = playerName, score = score };
        entries.Add(newEntry);
        UpdateLeaderboard();
    }

    public void UpdateLeaderboard()
    {
        foreach (Transform child in leaderboardContent)
        {
            Destroy(child.gameObject);
        }

        entries.Sort((x, y) => y.score.CompareTo(x.score));

        foreach (LeaderboardEntry entry in entries)
        {
            GameObject newEntry = Instantiate(leaderboardEntryPrefab, leaderboardContent);
            Text[] texts = newEntry.GetComponentsInChildren<Text>();
            texts[0].text = entry.playerName;
            texts[1].text = entry.score.ToString();
        }
    }

    public void ToggleLeaderboard()
    {
        leaderboardPanel.SetActive(!leaderboardPanel.activeSelf);
    }
}

[System.Serializable]
public class LeaderboardEntry
{
    public string playerName;
    public int score;
}
