namespace VRTK.Examples {
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;
    using VRTK.Controllables;

    public class ControllableReactor : MonoBehaviour {
        public VRTK_BaseControllable controllable;
        public TextMeshPro displayText;
        public string outputOnMax = "Maximum Reached";
        public string outputOnMin = "Minimum Reached";

        public int mytag;
        public DrawLines dl;

        protected virtual void OnEnable() {
            controllable = (controllable == null ? GetComponent<VRTK_BaseControllable>() : controllable);
            controllable.ValueChanged += ValueChanged;
            controllable.MaxLimitReached += MaxLimitReached;
            controllable.MinLimitReached += MinLimitReached;
        }

        protected virtual void ValueChanged(object sender, ControllableEventArgs e) {
            if (displayText != null) {
                displayText.text = e.value.ToString("F1");
            }
            if (dl != null)
                dl.UpdateLinePosition(mytag, transform.position);
        }

        protected virtual void MaxLimitReached(object sender, ControllableEventArgs e) {
            if (outputOnMax != "") {
                Debug.Log(outputOnMax);
            }
        }

        protected virtual void MinLimitReached(object sender, ControllableEventArgs e) {
            if (outputOnMin != "") {
                Debug.Log(outputOnMin);
            }
        }
    }
}