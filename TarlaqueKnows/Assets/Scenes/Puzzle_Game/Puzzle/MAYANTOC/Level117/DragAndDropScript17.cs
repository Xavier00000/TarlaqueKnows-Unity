using System.Linq;
using UnityEngine;
using System.Collections;

public class DragAndDropScript17 : MonoBehaviour
{
    AudioManager audioManager;
    public GameObject[] ImageChoices;
    public GameObject[] ImageContainer;
    public Vector2[] ImagePosition = new Vector2[9];
    public bool[] isAlreadyCorrect = new bool[9];
    public int[] unsolvedPiecesIndex;
    public int unsolvedPiecesCurrentIndex = 0;
    public Animator anim;

    private void Awake()
    {
        audioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<AudioManager>();
    }

    void Start()
    {
        for (int i = 0; i < ImageChoices.Length; i++)
        {
            ImagePosition[i] = ImageChoices[i].transform.position;
            isAlreadyCorrect[i] = false;
        }
        unsolvedPiecesIndex = new int[ImageChoices.Length];
    }

    public void RemainUnsolved()
    {
        unsolvedPiecesCurrentIndex = 0;

        for (int ctr = 0; ctr < isAlreadyCorrect.Length; ctr++)
        {
            if (!isAlreadyCorrect[ctr])
            {
                unsolvedPiecesIndex[unsolvedPiecesCurrentIndex] = ctr;
                unsolvedPiecesCurrentIndex++;
            }
        }
    }


    public void isCorrect()
    {
        bool allCorrect = true;

        for (int ctr = 0; ctr < isAlreadyCorrect.Length; ctr++)
        {
            
            if (!isAlreadyCorrect[ctr])
            {
                allCorrect = false;
                break;
            }
        }

        if (allCorrect)
        {
            audioManager.PlaySFX(audioManager.passed);
            anim.Play("Show_Info");
            FinishedLevelP.isLevelFinished[17] = true;
            HintPointsPuzzle.puzzleTrials = 0;
        }
    }

    public void dragImage(int index)
{
    if (!isAlreadyCorrect[index])
    {
        ImageChoices[index].transform.position = Input.mousePosition;
        ImageChoices[index].transform.SetSiblingIndex(9);

        // If the piece at index 0, make sure it stays on top during dragging
        if (index == 0)
        {
            for (int i = 1; i < ImageChoices.Length; i++)
            {
                ImageChoices[i].transform.SetSiblingIndex(1);
            }
        }
    }
    else
    {
        // Puzzle piece is already in the correct position, stop the SFX
        StartCoroutine(StopSFXAfterDelay(audioManager.SFXSource, 0.0f)); // Stop immediately
    }
}

    public void dropImage(int index)
    {
        float Distance = Vector3.Distance(ImageChoices[index].transform.position, ImageContainer[index].transform.position);

        float[] containerDistance = new float[ImageContainer.Length];
        for (int i = 0; i < containerDistance.Length; i++)
        {
            containerDistance[i] = Vector3.Distance(ImageChoices[index].transform.position, ImageContainer[i].transform.position);
            if (containerDistance[i] <= 15)
            {
                HintPoints.puzzleTrials++;
            }
        }

        if (Distance <= 100)
        {
            isAlreadyCorrect[index] = true;
            ImageChoices[index].transform.position = ImageContainer[index].transform.position;
            ImageChoices[index].transform.SetSiblingIndex(1);

            // Check if the piece is not already in the unsolved pieces array
            if (!unsolvedPiecesIndex.Contains(index))
            {
                // Expand the array and add the index
                unsolvedPiecesIndex = unsolvedPiecesIndex.Concat(new int[] { index }).ToArray();
                unsolvedPiecesCurrentIndex++;
            }

            RemainUnsolved();
            isCorrect();

            // Play the SFX for correct position
            audioManager.PlaySFX(audioManager.drag);
        }
        else
        {
            // Play the SFX for incorrect
            /*audioManager.PlaySFX(audioManager.reset);*/
            audioManager.PlaySFX(audioManager.error);
            isAlreadyCorrect[index] = false;
            ImageChoices[index].transform.position = ImagePosition[index];
            ImageChoices[index].transform.SetSiblingIndex(1);

            /*// Stop the SFX after a short delay only for incorrect positions
            StartCoroutine(StopSFXAfterDelay(audioManager.SFXSource, 1.0f)); // Adjust the delay as needed*/
        }
    }

    // Coroutine to stop SFX after a delay
    private IEnumerator StopSFXAfterDelay(AudioSource audioSource, float delay)
    {
        yield return new WaitForSeconds(delay);
        audioSource.Stop();
        audioSource.clip = null; // Clear the clip to ensure it doesn't interfere with other sounds
    }
}
