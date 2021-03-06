//=====================================================================================================================
// Проект: LotusPlatform
// Раздел: Модуль алгоритмов
// Автор: MagistrBYTE aka DanielDem <dementevds@gmail.com>
//---------------------------------------------------------------------------------------------------------------------
/** \file LotusAlgorithmSettings.cs
*		Настройки модуля алгоритмов применительно к режиму разработки и редактору Unity.
*/
//---------------------------------------------------------------------------------------------------------------------
// Версия: 1.0.0.0
// Последнее изменение от 27.03.2022
//=====================================================================================================================
using System;
using System.Runtime.CompilerServices;
//---------------------------------------------------------------------------------------------------------------------
using Lotus.Core;
//=====================================================================================================================
namespace Lotus
{
	namespace Algorithm
	{
		//-------------------------------------------------------------------------------------------------------------
		//! \addtogroup Algorithm
		/*@{*/
		//-------------------------------------------------------------------------------------------------------------
		/// <summary>
		/// Статический класс для определения настроек модуля алгоритмов применительно к режиму разработки и редактору Unity
		/// </summary>
		//-------------------------------------------------------------------------------------------------------------
		public static class XAlgorithmEditorSettings
		{
#if UNITY_2017_1_OR_NEWER
			/// <summary>
			/// Путь в размещении меню редактора модуля алгоритмов (для упорядочивания)
			/// </summary>
			public const String MenuPath = XEditorSettings.MenuPlace + "Algorithm/";
#endif
		}
		//-------------------------------------------------------------------------------------------------------------
		/*@}*/
		//-------------------------------------------------------------------------------------------------------------
	}
}
//=====================================================================================================================