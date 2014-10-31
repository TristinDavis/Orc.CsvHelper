﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CsvEnvironment.cs" company="Orcomp development team">
//   Copyright (c) 2008 - 2014 Orcomp development team. All rights reserved.
// </copyright>
// --------------------------------------------------------------------------------------------------------------------


namespace Orc.Csv
{
    using System;
    using System.Globalization;

    public static class CsvEnvironment
    {
        #region Constants
        public static readonly DateTime ExcelNullDate = new DateTime(1900, 1, 1, 0, 0, 0);

        public static CultureInfo DefaultCultureInfo = new CultureInfo("en-AU");
        #endregion
    }
}