using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public void PushButtonSendRecv()
    {
        SceneManager.LoadSceneAsync("multi_sendrecv");
    }
    public void PushButtonSendOnly()
    {
        SceneManager.LoadSceneAsync("multi_sendonly");
    }
    public void PushButtonRecvOnly()
    {
        SceneManager.LoadSceneAsync("multi_recvonly");
    }
}
