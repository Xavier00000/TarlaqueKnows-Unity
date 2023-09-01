using UnityEngine;

public class DragAndDropScript25 : MonoBehaviour
{
    public GameObject[] ImageChoices;
    public GameObject[] ImageContainer;
    public Vector2[] ImagePosition = new Vector2[12];
    public bool[] isAlreadyCorrect = new bool[12];
    public int[] unsolvedPiecesIndex = new int[1];
    public int unsolvedPiecesCurrentIndex=0;
    public Animator anim;
    void Start()
    {
        ImagePosition[0] = ImageChoices[0].transform.position;  
        ImagePosition[1] = ImageChoices[1].transform.position;
        ImagePosition[2] = ImageChoices[2].transform.position;  
        ImagePosition[3] = ImageChoices[3].transform.position;
        ImagePosition[4] = ImageChoices[4].transform.position;  
        ImagePosition[5] = ImageChoices[5].transform.position;
        ImagePosition[6] = ImageChoices[6].transform.position;  
        ImagePosition[7] = ImageChoices[7].transform.position;
        ImagePosition[8] = ImageChoices[8].transform.position;
        ImagePosition[9] = ImageChoices[9].transform.position;
        ImagePosition[10] = ImageChoices[10].transform.position;
        ImagePosition[11] = ImageChoices[11].transform.position;
        for(int ctr=0; ctr<isAlreadyCorrect.Length; ctr++)
        {
            isAlreadyCorrect[ctr] = false;
        }
        for(int ctr=0; ctr<isAlreadyCorrect.Length; ctr++)
        {            
            if(isAlreadyCorrect[ctr]==false)
            {
                unsolvedPiecesIndex = new int[unsolvedPiecesIndex.Length+1];
                unsolvedPiecesIndex[unsolvedPiecesCurrentIndex]+=ctr;
                unsolvedPiecesCurrentIndex++;
            }
        }
    }

    
    public void RemainUnsolved()
    {
        for(int ctr=0; ctr<isAlreadyCorrect.Length; ctr++)
        {            
            if(isAlreadyCorrect[ctr]==false)
            {
                unsolvedPiecesIndex = new int[unsolvedPiecesIndex.Length+1];
                unsolvedPiecesIndex[unsolvedPiecesCurrentIndex]+=ctr;
                unsolvedPiecesCurrentIndex++;
            }
        }
    }
    public void isCorrect()
    {
        for(int ctr=0; ctr<isAlreadyCorrect.Length; ctr++)
        {
            if(isAlreadyCorrect[0]==true && isAlreadyCorrect[1]==true &&
            isAlreadyCorrect[2]==true && isAlreadyCorrect[3]==true &&
            isAlreadyCorrect[4]==true && isAlreadyCorrect[5]==true &&
            isAlreadyCorrect[6]==true && isAlreadyCorrect[7]==true &&
            isAlreadyCorrect[8]==true && isAlreadyCorrect[9]==true &&
            isAlreadyCorrect[10]==true && isAlreadyCorrect[11]==true)
            {
                anim.Play("Show_Info");
                FinishedLevel.isLevelFinished[24]=true;
                HintPoints.puzzleTrials=0;
                break;
            }
        }
    }
    
