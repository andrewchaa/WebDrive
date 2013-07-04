﻿using System.Collections.Generic;
using LondonUbfWebDrive.Domain.Model;

namespace LondonUbfWebDrive.Domain.Interfaces
{
    public interface IMetaDataRepository
    {
        void Save(DocumentMetadata documentMetadata);
        IEnumerable<DocumentMetadata> List();
        IEnumerable<DocumentMetadata> ListPopular();
        IEnumerable<DocumentMetadata> ListRecentDownloads();
    }
}