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
    /// Виды документов согласно ГОСТ 2.102.
    /// </summary>
    public enum DocumentTypeEnum
    {
        /// <summary>
        /// Электронная модель детали.
        /// </summary>
        DigitalPartModel,

        /// <summary>
        /// Чертеж детали.
        /// </summary>
        PartDrawing,

        /// <summary>
        /// Электронная модель сборочной единицы.
        /// </summary>
        DigitalAssemblyModel,

        /// <summary>
        /// Сборочный чертеж.
        /// </summary>
        AssemblyDrawing,

        /// <summary>
        /// Чертеж общего вида.
        /// </summary>
        GeneralViewDrawing,

        /// <summary>
        /// Теоретический чертеж.
        /// </summary>
        TheoreticalDrawing,

        /// <summary>
        /// Габаритный чертеж.
        /// </summary>
        DimensionalDrawing,

        /// <summary>
        /// Электромонтажный чертеж.
        /// </summary>
        ElectricalInstallationDrawing,

        /// <summary>
        /// Монтажный чертеж.
        /// </summary>
        InstallationDrawing,

        /// <summary>
        /// Упаковочный чертеж.
        /// </summary>
        PackagingDrawing,

        /// <summary>
        /// Схема.
        /// </summary>
        Scheme,

        /// <summary>
        /// Электронная структура изделия.
        /// </summary>
        DigitalProductStructure,

        /// <summary>
        /// Спецификация.
        /// </summary>
        BillOfMaterials,

        /// <summary>
        /// Ведомость спецификаций.
        /// </summary>
        BOMList,

        /// <summary>
        /// Ведомость ссылочных документов.
        /// </summary>
        ReferenceDocumentsList,

        /// <summary>
        /// Ведомость покупных изделий.
        /// </summary>
        PurchasedProductsList,

        /// <summary>
        /// Ведомость разрешения применения покупных изделий.
        /// </summary>
        PurchasedProductsPermitList,

        /// <summary>
        /// Ведомость держателей подлинников.
        /// </summary>
        OriginalOwnersList,

        /// <summary>
        /// Ведомость технического предложения.
        /// </summary>
        TechnicalProposalList,

        /// <summary>
        /// Ведомость эскизного проекта.
        /// </summary>
        DraftDesignList,

        /// <summary>
        /// Ведомость технического проекта.
        /// </summary>
        TechnicalDesignList,

        /// <summary>
        /// Пояснительная записка.
        /// </summary>
        ExplanatoryNote,

        /// <summary>
        /// Ведомость электронных документов.
        /// </summary>
        DigitalDocumentsList,

        /// <summary>
        /// Технические условия.
        /// </summary>
        TechnicalSpecifications,

        /// <summary>
        /// Программа и методика испытаний.
        /// </summary>
        TestProgramAndMethodology,

        /// <summary>
        /// Расчет.
        /// </summary>
        Calculation,

        /// <summary>
        /// Эксплуатационные документы.
        /// </summary>
        ExploitationDocuments,

        /// <summary>
        /// Ремонтные документы.
        /// </summary>
        RepairDocuments,

        /// <summary>
        /// Инструкция.
        /// </summary>
        ManualDocument
    }
}
