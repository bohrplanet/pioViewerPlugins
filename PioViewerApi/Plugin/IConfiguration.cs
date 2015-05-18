﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PioViewerApi.Plugin
{
    /// <summary>
    /// Some subset of configuration properties that control the behavior of the PioViewer GUI.
    /// </summary>
    public interface IConfiguration
    {
        bool ShowEVInMainView { get; }
        bool ShowSquaresProportionalToWeight { get; }
        int CalculationTimeout { get; }
        int NumberOfThreads { get; }
        bool HideEmptyCells { get; }
        bool ShowTotalCombos { get; }
        string OOPName { get; }
        string IPName { get; }
        bool ShowDeadCardsInRectangles { get; }
        bool DontUseUnicodeSuits { get; }
        bool DontUseSuitsColorsInZoom { get; }
        bool GetDontShowWarning(string key);
        string PluginsDirectory { get; }
        bool UseWeightedAveragesForEquityAndEV { get; }
        bool ShowBarsWeightedByRange { get; }
        bool LocalFrequenciesOnActionBar { get; }
        string GetPlayerName(int index);

        String EVRescalingExpression { get; }
        String EVColorRescalingExpression { get; }
    }
}