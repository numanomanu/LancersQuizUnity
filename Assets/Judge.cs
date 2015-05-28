using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Judge : MonoBehaviour {
	 
	//選択したボタンのテキストラベルと正解のテキストを比較して正誤を判定
	public void JudgeAnswer(){
		//正解のデータをテキストでセットする
		string answerText = "7歳";
		//選択したボタンのテキストラベルを取得する
		Text selectedBtn = this.GetComponentInChildren<Text> ();

		if (selectedBtn.text == answerText) {
			//選択したデータをグローバル変数に保存
			ResultMgr.SetJudgeData ("正解");
			Application.LoadLevel ("Result");
		} else {
			//選択したデータをグローバル変数に保存
			ResultMgr.SetJudgeData ("不正解");
			Application.LoadLevel ("Result");
		}

	}

}
