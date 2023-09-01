using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneChangerR1 : MonoBehaviour
{
    public Animator Animation;
    public GameObject PlayerStandBy,Face,Dialogue,PlayerWalking;
    int AnimIndex=0;
    public void NextAnimScene()
    {
        AnimIndex++;
        if(AnimIndex==1)
        {
            Animation.Play("Entering Room");
            PlayerStandBy.SetActive(false);
            Face.SetActive(false);
            Dialogue.SetActive(false);
        }

    }
    public void MAPEHRoom()
    {
        SceneManager.LoadScene("Math Room");
    }
    public void Room()
    {
        SceneManager.LoadScene("Room");
    }
    
}
