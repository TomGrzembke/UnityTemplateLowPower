using UnityEngine;

public class FPS : MonoBehaviour
{
    [SerializeField]  int targetFrameRate = 60;
    
    void Start()
    {
        Application.targetFrameRate = targetFrameRate;
    }
}
