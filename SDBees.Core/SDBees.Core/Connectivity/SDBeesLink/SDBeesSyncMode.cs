﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace SDBees.Core.Connectivity.SDBeesLink
{
    /// <summary>
    /// Der Modus beim Synchronisieren
    /// </summary>
	public enum SDBeesSyncMode : int
	{
        /// <summary>
        /// vom Client zum Server
        /// </summary>
        ShowServerDialog,
        /// <summary>
        /// vom Client zum Server
        /// </summary>
		UpdateServer, UpdateServerValidation,
		/// <summary>
		/// vom Server zum Client
		/// </summary>
        UpdateClient,
		/// <summary>
		/// in beide Richtungen
		/// </summary>
        Synchronize,
        /// <summary>
        /// show Dataset only
        /// </summary>
        EditDataSet,
        /// <summary>
        /// set up the building structure
        /// </summary>
        SetUpBuildingStructure,
        /// <summary>
        /// invalidate elements
        /// </summary>
        InvalidateElements,
        /// <summary>
        /// show issue browser
        /// </summary>
        ShowIssueBrowser
	}
}
