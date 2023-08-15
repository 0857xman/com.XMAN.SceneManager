using UnityEngine;
using UnityEngine.SceneManagement;

namespace XMAN.SceneManager
{
    /// <summary>
    /// 場景控制器：進入遊戲、退出遊戲
    /// </summary>
    public class ScreenManager : MonoBehaviour
    {

        [SerializeField, Range(0.2f, 1.2f), Header("音效時間")]
        private float soundDuration = 0.8f;


        private string changedScene;
        /// <summary>
        /// 用字串名稱更換場景
        /// </summary>
        /// <param name="nameScene"></param>
        public void ChangeScreen(string nameScene)
        {
            changedScene = nameScene;
            Invoke("DelayChangedScene", soundDuration);
        }

        private void DelayChangedScene()
        {
            
            SceneManager.LoadScene(changedScene);
            //SceneManager.LoadScene(1);
        }
        /// <summary>
        /// 離開遊戲
        /// </summary>
        public void Quit()
        {
            Invoke("DelayQuit", soundDuration);
        }

        private void DelayQuit()
        {
            Application.Quit();
        }
    }

}

