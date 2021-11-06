using Platformer.Model;
using TMPro;
using Unity.InteractiveTutorials;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Platformer.UI {
    public class MainMenuCanvas : MonoBehaviour {
        [SerializeField] private TMP_InputField inputUsername;
        [SerializeField] private Button btnPlay;

        private static MainMenuCanvas _instance;
        public static MainMenuCanvas Instance => _instance;

        void Awake() {
            if (_instance == null) _instance = this;

            // Since I'm setting button.interactable only when the InputField value is changed it won't check the value at the start of the game
            // Could be set in Inspector
            btnPlay.interactable = false;
            inputUsername.onValueChanged.AddListener(OnUsernameInputChanged);
            inputUsername.text = GameDatabase.Instance.CurrentUser.Username;
        }

        private void OnDestroy() {
            inputUsername.onValueChanged.RemoveListener(OnUsernameInputChanged);
        }

        #region Event Handlers

        private void OnUsernameInputChanged(string newName) {
            GameDatabase.Instance.SetUsername(newName);
            btnPlay.interactable = newName.IsNotNullOrEmpty();
        }

        /*
        public void BtnPlayClicked() {
            SceneManager.LoadScene("Assets/Scenes/LevelScene.unity", LoadSceneMode.Single);
        }
        */

        #endregion Event Handlers
    }
}