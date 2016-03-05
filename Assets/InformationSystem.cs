using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;
using Fungus;

public class InformationSystem : MonoBehaviour {


	// Use this for initialization
	void Start () {
		var reader = new StreamReader(File.OpenRead(@"C:\test.dat"));
		
		Dictionary<string, List<InformationBase>> info_dictionary =
			new Dictionary<string, List<InformationBase>>();
		
		while (!reader.EndOfStream)
		{
			string[] character_line = reader.ReadLine().Split('|');
			string character_name = character_line[0];
			string characters_blocks = character_line[1];
			List<InformationBase> character_information = new List<InformationBase>();
			foreach (string information_data in characters_blocks.Split(';')){
				string[] block_data = information_data.Split (',');
				InformationBase info = new InformationBase(block_data[0],block_data[1],block_data[2]);
				character_information.Add(info);
			}
			info_dictionary.Add(character_name,character_information);
		}

		foreach(GameObject character_game_object in GameObject.FindGameObjectsWithTag("Character")){
			character_game_object.AddComponent<CharacterData>();
			CharacterData character = character_game_object.GetComponent<CharacterData>();
			string character_name = character_game_object.GetComponent<Character>().name;
			if (info_dictionary.ContainsKey(character_name))
			{
				character.infoOwned = info_dictionary[character_name];
			}
		}

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	// Use this for initialization
	void Load() {
	}
}