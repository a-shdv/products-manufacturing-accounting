﻿using DocumentFormat.OpenXml.Spreadsheet;

namespace GoToWorkBusinessLogic.HelperModels
{
    public class ExcelMergeParameters
    {
        public Worksheet Worksheet { get; set; }
        public string CellFromName { get; set; }
        public string CellToName { get; set; }
        public string Merge => $"{CellFromName}:{CellToName}";
    }
}
