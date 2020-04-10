using AnyRPG;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace AnyRPG {
    public class CharacterClassButton : TransparencyButton {

        [SerializeField]
        private CharacterClass characterClass = null;

        [SerializeField]
        private Image icon = null;

        [SerializeField]
        private TextMeshProUGUI characterClassName = null;

        [SerializeField]
        private TextMeshProUGUI description = null;

        public void AddCharacterClass(CharacterClass newCharacterClass) {
            characterClass = newCharacterClass;
            icon.sprite = this.characterClass.MyIcon;
            icon.color = Color.white;
            characterClassName.text = characterClass.MyName;
            //description.text = this.faction.GetSummary();
            description.text = characterClass.GetSummary();

        }

        public void ClearCharacterClass() {
            icon.sprite = null;
            icon.color = new Color32(0, 0, 0, 0);
            characterClassName.text = string.Empty;
            description.text = string.Empty;
        }


    }

}