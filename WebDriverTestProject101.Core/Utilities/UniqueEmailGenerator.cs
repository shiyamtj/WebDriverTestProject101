﻿using System;

namespace WebDriverTestProject101.Core.Utilities
{
    public static class UniqueEmailGenerator
    {
        public static string EmailPrefix { get; set; } = "shiyamtj";
        public static string EmailSuffix { get; set; } = "shiyamtj.local";
        public static string GenerateUniqueEmail(string prefix, string sufix)
        {
            var result = string.Concat(prefix, "_", TimestampBuilder.GenerateUniqueText(), "@", sufix);
            return result;
        }
        public static string GenerateUniqueEmailTimestamp()
        {
            var result = $"{EmailPrefix}-{TimestampBuilder.GenerateUniqueText()}@{EmailSuffix}";
            return result;
        }
        public static string GenerateUniqueEmailGuid()
        {
            var result = $"{EmailPrefix}-{Guid.NewGuid()}@{EmailSuffix}";
            return result;
        }
        public static string GenerateUniqueEmail(string prefix)
        {
            var result = $"{prefix}{TimestampBuilder.GenerateUniqueText()}@{EmailSuffix}";
            return result;
        }
        public static string GenrateUniqueEmail(char specialSymbol)
        {
            var result = $"{EmailPrefix}-{TimestampBuilder.GenerateUniqueText()}{specialSymbol}@{EmailSuffix}";
            return result;
        }
    }
}
