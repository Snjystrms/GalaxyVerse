using UnityEngine.Networking;
using UnityEngine.UI;
using UnityEngine;
using System.Collections;
using TMPro;

public class RestAPI : MonoBehaviour
{
    private string URL = "https://66f962e7afc569e13a98a041.mockapi.io/data/Leaderboard";
    public TMP_Text UsernameText;
    public TMP_Text CoinsText;
    public int index;

    void Start()
    {
        StartCoroutine(GetDatas());
    }

    IEnumerator GetDatas()
    {
        using (UnityWebRequest request = UnityWebRequest.Get(URL))
        {
            yield return request.SendWebRequest();

            if (request.result == UnityWebRequest.Result.ConnectionError)
            {
                Debug.LogError(request.error);
            }
            else
            {
                string json = request.downloadHandler.text;
                SimpleJSON.JSONNode stats = SimpleJSON.JSON.Parse(json);

                UsernameText.text = "Username: " + stats[index]["username"];
                CoinsText.text = "Coins: " + stats[index]["coins"];
            }
        }
    }
}
