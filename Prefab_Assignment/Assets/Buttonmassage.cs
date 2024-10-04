using UnityEngine;
using UnityEngine.UI;

public class ButtonMessage : MonoBehaviour
{
    public string message;

    public void OnButtonClick()
    {
        Debug.Log(message);
    }
}
