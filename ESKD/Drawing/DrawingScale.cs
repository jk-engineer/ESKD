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

namespace ESKD.Drawing
{
    /// <summary>
    /// Масштаб чертежа согласно ГОСТ 2.302.
    /// </summary>
    public static class DrawingScale
    {
        /// <summary>
        /// Масштаб чертежа согласно ГОСТ 2.302.
        /// </summary>
        public enum DrawingScaleEnum
        {
            /// <summary>
            /// Масштаб 1:50000 (дополнительный).
            /// </summary>
            Scale_1_50000,

            /// <summary>
            /// Масштаб 1:25000 (дополнительный).
            /// </summary>
            Scale_1_25000,

            /// <summary>
            /// Масштаб 1:20000 (дополнительный).
            /// </summary>
            Scale_1_20000,

            /// <summary>
            /// Масштаб 1:10000 (дополнительный).
            /// </summary>
            Scale_1_10000,

            /// <summary>
            /// Масштаб 1:5000 (дополнительный).
            /// </summary>
            Scale_1_5000,

            /// <summary>
            /// Масштаб 1:2000 (дополнительный).
            /// </summary>
            Scale_1_2000,

            /// <summary>
            /// Масштаб 1:1000.
            /// </summary>
            Scale_1_1000,

            /// <summary>
            /// Масштаб 1:800.
            /// </summary>
            Scale_1_800,

            /// <summary>
            /// Масштаб 1:500.
            /// </summary>
            Scale_1_500,

            /// <summary>
            /// Масштаб 1:400.
            /// </summary>
            Scale_1_400,

            /// <summary>
            /// Масштаб 1:200.
            /// </summary>
            Scale_1_200,

            /// <summary>
            /// Масштаб 1:100.
            /// </summary>
            Scale_1_100,

            /// <summary>
            /// Масштаб 1:75.
            /// </summary>
            Scale_1_75,

            /// <summary>
            /// Масштаб 1:50.
            /// </summary>
            Scale_1_50,

            /// <summary>
            /// Масштаб 1:40.
            /// </summary>
            Scale_1_40,

            /// <summary>
            /// Масштаб 1:25.
            /// </summary>
            Scale_1_25,

            /// <summary>
            /// Масштаб 1:20.
            /// </summary>
            Scale_1_20,

            /// <summary>
            /// Масштаб 1:15.
            /// </summary>
            Scale_1_15,

            /// <summary>
            /// Масштаб 1:10.
            /// </summary>
            Scale_1_10,

            /// <summary>
            /// Масштаб 1:5.
            /// </summary>
            Scale_1_5,

            /// <summary>
            /// Масштаб 1:4.
            /// </summary>
            Scale_1_4,

            /// <summary>
            /// Масштаб 1:2,5.
            /// </summary>
            Scale_1_2_5,

            /// <summary>
            /// Масштаб 1:2.
            /// </summary>
            Scale_1_2,

            /// <summary>
            /// Масштаб 1:1.
            /// </summary>
            Scale_1_1,

            /// <summary>
            /// Масштаб 2:1.
            /// </summary>
            Scale_2_1,

            /// <summary>
            /// Масштаб 2,5:1.
            /// </summary>
            Scale_2_5_1,

            /// <summary>
            /// Масштаб 4:1.
            /// </summary>
            Scale_4_1,

            /// <summary>
            /// Масштаб 5:1.
            /// </summary>
            Scale_5_1,

            /// <summary>
            /// Масштаб 10:1.
            /// </summary>
            Scale_10_1,

            /// <summary>
            /// Масштаб 20:1.
            /// </summary>
            Scale_20_1,

            /// <summary>
            /// Масштаб 40:1.
            /// </summary>
            Scale_40_1,

            /// <summary>
            /// Масштаб 50:1.
            /// </summary>
            Scale_50_1,

            /// <summary>
            /// Масштаб 100:1.
            /// </summary>
            Scale_100_1,

            /// <summary>
            /// Нестандартный масштаб.
            /// </summary>
            NonStandard
        }
    }
}
