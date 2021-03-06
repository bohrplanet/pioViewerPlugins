﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using PioViewerApi.Server;

namespace PioViewerApi.Plugin
{
    /// <summary>
    /// The object to control the PioViewer browser state.
    /// </summary>
    public interface IBrowserController
    {
        /// <summary>
        /// Gets or changes the selected node in the GUI
        /// </summary>
        IServerNode SelectedNode { get; set; }

        /// <summary>
        /// Event triggered when the selected node is changed in GUI
        /// </summary>
        event Action<IServerNode> SelectedNodeChanged;

        /// <summary>
        /// Filename of the tree currently open in GUI. Null if there is none.
        /// </summary>
        string CurrentFileName { get; }

        /// <summary>
        /// Get the current location of a browser on the screen
        /// </summary>
        Point Location { get; }

        /// <summary>
        /// Get the parameters of the currently build tree
        /// </summary>
        string CurrentTreeParameters { get; }

        /// <summary>
        /// Get the tree building parameters as defined in a tree building control
        /// </summary>
        string TreeBuildingParameters { get; }

        /// <summary>
        /// Get the tree building parameters as defined in a old style tree building control
        /// </summary>
        string TreeBuildingParametersOldStyle { get; }

        /// <summary>
        /// Get the tree building parameters as defined in a old style tree building control
        /// </summary>
        string TreeBuildingParametersOldLimit { get; }
    }

    
}