    public void dragImage()
    {
        ImageChoices[0].transform.position = Input.mousePosition;
        ImageChoices[0].transform.SetSiblingIndex(12);
    }
    public void dragImage02()
    {
        ImageChoices[1].transform.position = Input.mousePosition;
        ImageChoices[1].transform.SetSiblingIndex(12);
    }
    public void dragImage03()
    {
        ImageChoices[2].transform.position = Input.mousePosition;
        ImageChoices[2].transform.SetSiblingIndex(12);
    }
    public void dragImage04()
    {
        ImageChoices[3].transform.position = Input.mousePosition;
        ImageChoices[3].transform.SetSiblingIndex(12);
    }
    public void dragImage05()
    {
        ImageChoices[4].transform.position = Input.mousePosition;
        ImageChoices[4].transform.SetSiblingIndex(12);
    }
    public void dragImage06()
    {
        ImageChoices[5].transform.position = Input.mousePosition;
        ImageChoices[5].transform.SetSiblingIndex(12);
    }
    public void dragImage07()
    {
        ImageChoices[6].transform.position = Input.mousePosition;
        ImageChoices[6].transform.SetSiblingIndex(12);
    }
    public void dragImage08()
    {
        ImageChoices[7].transform.position = Input.mousePosition;
        ImageChoices[7].transform.SetSiblingIndex(12);
    }
    public void dragImage09()
    {
        ImageChoices[8].transform.position = Input.mousePosition;
        ImageChoices[8].transform.SetSiblingIndex(12);
    }
    public void dragImage10()
    {
        ImageChoices[9].transform.position = Input.mousePosition;
        ImageChoices[9].transform.SetSiblingIndex(12);
    }
    public void dragImage11()
    {
        ImageChoices[10].transform.position = Input.mousePosition;
        ImageChoices[10].transform.SetSiblingIndex(12);
    }
    public void dragImage12()
    {
        ImageChoices[11].transform.position = Input.mousePosition;
        ImageChoices[11].transform.SetSiblingIndex(12);
    }


