﻿using System.Collections.Generic;
using System.IO;
using System.Linq;
using Filtration.Common.Utilities;
using Filtration.Properties;

namespace Filtration.Services
{
    public interface IStaticDataService
    {
        IEnumerable<string> ItemBaseTypes { get; }
        IEnumerable<string> ItemClasses { get; }
        IEnumerable<string> ItemMods { get; }
    }

    internal class StaticDataService : IStaticDataService
    {
        public StaticDataService()
        {
            PopulateStaticData();
        }

        public IEnumerable<string> ItemBaseTypes { get; private set; }

        public IEnumerable<string> ItemClasses { get; private set; }

        public IEnumerable<string> ItemMods { get; private set; }

        private void PopulateStaticData()
        {
            ItemBaseTypes = new LineReader(() => new StringReader(Resources.ItemBaseTypes)).ToList();
            ItemClasses = new LineReader(() => new StringReader(Resources.ItemClasses)).ToList();
            ItemMods = new LineReader(() => new StringReader(Resources.ItemMods)).ToList();
        }
    }
}
