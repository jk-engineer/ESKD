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

namespace ESKD.Document
{
    /// <summary>
    /// Наименование документа в зависимости от способа выполнения и характера использования согласно ГОСТ 2.102.
    /// </summary>
    public enum DocumentStatusEnum
    {
        /// <summary>
        /// Документ, находящийся в разработке.
        /// </summary>
        Develop,

        /// <summary>
        /// Оригинал.
        /// </summary>
        Original,

        /// <summary>
        /// Подлинник.
        /// </summary>
        ApprovedOriginal,

        /// <summary>
        /// Дубликат.
        /// </summary>
        Duplicate,

        /// <summary>
        /// Копия.
        /// </summary>
        Copy
    }
}
