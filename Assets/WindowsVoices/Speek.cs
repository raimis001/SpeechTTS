using UnityEngine;
//using System.Speech.Synthesis;

public class Speek : MonoBehaviour
{
    private void Start()
    {
       

        WindowsVoice.speak("you did it");
    }
}
