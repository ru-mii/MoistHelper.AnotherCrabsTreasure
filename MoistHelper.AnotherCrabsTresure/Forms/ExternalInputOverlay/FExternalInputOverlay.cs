using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoistHelper.AnotherCrabsTresure.ExternalInputOverlay
{
    public partial class FExternalInputOverlay : Form
    {
        public FExternalInputOverlay() { InitializeComponent(); }

        public static bool RefreshPending = false;
        static string formDataPath = Path.Combine(GlobalPaths.ProgramDataPath, "ExternalInputOverlay");
        static string pathSelectedPresetConfig = Path.Combine(formDataPath, "Config", "SelectedPreset.txt");
        static string pathWindowColorConfig = Path.Combine(formDataPath, "Config", "WindowColor.txt");
        static string pathWindowAlwaysOnTop = Path.Combine(formDataPath, "Config", "WindowAlwaysOnTop.txt");

        InputCodes keyCodes = new InputCodes();
        InputCodes mouseCodes = new InputCodes();

        Image dodgeOn, dodgeOff, walkForwardOn, walkForwardOff, attackOn, attackOff,
            walkLeftOn, walkLeftOff, walkBackwardOn, walkBackwardOff, walkRightOn, walkRightOff,
            interactOn, interactOff, jumpOn, jumpOff, useAdaptationOn, useAdaptationOff;

        private void timer_KeyUpdate_Tick(object sender, EventArgs e)
        {
            if (dodgeOn != null && dodgeOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.Dodge)) pictureBox_Dodge.Image = dodgeOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.Dodge)) pictureBox_Dodge.Image = dodgeOn;
                else pictureBox_Dodge.Image = dodgeOff;
            }

            if (walkForwardOn != null && walkForwardOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.WalkForward)) pictureBox_WalkForward.Image = walkForwardOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.WalkForward)) pictureBox_WalkForward.Image = walkForwardOn;
                else pictureBox_WalkForward.Image = walkForwardOff;
            }

            if (attackOn != null && attackOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.Attack)) pictureBox_Attack.Image = attackOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.Attack)) pictureBox_Attack.Image = attackOn;
                else pictureBox_Attack.Image = attackOff;
            }

            if (walkLeftOn != null && walkLeftOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.WalkLeft)) pictureBox_WalkLeft.Image = walkLeftOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.WalkLeft)) pictureBox_WalkLeft.Image = walkLeftOn;
                else pictureBox_WalkLeft.Image = walkLeftOff;
            }

            if (walkBackwardOn != null && walkBackwardOn != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.WalkBackward)) pictureBox_WalkBackward.Image = walkBackwardOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.WalkBackward)) pictureBox_WalkBackward.Image = walkBackwardOn;
                else pictureBox_WalkBackward.Image = walkBackwardOff;
            }

            if (walkRightOn != null && walkRightOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.WalkRight)) pictureBox_WalkRight.Image = walkRightOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.WalkRight)) pictureBox_WalkRight.Image = walkRightOn;
                else pictureBox_WalkRight.Image = walkRightOff;
            }

            if (interactOn != null && interactOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.Interact)) pictureBox_Interact.Image = interactOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.Interact)) pictureBox_Interact.Image = interactOn;
                else pictureBox_Interact.Image = interactOff;
            }

            if (jumpOn != null && jumpOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.Jump)) pictureBox_Jump.Image = jumpOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.Jump)) pictureBox_Jump.Image = jumpOn;
                else pictureBox_Jump.Image = jumpOff;
            }

            if (useAdaptationOn != null && useAdaptationOff != null)
            {
                if (ProgramUtils.IsKeyPressed(keyCodes.UseAdaptation)) pictureBox_UseAdaptation.Image = useAdaptationOn;
                else if (ProgramUtils.IsKeyPressed(mouseCodes.UseAdaptation)) pictureBox_UseAdaptation.Image = useAdaptationOn;
                else pictureBox_UseAdaptation.Image = useAdaptationOff;
            }
        }

        private void FExternalInputOverlay_Load(object sender, EventArgs e)
        {
            RefreshPending = false;
            Paint += NoAntiAliasing_Paint;
            LoadSettings();
            timer_KeyUpdate.Enabled = true;
        }

        private class InputCodes
        {
            internal int WalkLeft { get; set; } = 0x41;
            internal int WalkRight { get; set; } = 0x44;
            internal int WalkForward { get; set; } = 0x57;
            internal int WalkBackward { get; set; } = 0x53;
            internal int Attack { get; set; } = 0x1;
            internal int Dodge { get; set; } = 0xA0;
            internal int Interact { get; set; } = 0x45;
            internal int Jump { get; set; } = 0x20;
            internal int UseAdaptation { get; set; } = 0x51;
        }

        private void LoadSettings()
        {
            if (File.Exists(pathSelectedPresetConfig)) LoadPreset(File.ReadAllText(pathSelectedPresetConfig));
            else LoadPreset(GetSelectedPreset());

            if (File.Exists(pathWindowColorConfig)) BackColor = ProgramUtils.HexToColor(File.ReadAllText(pathWindowColorConfig));
            else BackColor = Color.LimeGreen;

            TopMost = false;
            if (File.Exists(pathWindowAlwaysOnTop))
            {
                string readData = File.ReadAllText(pathWindowAlwaysOnTop);
                if (readData == "Yes") TopMost = true;
            }

            ReadInputData();
        }

        private void ReadInputData()
        {
            List<Action> actionsKeyboard = GetMapActions("KeyboardMap");
            keyCodes = ActionsToCodes(actionsKeyboard);

            List<Action> actionsMouse = GetMapActions("MouseMap");
            mouseCodes = ActionsToCodes(actionsMouse);

            List<Action> actionsJoystick = GetMapActions("JoystickMap");
            mouseCodes = ActionsToCodes(actionsMouse);
        }

        private string controlMappingPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData)
            + "Low", "Aggro Crab", "AnotherCrabsTreasure", "ControlMapping.userSettings");

        List<Action> GetMapActions(string mapName)
        {
            List<Action> actions = new List<Action>();

            if (File.Exists(controlMappingPath))
            {
                string data = File.ReadAllText(controlMappingPath);
                string mapData = "";

                string searchFor = "RewiredSaveData|playerName=Player0|dataType=ControllerMap|kv=2|controllerMapType=";
                int indexOf = data.IndexOf(searchFor);

                if (indexOf != -1)
                {
                    data = data.Remove(0, indexOf);
                    searchFor = "<" + mapName + " data";
                    indexOf = data.IndexOf(searchFor);

                    if (indexOf != -1)
                    {
                        string mapDataRaw = data.Remove(0, indexOf);

                        searchFor = "</" + mapName + ">";
                        indexOf = mapDataRaw.IndexOf(searchFor);

                        if (indexOf != -1)
                        {
                            mapData = mapDataRaw.Substring(0, indexOf + searchFor.Length);
                        }
                    }

                    if (mapData != "")
                    {
                        // read keys
                        {
                            searchFor = "<ActionElementMap>";
                            indexOf = mapData.IndexOf(searchFor);

                            if (indexOf != -1)
                            {
                                mapData = mapData.Remove(0, indexOf);

                                int counter = 0;
                                actions.Clear();
                                while (mapData.Contains("</ActionElementMap>"))
                                {
                                    int actionId = 0;
                                    int elementIdentifierId = 0;
                                    int axisContribution = 0;
                                    int keyboardKeyCode = 0;
                                    int axisRange = 0;
                                    int elementType = 0;

                                    string action = "";

                                    searchFor = "</ActionElementMap>";
                                    indexOf = mapData.IndexOf(searchFor);

                                    if (indexOf != -1)
                                    {
                                        action = mapData.Substring(0, indexOf + searchFor.Length);

                                        bool flag = int.TryParse(GetMapElementField(action, "actionId"), out actionId) &&
                                        int.TryParse(GetMapElementField(action, "elementIdentifierId"), out elementIdentifierId) &&
                                        int.TryParse(GetMapElementField(action, "axisContribution"), out axisContribution) &&
                                        int.TryParse(GetMapElementField(action, "keyboardKeyCode"), out keyboardKeyCode) &&
                                        int.TryParse(GetMapElementField(action, "axisRange"), out axisRange) &&
                                        int.TryParse(GetMapElementField(action, "elementType"), out elementType);

                                        if (flag)
                                        {
                                            actions.Add(new Action(actionId, elementIdentifierId,
                                                axisContribution, KeyConverter.UnityKeyToVirtualKey(keyboardKeyCode),
                                                elementType, axisRange));
                                        }
                                    }

                                    mapData = mapData.Replace(action, "");
                                    counter += 1;
                                }
                            }
                        }
                    }
                }
            }

            return actions;
        }

        private string GetMapElementField(string action, string name)
        {
            string searchFor = "</" + name + ">";
            int indexOf = action.IndexOf(searchFor);

            if (indexOf != -1)
            {
                string actionElementEdited = action.Substring(0, indexOf);

                searchFor = "<" + name + ">";
                indexOf = actionElementEdited.IndexOf(searchFor);

                if (indexOf != -1)
                {
                    return actionElementEdited.Remove(0, indexOf + searchFor.Length);
                }
            }

            return "";
        }

        private class Action
        {
            internal int actionId { get; set; }
            internal int elementIdentifierId { get; set; }
            internal int axisContribution { get; set; }
            internal int keyboardKeyCode { get; set; }
            internal int elementType { get; set; }
            internal int axisRange { get; set; }

            internal Action(int actionId, int elementIdentifierId, int axisContribution, int keyboardKeyCode, int elementType, int axisRange)
            {
                this.actionId = actionId;
                this.elementIdentifierId = elementIdentifierId;
                this.axisContribution = axisContribution;
                this.keyboardKeyCode = keyboardKeyCode;
                this.elementType = elementType;
                this.axisRange = axisRange;
            }
        }

        private InputCodes ActionsToCodes(List<Action> actions)
        {
            InputCodes newCodes = new InputCodes();
            foreach (Action action in actions)
            {
                if (action.actionId == 2 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.WalkRight = action.keyboardKeyCode;
                    else newCodes.WalkRight = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 2 && action.axisContribution == 1)
                {
                    if (action.keyboardKeyCode != 0) newCodes.WalkLeft = action.keyboardKeyCode;
                    else newCodes.WalkLeft = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 3 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.WalkForward = action.keyboardKeyCode;
                    else newCodes.WalkForward = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 3 && action.axisContribution == 1)
                {
                    if (action.keyboardKeyCode != 0) newCodes.WalkBackward = action.keyboardKeyCode;
                    else newCodes.WalkBackward = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 10 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.Interact = action.keyboardKeyCode;
                    else newCodes.Interact = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 12 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.Attack = action.keyboardKeyCode;
                    else newCodes.Attack = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 15 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.Jump = action.keyboardKeyCode;
                    else newCodes.Jump = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 38 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.Dodge = action.keyboardKeyCode;
                    else newCodes.Dodge = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }

                else if (action.actionId == 16 && action.axisContribution == 0)
                {
                    if (action.keyboardKeyCode != 0) newCodes.UseAdaptation = action.keyboardKeyCode;
                    else newCodes.UseAdaptation = GetMouseVirtualKey(action.elementType, action.elementIdentifierId, action.axisRange);
                }
            }

            return newCodes;
        }

        private int GetMouseVirtualKey(int elementType, int elementIdentifierId, int axisRange)
        {
            if (elementType == 1 && axisRange == 1)
            {
                if (elementIdentifierId == 3) return 0x01;
                else if (elementIdentifierId == 4) return 0x02;
                else if (elementIdentifierId == 5) return 0x04;
                else if (elementIdentifierId == 6) return 0x05;
                else if (elementIdentifierId == 7) return 0x06;
            }

            return 0;
        }

        private string GetSelectedPreset()
        {
            string pathSelectedPresetConfig = Path.Combine(formDataPath, "Config", "SelectedPreset.txt");
            if (File.Exists(pathSelectedPresetConfig)) return File.ReadAllText(pathSelectedPresetConfig);
            else return "Iconic";
        }

        private void LoadPreset(string name)
        {
            string pathPreset = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), "Presets", name);
            if (Directory.Exists(pathPreset))
            {
                dodgeOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "DodgeOn.png"));
                dodgeOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "DodgeOff.png"));
                walkForwardOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkForwardOn.png"));
                walkForwardOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkForwardOff.png"));
                attackOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "AttackOn.png"));
                attackOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "AttackOff.png"));
                walkLeftOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkLeftOn.png"));
                walkLeftOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkLeftOff.png"));
                walkBackwardOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkBackwardOn.png"));
                walkBackwardOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkBackwardOff.png"));
                walkRightOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkRightOn.png"));
                walkRightOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "WalkRightOff.png"));
                interactOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "InteractOn.png"));
                interactOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "InteractOff.png"));
                jumpOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "JumpOn.png"));
                jumpOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "JumpOff.png"));
                useAdaptationOn = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "UseAdaptationOn.png"));
                useAdaptationOff = ProgramUtils.TryPNGToImage(Path.Combine(pathPreset, "UseAdaptationOff.png"));
            }
        }

        private void timer_Communicator_Tick(object sender, EventArgs e)
        {
            if (RefreshPending)
            {
                LoadSettings();
                RefreshPending = false;
            }
        }

        private void NoAntiAliasing_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.TextRenderingHint = TextRenderingHint.SingleBitPerPixel;
            e.Graphics.SmoothingMode = SmoothingMode.None;
        }
    }
}
