using UnityEngine;

public class ResolutionManager : MonoBehaviour
{
    public Vector2 targetResolution = new Vector2(1920, 1080); // Your target resolution.
    public float minOrthographicSize = 5f;
    public float maxOrthographicSize = 10f;
    public RectTransform[] uiElementsToAdjust; // Add your UI elements here.
    public bool adjustForSafeArea = true; // Adjust for safe area on mobile devices.

    private Camera mainCamera;

    private void Start()
    {
        mainCamera = Camera.main;

        // Calculate the target aspect ratio.
        float targetAspect = targetResolution.x / targetResolution.y;

        // Get the current screen's aspect ratio.
        float screenAspect = (float)Screen.width / Screen.height;

        // Calculate the desired orthographic size.
        float orthoSize = targetAspect / screenAspect;

        // Clamp the orthographic size to a specified range.
        orthoSize = Mathf.Clamp(orthoSize, minOrthographicSize, maxOrthographicSize);

        // Set the camera's orthographic size.
        mainCamera.orthographicSize = orthoSize;

        // Adjust UI elements if needed.
        if (uiElementsToAdjust != null)
        {
            foreach (RectTransform uiElement in uiElementsToAdjust)
            {
                // Adjust the position of UI elements to fit the new resolution and aspect ratio.
                Vector3 adjustedPosition = uiElement.anchoredPosition * orthoSize / minOrthographicSize;
                uiElement.anchoredPosition = adjustedPosition;
            }
        }

        // Adjust for safe area if enabled (for mobile devices).
        if (adjustForSafeArea && Application.isMobilePlatform)
        {
            Rect safeArea = Screen.safeArea;

            // You can use safeArea properties to adjust your UI elements as needed.
            // For example, you can adapt your UI positions or sizes to avoid the safe area.

            // Example:
            // Adjust the position of UI elements to avoid the safe area.
            foreach (RectTransform uiElement in uiElementsToAdjust)
            {
                Vector2 adjustedPosition = uiElement.anchoredPosition;

                if (adjustedPosition.x < safeArea.x)
                {
                    adjustedPosition.x = safeArea.x;
                }

                if (adjustedPosition.x > safeArea.x + safeArea.width)
                {
                    adjustedPosition.x = safeArea.x + safeArea.width;
                }

                if (adjustedPosition.y < safeArea.y)
                {
                    adjustedPosition.y = safeArea.y;
                }

                if (adjustedPosition.y > safeArea.y + safeArea.height)
                {
                    adjustedPosition.y = safeArea.y + safeArea.height;
                }

                uiElement.anchoredPosition = adjustedPosition;
            }
        }
    }
}
