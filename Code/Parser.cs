using UnityEngine;

[System.Serializable]
public class PlayerData
{
    public string playerName;
    public int score;
}

public class JSONParser : MonoBehaviour
{
    private void Start()
    {
        string json = "{\"playerName\":\"Player\",\"score\":100}";
        PlayerData playerData = JsonUtility.FromJson<PlayerData>(json);
        Debug.Log($"Name: {playerData.playerName}, Score: {playerData.score}");
    }
}
