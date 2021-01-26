using UnityEngine;
using System.Collections;


public class CanvasHelper : MonoBehaviour {
    public static IEnumerator FadeCanvasGroupAlpha(float startAlpha, float endAlpha, float duration, CanvasGroup canvasGroupToFadeAlpha)
    {
        float elapsedTime = 0f;
        while (elapsedTime < duration)
        {
            elapsedTime += Time.deltaTime;
            float currentAlpha = Mathf.Lerp(startAlpha, endAlpha, elapsedTime / duration);
            canvasGroupToFadeAlpha.alpha = currentAlpha;
            yield return null;
        }
    }
}
