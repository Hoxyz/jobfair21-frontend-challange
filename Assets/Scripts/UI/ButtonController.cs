using Platformer.Model;
using Platformer.UI;
using Unity.InteractiveTutorials;
using UnityEngine;

namespace UI {
    public class ButtonController : MonoBehaviour {

        private IClickResponse clickResponse;

        private void Awake() {
            clickResponse = GetComponent<IClickResponse>();
        }

        public void OnButtonClicked() {
            clickResponse?.OnButtonClicked();
        }
    }
}