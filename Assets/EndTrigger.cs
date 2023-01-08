using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    
    void OnTriggerEnter()
    {
        Application.Quit();
    }

}
