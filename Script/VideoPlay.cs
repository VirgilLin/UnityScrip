using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class VideoPlay : MonoBehaviour {
    public VideoPlayer m_video;
    public Image m_image;

    public void VideoControl()
    {
        if (m_video.isPlaying)
        {
            m_video.Pause();
            m_image.color = new Vector4(255, 255, 255, 255);
        }
        else
        {
            m_video.Play();
            m_image.color = new Vector4(255,255,255,0);
        }
    }
    public void VideoHide()
    {
        m_video.Pause();
        m_image.color = new Vector4(255, 255, 255, 0);
    }
    public void VideoShow()
    {
        m_image.color = new Vector4(255, 255, 255, 255);
    }
}
