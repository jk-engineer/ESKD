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
