using UnityEngine;

public class Credits : MonoBehaviour
{
    public void Quit()   //每當按下quit便會運行
    {
        Debug.Log("Quit");
        Application.Quit();

    }
}
