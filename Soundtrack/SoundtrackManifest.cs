﻿using UnityEngine;

namespace TNHBGLoader.Soundtrack {
	
	public struct Track {
		public AudioClip clip;
		public string[]  metadata; //sip (Skip In Place), dnf (Do Not Fade), loop
		public string    name;
		public string    type;
	}
	
	public class SoundtrackManifest {
		//Name of the soundtrack
		public string         Name;
		//Path of the soundtrack in the filesystem
		public string         Path;
		//GUID of the soundtrack
		public string         Guid;
		//Location of where the soundtracks are located, relative to the yamlfest.
		public string		  Location;
		//List of potential Hold songs
		public HoldData[]	  Holds;
		//List of potential Take songs
		public TakeData[]     Takes;
	}
	
	//Audio files used during the Hold phase
	public class HoldData {
		//Timing dictates when and where the sequence may be played
		public string    Timing;
		//Name. Doesn't do much of anything, really.
		public string    Name;
		//Right when you touch the hold cube
		public Track[] Intro;
		//Plays after intro
		public Track[] Lo;
		//Transition to MedHi
		public Track[] Transition;
		//Plays at later stages of the hold
		public Track[] MedHi;
		//End of the hold
		public Track[] End;
	}
	
	//Metadata for the Take phase
	public class TakeData {
		//Timing dictates when and where the sequence may be played
		public string    Timing;
		//Name. Doesn't do much of anything, really.
		public string    Name;
		//Looping track during the take
		//Takes don't have any metadata, so don't worry about it not being a Track and being an AudioClip.
		public AudioClip Track;
	}
}