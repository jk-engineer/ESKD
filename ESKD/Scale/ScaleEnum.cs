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

namespace ESKD.Scale
{
    /// <summary>
    /// Масштаб чертежа согласно ГОСТ 2.302.
    /// </summary>
    public enum ScaleEnum
    {
        /// <summary>
        /// Масштаб 1:50000 (дополнительный).
        /// </summary>
        Scale_1_to_50000,

        /// <summary>
        /// Масштаб 1:25000 (дополнительный).
        /// </summary>
        Scale_1_to_25000,

        /// <summary>
        /// Масштаб 1:20000 (дополнительный).
        /// </summary>
        Scale_1_to_20000,

        /// <summary>
        /// Масштаб 1:10000 (дополнительный).
        /// </summary>
        Scale_1_to_10000,

        /// <summary>
        /// Масштаб 1:5000 (дополнительный).
        /// </summary>
        Scale_1_to_5000,

        /// <summary>
        /// Масштаб 1:2000 (дополнительный).
        /// </summary>
        Scale_1_to_2000,

        /// <summary>
        /// Масштаб 1:1000.
        /// </summary>
        Scale_1_to_1000,

        /// <summary>
        /// Масштаб 1:800.
        /// </summary>
        Scale_1_to_800,

        /// <summary>
        /// Масштаб 1:500.
        /// </summary>
        Scale_1_to_500,

        /// <summary>
        /// Масштаб 1:400.
        /// </summary>
        Scale_1_to_400,

        /// <summary>
        /// Масштаб 1:200.
        /// </summary>
        Scale_1_to_200,

        /// <summary>
        /// Масштаб 1:100.
        /// </summary>
        Scale_1_to_100,

        /// <summary>
        /// Масштаб 1:75.
        /// </summary>
        Scale_1_to_75,

        /// <summary>
        /// Масштаб 1:50.
        /// </summary>
        Scale_1_to_50,

        /// <summary>
        /// Масштаб 1:40.
        /// </summary>
        Scale_1_to_40,

        /// <summary>
        /// Масштаб 1:25.
        /// </summary>
        Scale_1_to_25,

        /// <summary>
        /// Масштаб 1:20.
        /// </summary>
        Scale_1_to_20,

        /// <summary>
        /// Масштаб 1:15.
        /// </summary>
        Scale_1_to_15,

        /// <summary>
        /// Масштаб 1:10.
        /// </summary>
        Scale_1_to_10,

        /// <summary>
        /// Масштаб 1:5.
        /// </summary>
        Scale_1_to_5,

        /// <summary>
        /// Масштаб 1:4.
        /// </summary>
        Scale_1_to_4,

        /// <summary>
        /// Масштаб 1:2,5.
        /// </summary>
        Scale_1_to_2p5,

        /// <summary>
        /// Масштаб 1:2.
        /// </summary>
        Scale_1_to_2,

        /// <summary>
        /// Масштаб 1:1.
        /// </summary>
        Scale_1_to_1,

        /// <summary>
        /// Масштаб 2:1.
        /// </summary>
        Scale_2_to_1,

        /// <summary>
        /// Масштаб 2,5:1.
        /// </summary>
        Scale_2p5_to_1,

        /// <summary>
        /// Масштаб 4:1.
        /// </summary>
        Scale_4_to_1,

        /// <summary>
        /// Масштаб 5:1.
        /// </summary>
        Scale_5_to_1,

        /// <summary>
        /// Масштаб 10:1.
        /// </summary>
        Scale_10_to_1,

        /// <summary>
        /// Масштаб 20:1.
        /// </summary>
        Scale_20_to_1,

        /// <summary>
        /// Масштаб 40:1.
        /// </summary>
        Scale_40_to_1,

        /// <summary>
        /// Масштаб 50:1.
        /// </summary>
        Scale_50_to_1,

        /// <summary>
        /// Масштаб 100:1.
        /// </summary>
        Scale_100_to_1,

        /// <summary>
        /// Нестандартный масштаб.
        /// </summary>
        NonStandard
    }
}