    /*-------------------------------------------DROP--------------------------------------------*/
    public void dropImage()
    {
        float Distance = Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[0].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[1].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[2].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[3].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[4].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[5].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[6].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[8].transform.position);  
        containerDistance[8] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[9].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[0].transform.position, ImageContainer[11].transform.position);  
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[0]=true;
            ImageChoices[0].transform.position = ImageContainer[0].transform.position;
            ImageChoices[0].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else
        {
            isAlreadyCorrect[0]=false;
            ImageChoices[0].transform.position = ImagePosition[0];
            ImageChoices[0].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage02()
    {
        float Distance = Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[1].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[2].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[3].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[4].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[5].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[6].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[8].transform.position);  
        containerDistance[8] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[9].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[1].transform.position, ImageContainer[11].transform.position);    
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[1]=true;
            ImageChoices[1].transform.position = ImageContainer[1].transform.position;
            ImageChoices[1].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else
        {
            isAlreadyCorrect[1]=false;
            ImageChoices[1].transform.position = ImagePosition[1];
            ImageChoices[1].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage03()
    {
        float Distance = Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[2].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[3].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[4].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[5].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[6].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[8].transform.position);
        containerDistance[8] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[9].transform.position); 
        containerDistance[9] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[2].transform.position, ImageContainer[11].transform.position);     
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[2]=true;
            ImageChoices[2].transform.position = ImageContainer[2].transform.position;
            ImageChoices[02].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else
        {
            isAlreadyCorrect[2]=false;
            ImageChoices[2].transform.position = ImagePosition[2];
            ImageChoices[2].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage04()
    {
        float Distance = Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[3].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[4].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[5].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[6].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[8].transform.position);
        containerDistance[8] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[9].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[3].transform.position, ImageContainer[11].transform.position);       
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[3]=true;
            ImageChoices[3].transform.position = ImageContainer[3].transform.position;
            ImageChoices[3].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[3]=false;
            ImageChoices[3].transform.position = ImagePosition[3];
            ImageChoices[3].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage05()
    {
        float Distance = Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[4].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[5].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[6].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[8].transform.position); 
        containerDistance[8] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[9].transform.position); 
        containerDistance[9] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[4].transform.position, ImageContainer[11].transform.position);  
    
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[4]=true;
            ImageChoices[4].transform.position = ImageContainer[4].transform.position;
            ImageChoices[4].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[4]=false;
            ImageChoices[4].transform.position = ImagePosition[4];
            ImageChoices[4].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage06()
    {
        float Distance = Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[5].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[6].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[8].transform.position);
        containerDistance[8] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[9].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[5].transform.position, ImageContainer[11].transform.position);        
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[5]=true;
            ImageChoices[5].transform.position = ImageContainer[5].transform.position;
            ImageChoices[5].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[5]=false;
            ImageChoices[5].transform.position = ImagePosition[5];
            ImageChoices[5].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage07()
    {
        float Distance = Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[6].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[5].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[7].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[8].transform.position); 
        containerDistance[8] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[9].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[6].transform.position, ImageContainer[11].transform.position);      
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[6]=true;
            ImageChoices[6].transform.position = ImageContainer[6].transform.position;
            ImageChoices[6].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[6]=false;
            ImageChoices[6].transform.position = ImagePosition[6];
            ImageChoices[6].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage08()
    {
        float Distance = Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[7].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[5].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[6].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[8].transform.position);   
        containerDistance[8] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[9].transform.position); 
        containerDistance[9] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[7].transform.position, ImageContainer[11].transform.position);   
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[7]=true;
            ImageChoices[7].transform.position = ImageContainer[7].transform.position;
            ImageChoices[7].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[7]=false;
            ImageChoices[7].transform.position = ImagePosition[7];
            ImageChoices[7].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage09()
    {
        float Distance = Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[8].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[5].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[6].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[7].transform.position);  
        containerDistance[8] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[9].transform.position); 
        containerDistance[9] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[8].transform.position, ImageContainer[11].transform.position);     
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[8]=true;
            ImageChoices[8].transform.position = ImageContainer[8].transform.position;
            ImageChoices[8].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[8]=false;
            ImageChoices[8].transform.position = ImagePosition[8];
            ImageChoices[8].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage10()
    {
        float Distance = Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[9].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[5].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[6].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[7].transform.position); 
        containerDistance[8] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[8].transform.position); 
        containerDistance[9] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[10].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[9].transform.position, ImageContainer[11].transform.position);      
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[9]=true;
            ImageChoices[9].transform.position = ImageContainer[9].transform.position;
            ImageChoices[9].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[9]=false;
            ImageChoices[9].transform.position = ImagePosition[9];
            ImageChoices[9].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage11()
    {
        float Distance = Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[10].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[5].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[6].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[7].transform.position); 
        containerDistance[8] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[8].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[9].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[10].transform.position, ImageContainer[11].transform.position);       
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[10]=true;
            ImageChoices[10].transform.position = ImageContainer[10].transform.position;
            ImageChoices[10].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[10]=false;
            ImageChoices[10].transform.position = ImagePosition[10];
            ImageChoices[10].transform.SetSiblingIndex(1);
        }
    }
    public void dropImage12()
    {
        float Distance = Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[11].transform.position);
        float[] containerDistance = new float[11];
        containerDistance[0] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[0].transform.position);
        containerDistance[1] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[1].transform.position);
        containerDistance[2] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[2].transform.position);
        containerDistance[3] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[3].transform.position);
        containerDistance[4] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[4].transform.position);
        containerDistance[5] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[5].transform.position);
        containerDistance[6] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[6].transform.position);
        containerDistance[7] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[7].transform.position); 
        containerDistance[8] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[8].transform.position);
        containerDistance[9] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[9].transform.position);
        containerDistance[10] =  Vector3.Distance(ImageChoices[11].transform.position, ImageContainer[10].transform.position);       
        for(int ctr=0; ctr<containerDistance.Length; ctr++)
        {
            if(containerDistance[ctr]<=15)
            {
                HintPoints.puzzleTrials++;
            }
        }
        if(Distance<=15)
        {
            isAlreadyCorrect[11]=true;
            ImageChoices[11].transform.position = ImageContainer[11].transform.position;
            ImageChoices[11].transform.SetSiblingIndex(1);
            unsolvedPiecesIndex = new int[1];
            unsolvedPiecesCurrentIndex=0;
            RemainUnsolved();
            isCorrect();
        }
        else{
            isAlreadyCorrect[11]=false;
            ImageChoices[11].transform.position = ImagePosition[11];
            ImageChoices[11].transform.SetSiblingIndex(1);
        }
    }
}
