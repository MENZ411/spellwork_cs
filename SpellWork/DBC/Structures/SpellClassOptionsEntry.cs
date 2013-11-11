﻿using DBFilesClient.NET;

namespace SpellWork.DBC.Structures
{
    public sealed class SpellClassOptionsEntry
    {
        public uint Id;
        public uint ModalNextSpell;
        [StoragePresence(StoragePresenceOption.Include, ArraySize = 4)]
        public uint[] SpellFamilyFlags;
        public uint SpellFamilyName;
    }
}
