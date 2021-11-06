using UnityEngine;
using UnityEngine.SceneManagement;

namespace UI {
    public class ChangeSceneClickResponse : MonoBehaviour, IClickResponse {
        public void OnButtonClicked() {
            SceneManager.LoadScene("Assets/Scenes/LevelScene.unity", LoadSceneMode.Single);
        }
    }
}