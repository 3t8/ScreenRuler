﻿using System;
using ScreenRuler.Colors;
using ScreenRuler.Units;

namespace ScreenRuler
{
    [Serializable]
    public class Settings
    {
        /// <summary>
        /// Determines whether the ruler is in vertical mode.
        /// </summary>
        public bool Vertical { get; set; }
        /// <summary>
        /// The currently selected measuring unit.
        /// </summary>
        public MeasuringUnit MeasuringUnit { get; set; }
        /// <summary>
        /// The DPI value that is used for calculating the distances on the ruler scale
        /// (hardcoded to 96 by default).
        /// </summary>
        public int MonitorDpi { get; set; } = 96;
        /// <summary>
        /// Determines whether the center of the ruler should be marked.
        /// </summary>
        public bool ShowCenterLine { get; set; }
        /// <summary>
        /// Determines whether the thirds of the ruler should be marked.
        /// </summary>
        public bool ShowThirdLines { get; set; }
        /// <summary>
        /// Determines whether the position of the cursor should be marked.
        /// </summary>
        public bool ShowMouseLine { get; set; } = true;
        /// <summary>
        /// Determines if multiple markings are allowed.
        /// </summary>
        public bool MultiMarking { get; set; }

        private ThemeOption selectedTheme;
        /// <summary>
        /// The currently selected theme option.
        /// </summary>
        public ThemeOption SelectedTheme
        {
            get { return selectedTheme; }
            set
            {
                selectedTheme = value;
                switch (value)
                {
                    case ThemeOption.Light:
                        Theme = CommonThemes.LightTheme;
                        break;
                    case ThemeOption.Dark:
                        Theme = CommonThemes.DarkTheme;
                        break;
                }
            }
        }
        /// <summary>
        /// The currently selected theme (influenced by SelectedTheme).
        /// </summary>
        public Theme Theme { get; set; } = CommonThemes.LightTheme;
    }
}
