using UnityEngine;
using UnityEngine.Video;

public class EndoDie : MonoBehaviour
{
    private VideoPlayer videoPlayer;

    void OnEnable()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        videoPlayer.loopPointReached += OnVideoEnd;
    }
    void OnDisable()
    {
        videoPlayer.loopPointReached -= OnVideoEnd;
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        gameObject.SetActive(false);
        videoPlayer.Stop();
    }
}
