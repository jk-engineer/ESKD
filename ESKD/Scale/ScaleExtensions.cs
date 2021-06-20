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

namespace ESKD.Scale
{
    /// <summary>
    /// Класс для работы с масштабами чертежа согласно ГОСТ 2.302.
    /// </summary>
    public static class ScaleExtensions
    {
        #region Поля, свойсва

        /// <summary>
        /// Список масштабов в численном выражении.
        /// </summary>
        private static readonly Dictionary<ScaleEnum, double> _scaleValuesList =
            new Dictionary<ScaleEnum, double>();

        /// <summary>
        /// Список масштабов в строковом выражении.
        /// </summary>
        private static readonly Dictionary<ScaleEnum, string> _scaleStringsList =
            new Dictionary<ScaleEnum, string>();

        /// <summary>
        /// Значения для масштабов.
        /// </summary>
        private static readonly double[] _scaleValues = {
            50000.0,
            25000.0,
            20000.0,
            10000.0,
            5000.0,
            2000.0,
            1000.0,
            800.0,
            500.0,
            400.0,
            200.0,
            100.0,
            75.0,
            50.0,
            40.0,
            25.0,
            20.0,
            15.0,
            10.0,
            5.0,
            4.0,
            2.5,
            2.0,
            1.0,
            2.0,
            2.5,
            4.0,
            5.0,
            10.0,
            20.0,
            40.0,
            50.0,
            100.0,
            0.0
        };

        #endregion

        #region Конструктор класса

        /// <summary>
        /// Статический конструктор класса.
        /// </summary>
        static ScaleExtensions()
        {
            // Заполнение списков численного и текстового представления масштабов.
            bool realScale = false;
            for (int index = 0; index < _scaleValues.Length; index++)
            {
                double scaleValue = _scaleValues[index];
                string scaleString = scaleValue.ToString().Replace(".", ",");
                if (scaleValue == 1.0)
                {
                    realScale = true;
                }
                if (!realScale)
                {
                    _scaleValuesList.Add((ScaleEnum)index, 1.0 / scaleValue);
                    _scaleStringsList.Add((ScaleEnum)index, $"1:{scaleString}");
                }
                else
                {
                    _scaleValuesList.Add((ScaleEnum)index, scaleValue);
                    _scaleStringsList.Add((ScaleEnum)index, $"{scaleString}:1");
                }
            }
        }

        #endregion

        #region Методы

        /// <summary>
        /// Возвращает численное значение указанного масштаба.
        /// </summary>
        /// <param name="scale">Масштаб.</param>
        /// <returns></returns>
        public static double GetValue(this ScaleEnum scale) => _scaleValuesList[scale];

        /// <summary>
        /// Возвращает строковое значение указанного масштаба.
        /// </summary>
        /// <param name="scale">Масштаб.</param>
        /// <returns></returns>
        public static string GetString(this ScaleEnum scale) => _scaleStringsList[scale];

        #endregion
    }
}
