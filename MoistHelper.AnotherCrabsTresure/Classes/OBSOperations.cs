using IWshRuntimeLibrary;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using File = System.IO.File;

class OBSOperations
{
    private static string obsPath = GetDirectoryOBS();
    private static string obsParentPath = Path.GetDirectoryName(obsPath);
    private static string obsConfigPath = GetDirectoryOBSConfig();

    public static bool AddControllerInputOverlay()
    {
        try
        {
            if (!IsOBSRunning())
            {
                string profileName = GetCurrentProfileName();
                if (profileName != "")
                {
                    string jsonConfigPath = Path.Combine(obsConfigPath, "basic", "scenes", profileName + ".json");

                    if (File.Exists(jsonConfigPath))
                    {
                        JObject jObject = JObject.Parse(File.ReadAllText(jsonConfigPath));

                        string current_scene = "";
                        if (jObject.ContainsKey("current_scene"))
                        {
                            current_scene = jObject["current_scene"].ToString();
                            if (current_scene != "")
                            {
                                // quickly extract prev_version
                                string prev_verString = "";
                                string parsedJson = jObject.ToString();
                                if (parsedJson.Contains("\"prev_ver\": "))
                                {
                                    string newR = parsedJson.Remove(0, parsedJson.IndexOf("\"prev_ver\": "));
                                    newR = newR.Remove(0, 12);

                                    int stopComma = newR.IndexOf(",");
                                    if (stopComma != -1)
                                    {
                                        prev_verString = newR.Remove(stopComma);
                                    }
                                }

                                int prev_ver = 0;
                                if (prev_verString == "") prev_verString = "503382018";
                                else if (!int.TryParse(prev_verString, out prev_ver))
                                {
                                    prev_ver = 503382018;
                                }

                                string newGuid = Guid.NewGuid().ToString();
                                if (jObject.ContainsKey("sources"))
                                {
                                    JArray sources = (JArray)jObject["sources"];
                                    foreach (JObject source in sources)
                                    {
                                        if (source["name"].ToString() == current_scene && source["id"].ToString() == "scene")
                                        {
                                            if (source.ContainsKey("settings"))
                                            {
                                                JObject settings = (JObject)source["settings"];
                                                if (settings.ContainsKey("items"))
                                                {
                                                    int id_counter = (int)settings["id_counter"] + 1;
                                                    settings["id_counter"] = id_counter;
                                                    JArray items = (JArray)settings["items"];

                                                    JObject externalInputWindowCaptureItem = new JObject
                                                    {
                                                        ["name"] = "ControllerOverlay",
                                                        ["source_uuid"] = newGuid,
                                                        ["visible"] = true,
                                                        ["locked"] = false,
                                                        ["rot"] = 0,
                                                        ["pos"] = new JObject
                                                        {
                                                            ["x"] = 0,
                                                            ["y"] = 0
                                                        },
                                                        ["scale"] = new JObject
                                                        {
                                                            ["x"] = 0.42500001192092896f,
                                                            ["y"] = 0.42500001192092896f
                                                        },
                                                        ["align"] = 5,
                                                        ["bounds_type"] = 0,
                                                        ["bounds_align"] = 0,
                                                        ["bounds_crop"] = false,
                                                        ["bounds"] = new JObject
                                                        {
                                                            ["x"] = 0,
                                                            ["y"] = 0
                                                        },
                                                        ["crop_left"] = 0,
                                                        ["crop_top"] = 0,
                                                        ["crop_right"] = 0,
                                                        ["crop_bottom"] = 0,
                                                        ["id"] = id_counter,
                                                        ["group_item_backup"] = false,
                                                        ["scale_filter"] = "disable",
                                                        ["blend_method"] = "default",
                                                        ["blend_type"] = "normal",
                                                        ["show_transition"] = new JObject
                                                        {
                                                            ["duration"] = 0
                                                        },
                                                        ["hide_transition"] = new JObject
                                                        {
                                                            ["duration"] = 0
                                                        },
                                                        ["private_settings"] = new JObject
                                                        {

                                                        }
                                                    };

                                                    JObject externalInputWindowCaptureSource = new JObject
                                                    {
                                                        ["prev_ver"] = prev_ver,
                                                        ["name"] = "ControllerOverlay",
                                                        ["uuid"] = newGuid,
                                                        ["id"] = "browser_source",
                                                        ["versioned_id"] = "browser_source",
                                                        ["settings"] = new JObject
                                                        {
                                                            ["url"] = "https://app.gpv.gg/?p=1"
                                                        },
                                                        ["mixers"] = 255,
                                                        ["sync"] = 0,
                                                        ["flags"] = 0,
                                                        ["volume"] = 1,
                                                        ["balance"] = 0.5f,
                                                        ["enabled"] = true,
                                                        ["muted"] = false,
                                                        ["push-to-mute"] = false,
                                                        ["push-to-mute-delay"] = 0,
                                                        ["push-to-talk"] = false,
                                                        ["push-to-talk-delay"] = 0,
                                                        ["hotkeys"] = new JObject
                                                        {
                                                            ["libobs.mute"] = new JObject
                                                            {

                                                            },
                                                            ["libobs.unmute"] = new JObject
                                                            {

                                                            },
                                                            ["libobs.push-to-talk"] = new JObject
                                                            {

                                                            }
                                                        },
                                                        ["deinterlace_mode"] = 0,
                                                        ["deinterlace_field_order"] = 0,
                                                        ["monitoring_type"] = 0,
                                                        ["private_settings"] = new JObject
                                                        {

                                                        }
                                                    };

                                                    items.Add(externalInputWindowCaptureItem);
                                                    sources.Add(externalInputWindowCaptureSource);
                                                    File.WriteAllText(jsonConfigPath, jObject.ToString());
                                                    ProgramUtils.ShowInfo("Success! Check your OBS =)");
                                                    return true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else ProgramUtils.ShowError("Your OBS is running, close it and try again");
        }
        catch { ProgramUtils.ShowError("Something failed, add the Browser Source, link copied to your clipboard"); }

        return false;
    }

    public static bool AddExternalInputWindow()
    {
        try
        {
            if (!IsOBSRunning())
            {
                string profileName = GetCurrentProfileName();
                if (profileName != "")
                {
                    string jsonConfigPath = Path.Combine(obsConfigPath, "basic", "scenes", profileName + ".json");

                    if (File.Exists(jsonConfigPath))
                    {
                        JObject jObject = JObject.Parse(File.ReadAllText(jsonConfigPath));

                        string current_scene = "";
                        if (jObject.ContainsKey("current_scene"))
                        {
                            current_scene = jObject["current_scene"].ToString();
                            if (current_scene != "")
                            {
                                // quickly extract prev_version
                                string prev_verString = "";
                                string parsedJson = jObject.ToString();
                                if (parsedJson.Contains("\"prev_ver\": "))
                                {
                                    string newR = parsedJson.Remove(0, parsedJson.IndexOf("\"prev_ver\": "));
                                    newR = newR.Remove(0, 12);

                                    int stopComma = newR.IndexOf(",");
                                    if (stopComma != -1)
                                    {
                                        prev_verString = newR.Remove(stopComma);
                                    }
                                }

                                int prev_ver = 0;
                                if (prev_verString == "") prev_verString = "503382018";
                                else if (!int.TryParse(prev_verString, out prev_ver))
                                {
                                    prev_ver = 503382018;
                                }

                                string newGuid = Guid.NewGuid().ToString();
                                if (jObject.ContainsKey("sources"))
                                {
                                    JArray sources = (JArray)jObject["sources"];
                                    foreach (JObject source in sources)
                                    {
                                        if (source["name"].ToString() == current_scene && source["id"].ToString() == "scene")
                                        {
                                            if (source.ContainsKey("settings"))
                                            {
                                                JObject settings = (JObject)source["settings"];
                                                if (settings.ContainsKey("items"))
                                                {
                                                    int id_counter = (int)settings["id_counter"] + 1;
                                                    settings["id_counter"] = id_counter;
                                                    JArray items = (JArray)settings["items"];

                                                    JObject externalInputWindowCaptureItem = new JObject
                                                    {
                                                        ["name"] = "CrabInputs",
                                                        ["source_uuid"] = newGuid,
                                                        ["visible"] = true,
                                                        ["locked"] = false,
                                                        ["rot"] = 0,
                                                        ["pos"] = new JObject
                                                        {
                                                            ["x"] = 0,
                                                            ["y"] = 0
                                                        },
                                                        ["scale"] = new JObject
                                                        {
                                                            ["x"] = 0.9272727370262146f,
                                                            ["y"] = 0.9270073175430298f
                                                        },
                                                        ["align"] = 5,
                                                        ["bounds_type"] = 0,
                                                        ["bounds_align"] = 0,
                                                        ["bounds_crop"] = false,
                                                        ["bounds"] = new JObject
                                                        {
                                                            ["x"] = 0,
                                                            ["y"] = 0
                                                        },
                                                        ["crop_left"] = 0,
                                                        ["crop_top"] = 0,
                                                        ["crop_right"] = 0,
                                                        ["crop_bottom"] = 00,
                                                        ["id"] = id_counter,
                                                        ["group_item_backup"] = false,
                                                        ["scale_filter"] = "disable",
                                                        ["blend_method"] = "default",
                                                        ["blend_type"] = "normal",
                                                        ["show_transition"] = new JObject
                                                        {
                                                            ["duration"] = 0
                                                        },
                                                        ["hide_transition"] = new JObject
                                                        {
                                                            ["duration"] = 0
                                                        },
                                                        ["private_settings"] = new JObject
                                                        {

                                                        }
                                                    };

                                                    JObject externalInputWindowCaptureSource = new JObject
                                                    {
                                                        ["prev_ver"] = prev_ver,
                                                        ["name"] = "CrabInputs",
                                                        ["uuid"] = newGuid,
                                                        ["id"] = "window_capture",
                                                        ["versioned_id"] = "window_capture",
                                                        ["settings"] = new JObject
                                                        {
                                                            ["priority"] = 1,
                                                            ["cursor"] = false,
                                                            ["window"] = "MoistHelper.AnotherCrabsTreasure.ExternalInputOverlay:WindowsForms10.Window.8.app.0.141b42a_r9_ad1:Moist Helper.exe",
                                                        },
                                                        ["mixers"] = 255,
                                                        ["sync"] = 0,
                                                        ["flags"] = 0,
                                                        ["volume"] = 1,
                                                        ["balance"] = 0.5f,
                                                        ["enabled"] = true,
                                                        ["muted"] = false,
                                                        ["push-to-mute"] = false,
                                                        ["push-to-mute-delay"] = 0,
                                                        ["push-to-talk"] = false,
                                                        ["push-to-talk-delay"] = 0,
                                                        ["hotkeys"] = new JObject
                                                        {
                                                            ["libobs.mute"] = new JObject
                                                            {

                                                            },
                                                            ["libobs.unmute"] = new JObject
                                                            {

                                                            },
                                                            ["libobs.push-to-talk"] = new JObject
                                                            {

                                                            }
                                                        },
                                                        ["deinterlace_mode"] = 0,
                                                        ["deinterlace_field_order"] = 0,
                                                        ["monitoring_type"] = 0,
                                                        ["private_settings"] = new JObject
                                                        {

                                                        },
                                                        ["filters"] = new JArray
                                                        {

                                                        }
                                                    };

                                                    JObject filter1 = new JObject
                                                    {
                                                        ["prev_ver"] = prev_ver,
                                                        ["name"] = "Color Key",
                                                        ["uuid"] = newGuid,
                                                        ["id"] = "color_key_filter",
                                                        ["versioned_id"] = "color_key_filter_v2",
                                                        ["settings"] = new JObject
                                                        {
                                                            ["similarity"] = 805
                                                        },
                                                        ["mixers"] = 0,
                                                        ["sync"] = 0,
                                                        ["flags"] = 0,
                                                        ["volume"] = 1,
                                                        ["balance"] = 0.5f,
                                                        ["enabled"] = true,
                                                        ["muted"] = false,
                                                        ["push-to-mute"] = false,
                                                        ["push-to-mute-delay"] = 0,
                                                        ["push-to-talk"] = false,
                                                        ["push-to-talk-delay"] = 0,
                                                        ["hotkeys"] = new JObject
                                                        {

                                                        },
                                                        ["deinterlace_mode"] = 0,
                                                        ["deinterlace_field_order"] = 0,
                                                        ["monitoring_type"] = 0,
                                                        ["private_settings"] = new JObject
                                                        {

                                                        }
                                                    };

                                                    JObject filter2 = new JObject
                                                    {
                                                        ["prev_ver"] = prev_ver,
                                                        ["name"] = "Color Key",
                                                        ["uuid"] = newGuid,
                                                        ["id"] = "color_filter",
                                                        ["versioned_id"] = "color_filter_v2",
                                                        ["settings"] = new JObject
                                                        {
                                                            ["opacity"] = 0.3649f
                                                        },
                                                        ["mixers"] = 0,
                                                        ["sync"] = 0,
                                                        ["flags"] = 0,
                                                        ["volume"] = 1,
                                                        ["balance"] = 0.5f,
                                                        ["enabled"] = true,
                                                        ["muted"] = false,
                                                        ["push-to-mute"] = false,
                                                        ["push-to-mute-delay"] = 0,
                                                        ["push-to-talk"] = false,
                                                        ["push-to-talk-delay"] = 0,
                                                        ["hotkeys"] = new JObject
                                                        {

                                                        },
                                                        ["deinterlace_mode"] = 0,
                                                        ["deinterlace_field_order"] = 0,
                                                        ["monitoring_type"] = 0,
                                                        ["private_settings"] = new JObject
                                                        {

                                                        }
                                                    };
                                                    JArray filters = (JArray)externalInputWindowCaptureSource["filters"];
                                                    filters.Add(filter1); filters.Add(filter2);
                                                    items.Add(externalInputWindowCaptureItem);
                                                    sources.Add(externalInputWindowCaptureSource);
                                                    File.WriteAllText(jsonConfigPath, jObject.ToString());
                                                    ProgramUtils.ShowInfo("Success! Check your OBS =)");
                                                    return true;
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            else ProgramUtils.ShowError("Your OBS is running, close it and try again");
        }
        catch { ProgramUtils.ShowError("Something failed, add the window capture manually :("); }

        return false;
    }

    internal static string GetDirectoryOBS()
    {
        // method 1
        {
            string userStartMenu = Environment.GetFolderPath(Environment.SpecialFolder.StartMenu);
            string commonStartMenu = Environment.GetFolderPath(Environment.SpecialFolder.CommonStartMenu);

            string userStartPrograms = Path.Combine(userStartMenu, "Programs");
            string commonStartPrograms = Path.Combine(commonStartMenu, "Programs");

            List<string> couldBeThePath = new List<string>
                {
                    Path.Combine(userStartPrograms, "OBS Studio"),
                    Path.Combine(commonStartPrograms, "OBS Studio")
                };

            foreach (string path in couldBeThePath)
            {
                if (Directory.Exists(path))
                {
                    string[] filePaths = Directory.GetFiles(path);

                    foreach (string filePath in filePaths)
                    {
                        if (filePath.Contains("OBS Studio"))
                        {
                            WshShell shell = new WshShell();
                            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(filePath);

                            if (File.Exists(shortcut.TargetPath))
                            {
                                string actualOBSDirectory = Path.GetDirectoryName(shortcut.TargetPath);
                                actualOBSDirectory = Path.GetDirectoryName(actualOBSDirectory);
                                actualOBSDirectory = Path.GetDirectoryName(actualOBSDirectory);

                                if (Validate(actualOBSDirectory)) return actualOBSDirectory;
                            }
                        }
                    }
                }
            }
        }

        // method 2
        {
            string programFiles32 = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            string programFiles64 = Environment.GetEnvironmentVariable("ProgramW6432");

            List<string> couldBeThePath = new List<string>
                {
                    Path.Combine(programFiles32, "obs-studio"),
                    Path.Combine(programFiles64, "obs-studio")
                };

            foreach (string path in couldBeThePath)
            {
                if (Validate(path)) return path;
            }
        }

        bool Validate(string directoryPath)
        {
            return Directory.Exists(Path.Combine(directoryPath, "bin")) &&
                Directory.Exists(Path.Combine(directoryPath, "data"));
        }

        return "";
    }

    private static string GetCurrentSceneName(string profileName)
    {
        string jsonConfigPath = Path.Combine(obsConfigPath, "basic", "scenes", profileName + ".json");

        try
        {
            if (File.Exists(jsonConfigPath))
            {
                JObject jObject = JObject.Parse(File.ReadAllText(jsonConfigPath));
                string current_scene = "";

                if (jObject.ContainsKey("current_scene"))
                {
                    current_scene = jObject["current_scene"].ToString();
                    if (current_scene != "") return current_scene;
                }
            }
        }
        catch { }

        return "";
    }

    private static string GetCurrentProfileName()
    {
        string globalConfigPath = Path.Combine(obsConfigPath, "global.ini");
        string profileName = "";

        bool getNextLine = false;
        if (File.Exists(globalConfigPath))
        {
            string[] allLines = File.ReadAllLines(globalConfigPath);

            foreach (string line in allLines)
            {
                if (getNextLine)
                {
                    if (line.Contains("Profile="))
                    {
                        profileName = line.Replace("Profile=", "");
                        break;
                    }
                }
                else if (line == "[Basic]") getNextLine = true;
            }
        }

        return profileName;
    }

    private static bool IsOBSRunning()
    {
        foreach (Process process in Process.GetProcessesByName("obs64")) return true;
        return false;
    }

    private static string GetDirectoryOBSConfig()
    {
        // method 1
        {
            string rootAppDataPath = Path.GetDirectoryName(Environment.GetFolderPath(
            Environment.SpecialFolder.ApplicationData));

            string appDataLocalPath = Path.Combine(rootAppDataPath, "Local");
            string appDataLocalLowPath = Path.Combine(rootAppDataPath, "LocalLow");
            string appDataRoamingPath = Path.Combine(rootAppDataPath, "Roaming");

            List<string> couldBeThePath = new List<string>
                {
                    Path.Combine(appDataLocalPath, "obs-studio"),
                    Path.Combine(appDataLocalLowPath, "obs-studio"),
                    Path.Combine(appDataRoamingPath, "obs-studio"),
                };

            foreach (string path in couldBeThePath)
            {
                if (Validate(path)) return path;
            }
        }

        bool Validate(string directoryPath)
        {
            return Directory.Exists(Path.Combine(directoryPath, "basic"));
        }

        return "";
    }
}