using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class score : MonoBehaviour
{

    public Transform Player;
    public TextMeshProUGUI SText;

    // Update is called once per frame
    void Update()
    {
        SText.SetText(Player.position.z.ToString("0"));
    }
}
