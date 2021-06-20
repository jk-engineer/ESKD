#region Copyright
/*
This file is part of ESKD project.
Copyright (C) 2021 Evgeniy Ipatov

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU General Public License as published by
the Free Software Foundation, either version 3 of the License, or
(at your option) any later version.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
GNU General Public License for more details.

You should have received a copy of the GNU General Public License
along with this program. If not, see <https://www.gnu.org/licenses/>.
*/
#endregion

using System.Collections.Generic;
using System.Linq;

namespace ESKD.SheetSize
{
    /// <summary>
    /// Класс для работы с форматами листов чертежей.
    /// </summary>
    public static class SheetSizeExtensions
    {
        #region Поля, свойства

        /// <summary>
        /// Возвращает названия форматов.
        /// </summary>
        public static string[] SheetSizeNames => System.Enum.GetNames(typeof(SheetSizeEnum));

        /// <summary>
        /// Возвращает массив значений констант для перечисления форматов листов.
        /// </summary>
        public static System.Array SheetSizeValues => System.Enum.GetValues(typeof(SheetSizeEnum));

        /// <summary>
        /// Список значений высоты форматов в миллиметрах.
        /// </summary>
        private static readonly Dictionary<SheetSizeEnum, int> _heightList =
            new Dictionary<SheetSizeEnum, int>();

        /// <summary>
        /// Список значений ширины форматов в миллиметрах.
        /// </summary>
        private static readonly Dictionary<SheetSizeEnum, int> _widthList =
            new Dictionary<SheetSizeEnum, int>();

        /// <summary>
        /// Значения высоты форматов.
        /// </summary>
        private static readonly int[] _heightValues = {
            841,
            594,
            420,
            297,
            210,
            148,
            1189,
            1189,
            841,
            841,
            594,
            594,
            594,
            420,
            420,
            420,
            420,
            420,
            297,
            297,
            297,
            297,
            297,
            297,
            297,
            0
        };

        /// <summary>
        /// Значения ширины форматов.
        /// </summary>
        private static readonly int[] _widthValues = {
            1189,
            841,
            594,
            420,
            297,
            210,
            1682,
            2523,
            1783,
            2378,
            1261,
            1682,
            2102,
            891,
            1189,
            1486,
            1783,
            2080,
            630,
            841,
            1051,
            1261,
            1471,
            1682,
            1892,
            0
        };

        #endregion

        #region Конструктор класса

        /// <summary>
        /// Статический конструктор класса.
        /// </summary>
        static SheetSizeExtensions()
        {
            // Заполнение коллекций значениями высоты и ширины форматов.
            for (int index = 0; index < SheetSizeNames.Count(); index++)
            {
                _heightList.Add((SheetSizeEnum)index, _heightValues[index]);
                _widthList.Add((SheetSizeEnum)index, _widthValues[index]);
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Возвращает формат листа чертежа согласно ГОСТ 2.301.
        /// </summary>
        /// <param name="height">Высота листа в миллиметрах.</param>
        /// <param name="width">Ширина листа в миллиметрах.</param>
        /// <returns></returns>
        public static SheetSizeEnum GetSheetSize(int height, int width)
        {
            // Возвращает результат проверки соответствия размера формата листа требованиям ГОСТ 2.301.
            bool CheckSize(int checkValue, int standardValue)
            {
                bool result;
                if ((checkValue <= 150) & (System.Math.Abs(standardValue - checkValue) <= 1.5))
                {
                    result = true;
                }
                else if ((checkValue > 150) & (checkValue <= 600) & (System.Math.Abs(standardValue - checkValue) <= 2.0))
                {
                    result = true;
                }
                else if ((checkValue > 600) & (System.Math.Abs(standardValue - checkValue) <= 3.0))
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
                return result;
            }

            SheetSizeEnum resultValue = SheetSizeEnum.NonStandard;
            foreach (SheetSizeEnum size in _heightList.Keys)
            {
                int standardHeight = _heightList[size];
                int standardWidth = _widthList[size];
                // Проверяются альбомные и портретные ориентации листа.
                if ((CheckSize(height, standardHeight) & CheckSize(width, standardWidth)) ||
                    (CheckSize(height, standardWidth) & CheckSize(width, standardHeight)))
                {
                    resultValue = size;
                    break;
                }
            }
            return resultValue;
        }

        /// <summary>
        /// Возвращает имя указанного формата.
        /// </summary>
        /// <param name="sheetSize">Формат листа чертежа согласно ГОСТ 2.301.</param>
        /// <returns></returns>
        public static string Name(this SheetSizeEnum sheetSize) =>
            System.Enum.GetName(typeof(SheetSizeEnum), sheetSize);

        /// <summary>
        /// Возвращает высоту указанного формата в миллиметрах (для альбомной ориентации).
        /// </summary>
        /// <param name="sheetSize">Формат листа чертежа согласно ГОСТ 2.301.</param>
        /// <returns></returns>
        public static int Height(this SheetSizeEnum sheetSize) =>
            _heightList[sheetSize];

        /// <summary>
        /// Возвращает ширину указанного формата в миллиметрах (для альбомной ориентации).
        /// </summary>
        /// <param name="sheetSize">Формат листа чертежа согласно ГОСТ 2.301.</param>
        /// <returns></returns>
        public static int Width(this SheetSizeEnum sheetSize) =>
            _widthList[sheetSize];

        /// <summary>
        /// Возвращает площадь указанного формата в квадратных миллиметрах.
        /// </summary>
        /// <param name="sheetSize">Формат листа чертежа согласно ГОСТ 2.301.</param>
        /// <returns></returns>
        public static int GetArea(this SheetSizeEnum sheetSize) =>
            sheetSize.Height() * sheetSize.Width();

        #endregion
    }
}
