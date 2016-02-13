using UnityEngine;
using System.Collections;
using System.IO;
using System.Collections.Generic;

public static class InformationSystem : MonoBehaviour {

	ArrayList 
	// Use this for initialization
	void Load() {
		var reader = new StreamReader(File.OpenRead(@"C:\test.csv"));

		while (!reader.EndOfStream)
		{
			string character_line = reader.ReadLine().Split("|");
			string character_name = character_line[0];
			string characters_blocks = character_line[1];
			List<string> blocks = new List<string>();
			foreach (string block in characters_blocks.Split(";")){
				blocks.Add(block);
				List<string> block_data = new List<string>();
				foreach (string block in blocks){
					block_data.Add(block.Split(','));
				}
			}
		}
		ArrayList characters;
		characters = GameObject.FindGameObjectsWithTag("Character");
		foreach (GameObject character in characters){
			character.infoOwned = 
		}
	}
}
