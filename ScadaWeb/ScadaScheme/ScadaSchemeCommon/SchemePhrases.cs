﻿/*
 * Copyright 2017 Mikhail Shiryaev
 * 
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 * 
 *     http://www.apache.org/licenses/LICENSE-2.0
 * 
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 * 
 * 
 * Product  : Rapid SCADA
 * Module   : ScadaWebCommon
 * Summary  : The common phrases for schemes
 * 
 * Author   : Mikhail Shiryaev
 * Created  : 2017
 * Modified : 2017
 */

#pragma warning disable 1591 // отключение warning CS1591: Missing XML comment for publicly visible type or member

namespace Scada.Scheme
{
    /// <summary>
    /// The common phrases for schemes
    /// <para>Общие фразы для схем</para>
    /// </summary>
    public static class SchemePhrases
    {
        static SchemePhrases()
        {
            SetToDefault();
        }

        // Словарь Scada.Scheme.SchemeView
        public static string LoadSchemeViewError { get; private set; }
        public static string SaveSchemeViewError { get; private set; }

        private static void SetToDefault()
        {
            LoadSchemeViewError = Localization.Dict.GetEmptyPhrase("LoadSchemeViewError");
            SaveSchemeViewError = Localization.Dict.GetEmptyPhrase("SaveSchemeViewError");
        }

        public static void Init()
        {
            Localization.Dict dict;
            if (Localization.Dictionaries.TryGetValue("Scada.Scheme.SchemeView", out dict))
            {
                LoadSchemeViewError = dict.GetPhrase("LoadSchemeViewError", LoadSchemeViewError);
                SaveSchemeViewError = dict.GetPhrase("SaveSchemeViewError", SaveSchemeViewError);
            }
        }
    }
}