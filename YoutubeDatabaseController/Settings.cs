﻿using System;

namespace YoutubeDatabaseController {
    public class Settings {
        public static String StartupMessage = 
            "------------------ RUN START ------------------\n" + 
           $"{DateTime.Now:F}\n" +
            "Target YoutubeChannel Dump\n" +
            "Tool was Created By ReiRokusanami\n" +
            "-----------------------------------------------\n";

        // Production Names
        public static readonly string Hololive = "Hololive";
        public static readonly string Nijisanji = "Nijisanji";
        public static readonly string AniMare = "Animare";
        
        // Server
        public static readonly string NekomataAws   = "ec2-3-91-37-39.compute-1.amazonaws.com";
        public static readonly string NekomataLocal = "192.168.0.5";

        // Config Dir
        public static readonly string ConfigDir = AppDomain.CurrentDomain.BaseDirectory + "Config\\";
        
        //Mongo Auth
        public static string User { get; set; }
        public static string Pass { get; set; }

    }
    
}