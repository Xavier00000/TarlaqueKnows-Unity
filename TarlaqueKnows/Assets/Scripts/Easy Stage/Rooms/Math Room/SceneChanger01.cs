using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;

public class SceneChanger01 : MonoBehaviour
{
    public Animator Animation;
    public Text dialogueText;
    int AnimIndex=0;
    public void NextAnimScene()
    {        
        if(AnimIndex==0)
        {
            Animation.Play("Read_Sign");
            dialogueText.text ="There's a sign and a box!";
            AnimIndex++;
        }
        else if(AnimIndex==1)
        {
            dialogueText.text ="It says there's a key on it and I need to complete the levels to unlock it!";
            AnimIndex++;
        }
        else if(AnimIndex==2)
        {
            Animation.Play("PickUp_Box");
            dialogueText.text = "Let's do this!";
            AnimIndex++;
        }
        else if(AnimIndex==3)
        {
            Animation.Play("Leave_Room");
        }

    }
    public void MAPEHRoom()
    {
        SceneManager.LoadScene("Room");
    }
    public void EasyRoom01()
    {
        SceneManager.LoadScene("EasyRoom01");
    }
    
}
